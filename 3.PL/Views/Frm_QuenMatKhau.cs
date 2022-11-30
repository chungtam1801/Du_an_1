using _1.DAL.DomainClass;
using _1.DAL.Context;
using _2.BUS.IServices;
using _2.BUS.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Web;
using System.Configuration;
using System.Net;
using System.Net.Mail;
using System.Data.OleDb;

namespace _3.PL.Views
{
    public partial class Frm_QuenMatKhau : Form
    {
        Random rnd = new Random();
        public int code;
        //OnConfiguring bui = new OnConfiguring
        //    ("Data Source=LAPTOP-B9NKF2E2\\SQLEXPRESS02;Initial Catalog=FINALASS_BanQuanAo_Nhom666_FA22_PRO131;Persist Security Info=True;User ID=qlbqa;Password=123456");

        //OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=E:\ForgetPassword-master\ForgetPassword\ForgetPassword.mdb");
        public Frm_QuenMatKhau()
        {
            InitializeComponent();
        }
        private void mail()
        {

            code = rnd.Next(123123, 999999);
            const string p = "Đã gửi mật khẩu";


            MailMessage message = new MailMessage();
            SmtpClient smtp = new SmtpClient();

            message.From = new MailAddress("Đã gửi email");

            //Nhập cú đánh email của bạn và cũng thay đổi trong cơ sở dữ liệu

            message.To.Add(new MailAddress("Nhận thư điện tử"));
            message.Subject = "Đổi mật khẩu";
            message.Body = "Viết mã đã cho này vào hộp văn bản\n" + code + "\n Cảm ơn bạn!";

            smtp.Port = 587;
            smtp.Host = "smtp.gmail.com";
            smtp.EnableSsl = true;
            smtp.UseDefaultCredentials = false;
            smtp.Credentials = new NetworkCredential("Đã gửi email", p);
            smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
            smtp.Send(message);
            MessageBox.Show("Email đã được gửi");


        }

        private void btn_TiepTheo_Click_1(object sender, EventArgs e)
        {
            if (code.ToString() == txt_PassCode.Text)
            {
                grb_TiepTheo2.Visible = true;

                txt_CPass.Enabled = true;
                txt_NPass.Enabled = true;
                btn_CNMK.Enabled = true;
                btn_GuiLai.Enabled = true;
                btn_TiepTheo.Enabled = true;
            }

            else
            {
                MessageBox.Show("Mã không khớp");
            }
        }

        private void btn_GuiLai_Click_1(object sender, EventArgs e)
        {
            mail();
        }

        //private void btn_CNMK_Click_1(object sender, EventArgs e)
        //{
        //    if (txt_NPass.Text == txt_CPass.Text)
        //    {
        //        string query = "Cập nhật bộ thông tin chủ sở hữu [mật khẩu]='" + txt_CPass.Text + "' Ở đâu ID=1";
        //        OleDbCommand cmd = new OleDbCommand(query, con);

        //        con.Open();
        //        cmd.ExecuteNonQuery();
        //        con.Close();


        //        MessageBox.Show("Thay đổi mật khẩu thành công");
        //        this.Dispose();
        //    }
        //    else
        //    {
        //        MessageBox.Show("Mật khẩu không phù hợp");
        //    }
        //}

        //private void btn_GuiThu_Click(object sender, EventArgs e)
        //{
        //    string query = "Chọn Email ";
        //    OleDbCommand cmd = new OleDbCommand(query, con);

        //    DataTable dt = new DataTable();
        //    con.Open();
        //    OleDbDataAdapter da = new OleDbDataAdapter(cmd);
        //    da.Fill(dt);
        //    con.Close();
        //    string txtboxEmail = txt_Email.Text;
        //    foreach (DataRow dr in dt.Rows)
        //    {
        //        foreach (DataColumn dc in dt.Columns)
        //        {
        //            if (txtboxEmail == dr[dc].ToString())
        //            {
        //                grb_TiepTheo1.Visible = true;
        //                txt_PassCode.Enabled = true;
        //                btn_TiepTheo.Enabled = true;
        //                btn_GuiLai.Enabled = true;
        //                btn_GuiThu.Enabled = true;



        //                mail();
        //            }
        //            else
        //            {
        //                MessageBox.Show("Email này không tồn tại trong dữ liệu đã cho");

        //            }


        //        }
        //    }
        //}
    }
}
