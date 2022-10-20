using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.IO;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace BCK_LTCSDL.GUI
{
    public partial class GQuenMK : Form
    {
        public GQuenMK()
        {
            InitializeComponent();
        }
        string randomCode;
        public static string to;
        public class tendn
        {
            public static string tdn;
        }
        private void btn_gui_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-DOS5U6T\SQLEXPRESS;Initial Catalog=BCK_LTCSDL;Integrated Security=True;");
            try
            {
                conn.Open();
                string tdn = tbTK.Text;
                string email = tbEmail.Text;
                string sql = " select * from tb_Login where TK= '" + tdn + "' and EMAIL= '" + email + "'";
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataReader dtr = cmd.ExecuteReader();
                string UserEmail = tbEmail.Text;
                if (IsValidEmailId(UserEmail) == true)
                {
                    if (dtr.Read() == true)
                    {
                        tendn.tdn = tbTK.Text;
                        string from, pass, messageBody;
                        Random rand = new Random();
                        randomCode = (rand.Next(999999)).ToString();
                        MailMessage message = new MailMessage();
                        to = (tbEmail.Text).ToString();
                        from = "bienle160720@gmail.com";
                        pass = "namhai20";
                        messageBody = "Your reset code is " + randomCode;
                        message.To.Add(to);
                        message.From = new MailAddress(from);
                        message.Body = messageBody;
                        message.Subject = "Password reseting code";
                        SmtpClient smtp = new SmtpClient("smtp.gmail.com");
                        smtp.EnableSsl = true;
                        smtp.Port = 587;
                        smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
                        smtp.Credentials = new NetworkCredential(from, pass);
                        try
                        {
                            smtp.Send(message);
                            MessageBox.Show("Gửi thành công: " + randomCode);
                        }
                        catch (Exception)
                        {
                            MessageBox.Show("Sai tài khoản!");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Sai tài khoản hoặc sai email!");
                    }

                }
                else
                {
                    MessageBox.Show("Định dạng email ko đúng!");
                    tbEmail.Focus();
                }
            }
            catch
            {
                MessageBox.Show("Không phải email đăng ký tài khoản!");
            }
        }

        private void bt_xacnhan_Click(object sender, EventArgs e)
        {
            if (randomCode == (tbMaCode.Text).ToString())
            {
                to = tbEmail.Text;
                GDoiMKQuen qmk = new GDoiMKQuen(tbTK.Text);
                this.Hide();
                qmk.Show();
            }
            else
            {
                MessageBox.Show("Nhập sai mã!");
            }
        }
        public static bool IsValidEmailId(string InputEmail)
        {
            //Regex regex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
            InputEmail = InputEmail ?? string.Empty;
            string strRegex = @"^([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}" +
                  @"\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([a-zA-Z0-9\-]+\" +
                  @".)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$";
            Regex re = new Regex(strRegex);
            if (re.IsMatch(InputEmail))
                return (true);
            else
                return (false);
        }
    }
}
