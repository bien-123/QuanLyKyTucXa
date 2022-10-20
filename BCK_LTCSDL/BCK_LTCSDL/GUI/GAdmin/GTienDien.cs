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
using BCK_LTCSDL.GUI.GStaff;
using Excel = Microsoft.Office.Interop.Excel;
using System.Data.SqlClient;

namespace BCK_LTCSDL.GUI.GAdmin
{
    public partial class GTienDien : Form
    {
        public GTienDien(string txt)
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
        private void dgv_qltiendien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow r = dgv_qltiendien.Rows[e.RowIndex];
            tbSoPhieu.Text = r.Cells["SHD"].Value.ToString();
            cbbSoPhong.Text = r.Cells["Số phòng"].Value.ToString();
            tbCSCu.Text = r.Cells["CS Cũ"].Value.ToString();
            tbCSMoi.Text = r.Cells["CS Mới"].Value.ToString();
            tbDonGia.Text = r.Cells["Đơn giá"].Value.ToString();
            tbTienDien.Text = r.Cells["Thành tiền"].Value.ToString();
            dtNgayThu.Text = r.Cells["Ngày thu tiền"].Value.ToString();
            cbbMaSV.Text = r.Cells["Mã SV"].Value.ToString();
          //  tbMaNV.Text = r.Cells["Mã NV"].Value.ToString();
            cbbTT.Text = r.Cells["Tình trạng"].Value.ToString();
        }

        private void GTienDien_Load(object sender, EventArgs e)
        {
            CTienDien c = new CTienDien();
            DocDS(c.SelectListByNoiDung(""));
        }
        private void DocDS(List<MTienDien> ds)
        {
            if (ds != null && ds.Count > 0)
            {
                DataTable tb = new DataTable();
                tb.Columns.Add("TT", typeof(int));
                tb.Columns.Add("SHD", typeof(String));
                tb.Columns.Add("Số phòng", typeof(String));
                tb.Columns.Add("CS Cũ", typeof(String));
                tb.Columns.Add("CS Mới", typeof(String));
                tb.Columns.Add("Đơn giá", typeof(String));
                tb.Columns.Add("Thành tiền", typeof(String));
                tb.Columns.Add("Ngày thu tiền", typeof(String));
                tb.Columns.Add("Mã SV", typeof(String));
                tb.Columns.Add("Mã NV", typeof(String));
                tb.Columns.Add("Tình trạng", typeof(String));
                int tt = 0;
                foreach (MTienDien m in ds)
                {
                    tt++;
                    DataRow r = tb.NewRow();
                    r["TT"] = tt;
                    r["SHD"] = m.shd;
                    r["Số phòng"] = m.sophong;
                    r["CS Cũ"] = m.cscu;
                    r["CS Mới"] = m.csmoi;
                    r["Đơn giá"] = m.dongia;
                    r["Thành tiền"] = m.thanhtien;
                    r["Ngày thu tiền"] = m.ngaythutien;
                    r["Mã SV"] = m.masv;
                    r["Mã NV"] = m.manv;
                    r["Tình trạng"] = m.tinhtrang;
                    tb.Rows.Add(r);
                }
                dgv_qltiendien.DataSource = tb;
                //dgvDanhSach.Columns["ID"].Visible = false;
                dgv_qltiendien.Columns["TT"].Width = 50;
                dgv_qltiendien.Columns["SHD"].Width = 100;
            }
            else
                dgv_qltiendien.DataSource = null;
        }
        private void ResetValue()
        {
            tbSoPhieu.Text = "";
            cbbSoPhong.Text = "";
            tbCSCu.Text = "";
            tbCSMoi.Text = "";
            tbDonGia.Text = "";
         //   tbMaNV.Text = "";
            cbbMaSV.Text = "";
            tbTienDien.Text = "";
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

            CTienDien c = new CTienDien();
            int dem = c.Insert(cbbSoPhong.Text, tbCSCu.Text, tbCSMoi.Text, tbDonGia.Text, dtNgayThu.Text, cbbMaSV.Text,tbMaNV.Text, cbbTT.Text);
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
            DataGridViewRow r = dgv_qltiendien.SelectedRows[0];
            CTienDien c = new CTienDien();
            int dem = c.Update(r.Cells["SHD"].Value.ToString(), cbbSoPhong.Text, tbCSCu.Text, tbCSMoi.Text, tbDonGia.Text, dtNgayThu.Text, cbbMaSV.Text, tbMaNV.Text, cbbTT.Text);
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
            DataGridViewRow r = dgv_qltiendien.SelectedRows[0];
            CTienDien c = new CTienDien();
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
            CTienDien c = new CTienDien();
            if (tbTimKiem.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập nội dung tìm kiếm");
                tbTimKiem.Focus();
            }
            else
            {
                dgv_qltiendien.DataSource = null;
                DocDS(c.SearchXuPhat(tbTimKiem.Text));
                if (dgv_qltiendien.DataSource == null)
                {
                    MessageBox.Show("Ko tìm thấy dữ liệu phù hợp");
                    DocDS(c.SelectListByNoiDung(""));
                }
            }
        }
        SqlConnection con ;
        private void btXuatHD_Click(object sender, EventArgs e)
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
                exRange.Range["A1:B1"].Font.Size = 10; //size chu
                exRange.Range["A1:B1"].Font.Bold = true;
                exRange.Range["A1:B1"].Font.ColorIndex = 5;
                exRange.Range["A1:A1"].ColumnWidth = 7;
                exRange.Range["B1:B1"].ColumnWidth = 15;
                exRange.Range["A1:B1"].MergeCells = true;
                exRange.Range["A1:B1"].HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
                exRange.Range["A1:B1"].Value = "KÝ TÚC XÁ TRƯỜNG ABC";

