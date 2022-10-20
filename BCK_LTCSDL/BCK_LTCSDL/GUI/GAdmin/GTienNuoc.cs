using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using BCK_LTCSDL.MODEL;
using BCK_LTCSDL.CONTROLLER;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;
using System.Data.SqlClient;
using BCK_LTCSDL.GUI.GStaff;

namespace BCK_LTCSDL.GUI.GAdmin
{
    public partial class GTienNuoc : Form
    {
        public GTienNuoc(string txt)
        {
            InitializeComponent();
            lbMa.Text = txt.ToString();
            tbMaNV.Text = txt.ToString();
            layten();
            layvaitro();
            xetquyen();
            tbMaNV.ReadOnly = true;
        }
        string connection = Properties.Settings.Default.connection;
        private void xetquyen()
        {
            if (lbVT.Text == "Quản lý")
            {
                btThem.Enabled = false;
                btXoa.Enabled = false;
                btSua.Enabled = false;

            }
        }
        public void layten()
        {
            SqlConnection conn = new SqlConnection(connection);
            string hoten = "select tb_NhanVien.TenNV from tb_NhanVien where tb_NhanVien.MaNV = '" + lbMa.Text + "'  ";
            SqlCommand Comm_Ten = new SqlCommand(hoten, conn);
            conn.Open();
            SqlDataReader DR_Ten = Comm_Ten.ExecuteReader();
            if (DR_Ten.Read())
            {
                lbTen.Text = DR_Ten.GetValue(0).ToString();
            }
            conn.Close();
        }
        private void layvaitro()
        {
            CVaiTro c = new CVaiTro();
            int dem = c.LayVaiTro(lbMa.Text);
            if (dem == 1)
            {
                lbVT.Text = "Quản lý";
            }
            if (dem == -1)
            {
                lbVT.Text = "Nhân viên";
            }
            else if (dem == 2)
            {
                lbVT.Text = "Sinh viên";
            }
        }
        private void GTienNuoc_Load(object sender, EventArgs e)
        {
            CTienNuoc c = new CTienNuoc();
            DocDS(c.SelectListByNoiDung(""));
        }
        private void DocDS(List<MTienNuoc> ds)
        {
            if (ds != null && ds.Count > 0)
            {
                DataTable tb = new DataTable();
                tb.Columns.Add("TT", typeof(int));
                tb.Columns.Add("SHD", typeof(String));
                tb.Columns.Add("Số phòng", typeof(String));
                tb.Columns.Add("Tiền nước", typeof(String));
                tb.Columns.Add("Ngày thu tiền", typeof(String));
                tb.Columns.Add("Mã SV", typeof(String));
                tb.Columns.Add("Mã NV", typeof(String));
                tb.Columns.Add("Tình trạng", typeof(String));
                int tt = 0;
                foreach (MTienNuoc m in ds)
                {
                    tt++;
                    DataRow r = tb.NewRow();
                    r["TT"] = tt;
                    r["SHD"] = m.shd;
                    r["Số phòng"] = m.sophong;
                    r["Tiền nước"] = m.tiennuoc;
                    r["Ngày thu tiền"] = m.ngaythutien;
                    r["Mã SV"] = m.masv;
                    r["Mã NV"] = m.manv;
                    r["Tình trạng"] = m.tinhtrang;
                    tb.Rows.Add(r);
                }
                dgv_qltiennuoc.DataSource = tb;
                //dgvDanhSach.Columns["ID"].Visible = false;
                dgv_qltiennuoc.Columns["TT"].Width = 50;
                dgv_qltiennuoc.Columns["SHD"].Width = 100;
            }
            else
                dgv_qltiennuoc.DataSource = null;
        }