                exRange.Range["A2:B2"].MergeCells = true;
                exRange.Range["A2:B2"].HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
                exRange.Range["A2:B2"].Value = "Chương Mỹ - Hà Nội";

                exRange.Range["A3:B3"].MergeCells = true;
                exRange.Range["A3:B3"].HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
                exRange.Range["A3:B3"].Value = "Điện thoại:(01)23456789";

                exRange.Range["D2:G2"].Font.Size = 16;
                exRange.Range["D2:G2"].Font.Bold = true;
                exRange.Range["D2:G2"].Font.ColorIndex = 3; //Màu đỏ
                exRange.Range["D2:G2"].MergeCells = true;
                exRange.Range["D2:G2"].HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
                exRange.Range["D2:G2"].Value = "HÓA ĐƠN TIỀN ĐIỆN";
                con = new SqlConnection(@"Data Source=DESKTOP-DOS5U6T\SQLEXPRESS;Initial Catalog=BCK_LTCSDL;Integrated Security=True;");
                // Biểu diễn thông tin chung của hóa đơn bán
                sql = "select tb_HDTienDien.SHD, tb_HDTienDien.SoPhong, tb_SinhVien.MaSV, tb_SinhVien.TenSV, tb_SinhVien.DiaChi, tb_SinhVien.SDT from tb_SinhVien, tb_HDTienDien" +
                    " where tb_SinhVien.MaSV = tb_HDTienDien.MaSV and tb_HDTienDien.SHD =N'" + tbSoPhieu.Text + "'";
                SqlCommand cmd = new SqlCommand(sql, con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable tblThongTinHD = new DataTable();
                da.Fill(tblThongTinHD);
                if (tblThongTinHD.Rows.Count > 0)
                {
                    exRange.Range["B6:C9"].Font.Size = 12;
                    exRange.Range["B6:B6"].Value = "Số phiếu: ";
                    exRange.Range["C6:D6"].MergeCells = true;
                    exRange.Range["C6:D6"].Value = tblThongTinHD.Rows[0][0].ToString();

                    exRange.Range["B7:B7"].Value = "Số phòng: ";
                    exRange.Range["C7:D7"].MergeCells = true;
                    exRange.Range["C7:D7"].Value = tblThongTinHD.Rows[0][1].ToString();

                    exRange.Range["B7:B7"].Value = "Mã sinh viên: ";
                    exRange.Range["C7:D7"].MergeCells = true;
                    exRange.Range["C7:D7"].Value = tblThongTinHD.Rows[0][2].ToString();

                    exRange.Range["B8:B8"].Value = "Tên sinh viên: ";
                    exRange.Range["C8:D8"].MergeCells = true;
                    exRange.Range["C8:D8"].HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignRight;
                    exRange.Range["C8:D8"].Value = tblThongTinHD.Rows[0][3].ToString();

                    //Thông tin khách hàng
                    exRange.Range["F6:F6"].Value = "Địa chỉ";
                    exRange.Range["G6:H6"].MergeCells = true;
                    exRange.Range["G6:H6"].Value = tblThongTinHD.Rows[0][4].ToString();

                    exRange.Range["F7:F7"].Value = "SĐT: ";
                    exRange.Range["G7:H7"].MergeCells = true;
                    exRange.Range["G7:H7"].HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignRight;
                    exRange.Range["G7:H7"].Value = tblThongTinHD.Rows[0][5].ToString();

                   /* exRange.Range["F8:F8"].Value = "Địa chỉ: ";
                    exRange.Range["G8:H8"].MergeCells = true;
                    exRange.Range["G8:H8"].HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignRight;
                    exRange.Range["G8:H8"].Value = tblThongTinHD.Rows[0][6].ToString();

                    exRange.Range["F9:F9"].Value = "Điện thoại: ";
                    exRange.Range["G9:H9"].MergeCells = true;
                    exRange.Range["G9:H9"].HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignRight;
                    exRange.Range["G9:H9"].Value = "(+84)" + tblThongTinHD.Rows[0][7].ToString();*/
                }

                else
                {
                    MessageBox.Show("Lỗi!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    tbSoPhieu.Focus();
                }

                sql = "select SHD,SoPhong,CSCu,CSMoi,DonGia,(CSMoi - CSCu) * DonGia  as 'ThanhTien',NgayThuTien,MaSV,MaNV from tb_HDTienDien" +
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
                    exRange.Range["D11:D11"].Value = "Chỉ số cũ";
                    exRange.Range["E11:E11"].Value = "Chỉ số mới";
                    exRange.Range["F11:F11"].Value = "Đơn giá";
                    exRange.Range["G11:G11"].Value = "Thành tiền";
                    exRange.Range["H11:H11"].Value = "Ngày thu tiền";
                    exRange.Range["I11:I11"].Value = "Mã SV";
                    exRange.Range["J11:J11"].Value = "Mã NV";
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
                 /*   exRange = exSheet.Cells[cot][hang + 14];
                    exRange.Font.Bold = true;
                    exRange.Value2 = "Tổng tiền";
                    exRange = exSheet.Cells[cot + 1][hang + 14];
                    exRange.Font.Bold = true;
                    exRange.Value2 = tblThongTinHD.Rows[0][9].ToString() + "VNĐ"; // hiển thị tổng tiền
                    exRange = exSheet.Cells[1][hang + 15];*/

                    exRange.Range["A1:F1"].MergeCells = true;
                    exRange.Range["A1:F1"].Font.Bold = true;
                    exRange.Range["A1:F1"].Font.Italic = true;
                    exRange.Range["A1:F1"].HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignRight;
                   // exRange.Range["A1:F1"].Value = "Bằng chữ: " + ChuyenSo(tblThongTinHD.Rows[0][9].ToString());

                    exRange = exSheet.Cells[4][hang + 17]; //Ô A1 
                    exRange.Range["A1:C1"].MergeCells = true;
                    exRange.Range["A1:C1"].Font.Italic = true;
                    exRange.Range["A1:C1"].HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;

               /*     String d = Convert.ToDateTime(tblThongTinHD.Rows[0][2]);
                    exRange.Range["A1:C1"].Value = "Hà Nội, ngày " + d.Day + " tháng " + d.Month + " năm " + d.Year;
                    exRange.Range["A2:C2"].MergeCells = true;
                    exRange.Range["A2:C2"].Font.Italic = true;
                    exRange.Range["A2:C2"].HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
                    exRange.Range["A2:C2"].Value = "Nhân viên phục vụ";
                    exRange.Range["A4:C4"].MergeCells = true;
                    exRange.Range["A4:C4"].Font.Italic = true;
                    exRange.Range["A4:C4"].HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
                    exRange.Range["A4:C4"].Value = tblThongTinHD.Rows[0][10];
                    exSheet.Name = "Hoá đơn";*/
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

        private void tbCSCu_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void tbCSMoi_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void tbDonGia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }
    }
}