        private void dgv_qltiennuoc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow r = dgv_qltiennuoc.Rows[e.RowIndex];
            tbSoPhieu.Text = r.Cells["SHD"].Value.ToString();
            cbbSoPhong.Text = r.Cells["Số phòng"].Value.ToString();
            tbTienNuoc.Text = r.Cells["Tiền nước"].Value.ToString();
            dtNgayThu.Text = r.Cells["Ngày thu tiền"].Value.ToString();
            cbbMaSV.Text = r.Cells["Mã SV"].Value.ToString();
          //  cbbMaNV.Text = r.Cells["Mã NV"].Value.ToString();
            cbbTT.Text = r.Cells["Tình trạng"].Value.ToString();
        }
        private void ResetValue()
        {
            tbSoPhieu.Text = "";
            cbbSoPhong.Text = "";
          //  cbbMaNV.Text = "";
            cbbMaSV.Text = "";
            tbTienNuoc.Text = "";
            dtNgayThu.Text = "";
            cbbTT.Text = "";
        }
        private void btThem_Click(object sender, EventArgs e)
        {
            if (cbbMaSV.Text.Length == 0)
            {
                MessageBox.Show("Bạn phải nhập Mã phân loại!");
                cbbMaSV.Focus();
                return;
            }

            if (cbbSoPhong.Text.Length == 0)
            {
                MessageBox.Show("Bạn phải nhập Tên phân loại!");
                cbbSoPhong.Focus();
                return;
            }

            CTienNuoc c = new CTienNuoc();
            int dem = c.Insert(cbbSoPhong.Text, tbTienNuoc.Text, dtNgayThu.Text, cbbMaSV.Text, tbMaNV.Text,cbbTT.Text);
            if (dem == -2)
            {
                MessageBox.Show("Mã bạn nhập vào đã tồn tại, bạn phải sử dụng mã khác!");
                cbbSoPhong.Focus();
                return;
            }
            else
            {
                ResetValue();
                cbbSoPhong.Focus();
                DocDS(c.SelectListByNoiDung(""));
            }
        }

        private void btSua_Click(object sender, EventArgs e)
        {
            if (cbbMaSV.Text.Length == 0)
            {
                MessageBox.Show("Bạn phải nhập Mã phân loại!");
                cbbMaSV.Focus();
                return;
            }

            if (cbbSoPhong.Text.Length == 0)
            {
                MessageBox.Show("Bạn phải nhập Tên phân loại!");
                cbbSoPhong.Focus();
                return;
            }
            DataGridViewRow r = dgv_qltiennuoc.SelectedRows[0];
            CTienNuoc c = new CTienNuoc();
            int dem = c.Update(r.Cells["SHD"].Value.ToString(), cbbSoPhong.Text,  tbTienNuoc.Text, dtNgayThu.Text, cbbMaSV.Text, tbMaNV.Text, cbbTT.Text);
            if (dem == -2)
            {
                MessageBox.Show("Mã bạn yêu cầu cập nhật không tồn tại!");
                cbbSoPhong.Focus();
                return;
            }
            else
            {
                ResetValue();
                cbbSoPhong.Focus();
                DocDS(c.SelectListByNoiDung(""));
            }
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            if (cbbMaSV.Text.Length == 0)
            {
                MessageBox.Show("Bạn phải nhập Mã phân loại!");
                cbbMaSV.Focus();
                return;
            }

            if (cbbSoPhong.Text.Length == 0)
            {
                MessageBox.Show("Bạn phải nhập Tên phân loại!");
                cbbSoPhong.Focus();
                return;
            }
            DataGridViewRow r = dgv_qltiennuoc.SelectedRows[0];
            CTienNuoc c = new CTienNuoc();
            int dem = c.DeleteByMa(r.Cells["SHD"].Value.ToString());
            if (dem == -2)
            {
                MessageBox.Show("Mã bạn yêu cầu Xóa không tồn tại!");
                cbbSoPhong.Focus();
                return;
            }
            else
            {
                ResetValue();
                cbbSoPhong.Focus();
                DocDS(c.SelectListByNoiDung(""));
            }
        }

        private void btTimKiem_Click(object sender, EventArgs e)
        {
            CTienNuoc c = new CTienNuoc();
            if (tbTimKiem.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập nội dung tìm kiếm");
                tbTimKiem.Focus();
            }
            else
            {
                dgv_qltiennuoc.DataSource = null;
                DocDS(c.SearchXuPhat(tbTimKiem.Text));
                if (dgv_qltiennuoc.DataSource == null)
                {
                    MessageBox.Show("Ko tìm thấy dữ liệu phù hợp");
                    DocDS(c.SelectListByNoiDung(""));
                }
            }
        }
        private string ChuyenSo(string number)
        {
            string[] dv = { "", "Mươi", "Trăm", "Nghìn", "Triệu", "Tỉ" };
            string[] cs = { "Không", "Một", "Hai", "Ba", "Bốn", "Năm", "Sáu", "Bảy", "Tám", "Chín" };
            string doc;
            int i, j, k, n, len, found, ddv, rd;

            len = number.Length;
            number += "ss";
            doc = "";
            found = 0;
            ddv = 0;
            rd = 0;

            i = 0;
            while (i < len)
            {
                //So chu so o hang dang duyet
                n = (len - i + 2) % 3 + 1;

                //Kiem tra so 0
                found = 0;
                for (j = 0; j < n; j++)
                {
                    if (number[i + j] != '0')
                    {
                        found = 1;
                        break;
                    }
                }

                //Duyet n chu so
                if (found == 1)
                {
                    rd = 1;
                    for (j = 0; j < n; j++)
                    {
                        ddv = 1;
                        switch (number[i + j])
                        {
                            case '0':
                                if (n - j == 3) doc += cs[0] + " ";
                                if (n - j == 2)
                                {
                                    if (number[i + j + 1] != '0') doc += "lẻ ";
                                    ddv = 0;
                                }
                                break;
                            case '1':
                                if (n - j == 3) doc += cs[1] + " ";
                                if (n - j == 2)
                                {
                                    doc += "mười ";
                                    ddv = 0;
                                }
                                if (n - j == 1)
                                {
                                    if (i + j == 0) k = 0;
                                    else k = i + j - 1;

                                    if (number[k] != '1' && number[k] != '0')
                                        doc += "mốt ";
                                    else
                                        doc += cs[1] + " ";
                                }
                                break;
                            case '5':
                                if (i + j == len - 1)
                                    doc += "lăm ";
                                else
                                    doc += cs[5] + " ";
                                break;
                            default:
                                doc += cs[(int)number[i + j] - 48] + " ";
                                break;
                        }

                        //Doc don vi nho
                        if (ddv == 1)
                        {
                            doc += dv[n - j - 1] + " ";
                        }
                    }
                }

                //đọc đơn vị lớn trước
                if (len - i - n > 0)
                {
                    if ((len - i - n) % 9 == 0)
                    {
                        if (rd == 1)
                            for (k = 0; k < (len - i - n) / 9; k++)
                                doc += "tỉ ";
                        rd = 0;
                    }
                    else
                        if (found != 0) doc += dv[((len - i - n + 1) % 9) / 3 + 2] + " ";
                }

                i += n;
            }

            if (len == 1)
                if (number[0] == '0' || number[0] == '5') return cs[(int)number[0] - 48];

            return doc + "đồng";
        }
        SqlConnection con;
        private void btXuat_Click(object sender, EventArgs e)
        {
            if (tbSoPhieu.Text == "")
            {
                MessageBox.Show("Bạn phải chọn mã hoá đơn trước khi in!", "Thông tin", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tbSoPhieu.Focus();
            }
            else if ((MessageBox.Show("Xác nhận in hoá đơn trả phòng?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes))
            {

                Microsoft.Office.Interop.Excel.Application exApp = new Microsoft.Office.Interop.Excel.Application();
                Microsoft.Office.Interop.Excel.Workbook exBook;
                Microsoft.Office.Interop.Excel.Worksheet exSheet;
                Microsoft.Office.Interop.Excel.Range exRange;
                string sql;
                int hang = 0, cot = 0;
                exBook = exApp.Workbooks.Add(Microsoft.Office.Interop.Excel.XlWBATemplate.xlWBATWorksheet);
                exSheet = exBook.Worksheets[1];

                //Dinh dang chung
                exRange = exSheet.Cells[1, 1];
                exRange.Range["A1:z300"].Font.Name = "Times new roman"; // font chu
                exRange.Range["C1:F1"].Font.Size = 10; //size chu
                exRange.Range["C1:F1"].Font.Bold = true;
                exRange.Range["C1:F1"].Font.ColorIndex = 5;
                //    exRange.Range["A1:A1"].ColumnWidth = 7;
                //   exRange.Range["B1:B1"].ColumnWidth = 15;
                exRange.Range["C1:F1"].MergeCells = true;
                exRange.Range["C1:F1"].HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
                exRange.Range["C1:F1"].Value = "KÝ TÚC XÁ TRƯỜNG ABC";

                exRange.Range["A3:B3"].MergeCells = true;
                exRange.Range["A3:B3"].HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
                exRange.Range["A3:B3"].Value = "Chương Mỹ - Hà Nội";

                exRange.Range["A4:B4"].MergeCells = true;
                exRange.Range["A4:B4"].HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
                exRange.Range["A4:B4"].Value = "Điện thoại:(01)23456789";

                exRange.Range["C2:F2"].Font.Size = 16;
                exRange.Range["C2:F2"].Font.Bold = true;
                exRange.Range["C2:F2"].Font.ColorIndex = 3; //Màu đỏ
                exRange.Range["C2:F2"].MergeCells = true;
                exRange.Range["C2:F2"].HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
                exRange.Range["C2:F2"].Value = "HÓA ĐƠN TIỀN PHÒNG";
                con = new SqlConnection(@"Data Source=DESKTOP-DOS5U6T\SQLEXPRESS;Initial Catalog=BCK_LTCSDL;Integrated Security=True;");
                // Biểu diễn thông tin chung của hóa đơn bán
                sql = "select tb_HDTienNuoc.SHD, tb_SinhVien.MaSV, tb_SinhVien.TenSV, tb_SinhVien.DiaChi, tb_SinhVien.SDT, tb_HDTienNuoc.NgayThuTien, tb_NhanVien.TenNV from tb_SinhVien, tb_HDTienNuoc, tb_NhanVien " +
                    " where tb_HDTienNuoc.MaSV = tb_SinhVien.MaSV and tb_HDTienNuoc.MaNV = tb_NhanVien.MaNV and tb_HDTienNuoc.SHD =N'" + tbSoPhieu.Text + "'";
                SqlCommand cmd = new SqlCommand(sql, con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable tblThongTinHD = new DataTable();
                da.Fill(tblThongTinHD);
                if (tblThongTinHD.Rows.Count > 0)
                {
                    exRange.Range["A6:G9"].Font.Size = 12;
                    exRange.Range["A6:G9"].ColumnWidth = 15;
                    exRange.Range["A6:A6"].Value = "Số phiếu: ";
                    exRange.Range["B6:C6"].MergeCells = true;
                    exRange.Range["B6:C6"].Value = tblThongTinHD.Rows[0][0].ToString();

                    exRange.Range["A7:A7"].Value = "Mã sinh viên: ";
                    exRange.Range["B7:C7"].MergeCells = true;
                    exRange.Range["B7:C7"].Value = tblThongTinHD.Rows[0][1].ToString();

                    exRange.Range["A8:A8"].Value = "Tên sinh viên: ";
                    exRange.Range["B8:C8"].MergeCells = true;
                    exRange.Range["B8:C8"].Value = tblThongTinHD.Rows[0][2].ToString();

                    //Thông tin khách hàng
                    exRange.Range["E6:E6"].Value = "Địa chỉ";
                    exRange.Range["F6:G6"].MergeCells = true;
                    exRange.Range["F6:G6"].Value = tblThongTinHD.Rows[0][3].ToString();
                    exRange.Range["F6:G6"].HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignRight;

                    exRange.Range["E7:E7"].Value = "SĐT: ";
                    exRange.Range["F7:G7"].MergeCells = true;
                    exRange.Range["F7:G7"].HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignRight;
                    exRange.Range["F7:G7"].Value = tblThongTinHD.Rows[0][4].ToString();

                    exRange.Range["E8:E8"].Value = "Từ ngày: ";
                    exRange.Range["F8:G8"].MergeCells = true;
                    exRange.Range["F8:G8"].HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignRight;
                    exRange.Range["F8:G8"].Value = tblThongTinHD.Rows[0][5].ToString();

                    exRange.Range["F15:G15"].Value = "Nhân viên thu tiền";
                    exRange.Range["F15:G15"].MergeCells = true;
                    exRange.Range["F15:G15"].HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;

                    exRange.Range["F16:G16"].MergeCells = true;
                    exRange.Range["F17:G17"].MergeCells = true;
                    exRange.Range["F17:G17"].HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
                    exRange.Range["F17:F17"].Value = tblThongTinHD.Rows[0][6].ToString();
                }

                else
                {
                    MessageBox.Show("Lỗi!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    tbSoPhieu.Focus();
                }

                sql = "SELECT SHD, SoPhong, TienNuoc, MaNV FROM tb_HDTienNuoc" +
                    " where SHD =N'" + tbSoPhieu.Text + "'";
                SqlCommand cmd1 = new SqlCommand(sql, con);
                SqlDataAdapter da1 = new SqlDataAdapter(cmd1);
                DataTable tblThongTinDV = new DataTable();
                da1.Fill(tblThongTinDV);
                //tao dong tieu de bang
                if (tblThongTinDV.Rows.Count > 0)
                {
                    exRange.Range["A11:J11"].Font.Bold = true;
                    exRange.Range["A11:J11"].HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
                    exRange.Range["B11:J11"].ColumnWidth = 12;
                    exRange.Range["A11:A11"].Value = "STT";
                    exRange.Range["B11:B11"].Value = "SHĐ";
                    exRange.Range["C11:C11"].Value = "Số phòng";
                    exRange.Range["D11:D11"].Value = "Tiền nước";
                    exRange.Range["E11:E11"].Value = "Mã NV";

                    for (hang = 0; hang < tblThongTinDV.Rows.Count; hang++)
                    {
                        //Điền số thứ tự vào cột 1 từ dòng 12
                        exSheet.Cells[1][hang + 12] = hang + 1;
                        for (cot = 0; cot < tblThongTinDV.Columns.Count; cot++)
                        {
                            //Điền thông tin hàng từ cột thứ 2, dòng 12
                            exSheet.Cells[cot + 2][hang + 12] = tblThongTinDV.Rows[hang][cot].ToString();
                        }
                    }
                    exRange.Range["D13:G13"].MergeCells = true;
                    exRange.Range["D13:G13"].Value = "Bằng chữ: " + ChuyenSo(tblThongTinDV.Rows[0][2].ToString());
                    exApp.Visible = true;
                }
            }
        }

        private void btDong_Click(object sender, EventArgs e)
        {
            if (lbVT.Text == "Quản lý")
            {
                GQuanLy add = new GQuanLy(lbMa.Text);
                add.Show();
                this.Hide();
            }
            else if (lbVT.Text == "Nhân viên")
            {
                GNhanVienKTX add = new GNhanVienKTX(lbMa.Text);
                add.Show();
                this.Hide();
            }
        }

        private void tbTienNuoc_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        
    }
}
