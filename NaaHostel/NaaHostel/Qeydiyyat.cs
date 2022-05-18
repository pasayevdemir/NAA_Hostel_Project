using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;
using System.Net;

namespace NaaHostel
{
    public partial class Qeydiyyat : Form
    {
        public Qeydiyyat()
        {
            InitializeComponent();
        }
        bool istifa = false;
        bool herseytam = true;
        bool mail = false;
        bool yox = false;
        static Random random = new Random();
        int code = random.Next(1000, 9999);
        /* Sql Server ile elaqe yaratmaq */
        SqlConnection elqe = new SqlConnection(@"Data Source=DESKTOP-5KG7HFR\SQLEXPRESS;Initial Catalog=1449a;Integrated Security=True");
       
        /* Hesab yarat buttonun funksiyaları */
        /// <summary>
        /// mail kod gonderme
        ///
        /// </summary>
        //private void SendMail()
        //{
        //    SmtpClient client = new SmtpClient("smtp.live.com", 587);
        //    MailMessage mss = new MailMessage(txtEmail.Text, "n1449a@mail.ru", "informasiya+", "NAA Hostel doğrulama kodunuz: " + code);
        //    client.EnableSsl = true;
        //    client.Credentials = new NetworkCredential();
        //    mss.Subject = "NAA Hostel Qeydiyyat";
        //    client.Send(mss);
        //}
        private void SendMail()
        {
            try
            {
                code = random.Next(10000, 99999);
                MailMessage sms = new MailMessage("krekhesab@gmail.com", txtEmail.Text, "Təsdiqedici kod", "Kod:" + code);
                SmtpClient smtpClient = new SmtpClient("smtp.gmail.com", 587);
                smtpClient.EnableSsl = true;
                smtpClient.Credentials = new NetworkCredential("krekhesab@gmail.com", "@Qwerty123");
                smtpClient.Send(sms);
                MessageBox.Show("Təsdiq kodu göndərildi", "Məlumat", MessageBoxButtons.OK);
            }
            catch (Exception)
            {
                MessageBox.Show("Nə isə xəta baş verdi!!", "Xəta");
            }

        }
        private void btnQeydiyyat_Click(object sender, System.EventArgs e)
        {
            string str = txtEmail.Text.ToString();
            for (int i = 0; i < txtEmail.Text.Length; i++)
            {
                if (str[i] == '@')
                {
                    mail = true;
                }
            }
            if (txtAd.Text == "" || txtSoyad.Text == "" || txtEmail.Text == "" || txtParol.Text == "" || txtTkrParol.Text == "")
            {
                lblInfo.Text = "Bütün boş yerləri doldurmağınızdan əmin olun!";
            }
            else if (txtAd.Text != "" || txtSoyad.Text != "" || txtEmail.Text != "" || txtParol.Text != "" || txtTkrParol.Text != "")
            {
                lblInfo.Text = "";
                if (istifa == true)
                    txtEmail.Focus();
                if (txtParol.Text != txtTkrParol.Text)
                    label9.Text = "Təkrar Parol sehvdir!";
                if (txtParol.Text.Length < 8)
                    label8.Text = "Parol 8 simvoldan çox olmalıdır!";
                if (mail == false)
                    label7.Text = "Elektron ünvan olamlıdır";
                else if (herseytam == true && mail == true)
                {
                    panel5.Visible = true;
                    SendMail();
                }
            }

        }

        /* E-pocta textBoxsunun funksiyaları */
        private void txtEmail_TextChanged(object sender, System.EventArgs e)
        {
            if (mail == true)
                label7.Text = "";
            string mayl = txtEmail.Text;
            SqlCommand sorgu = new SqlCommand("Select *from Registration Where Registration.Hesab='" + mayl + "'", elqe);
            elqe.Open();
            if (sorgu.ExecuteReader().Read())
            {
                istifa = true;
                herseytam = false;
                label7.Text = "Bu e-mail artıq istifadə olub.";
                label7.ForeColor = Color.Red;
            }
            else
            {
                herseytam = true;
                istifa = false;
                label7.Text = "";
            }
            elqe.Close();
        }


        /* Parol ve Parol təkrarla textBoxsunun funksiyaları */
        private void txtParol_TextChanged(object sender, System.EventArgs e)
        {


            if (txtParol.Text.Length >= 8)
                label8.Text = "";
            if (txtParol.Text == txtTkrParol.Text)
                label9.Text = "";
        }

        private void txtTkrParol_TextChanged(object sender, System.EventArgs e)
        {
            if (txtParol.Text == txtTkrParol.Text)
                label9.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            new DaxilOL().Show();
            yox = true;
        }

        private void Qeydiyyat_FormClosed(object sender, FormClosedEventArgs e)
        {
            if(yox==false)
            Application.Exit();
        }

        private void btnTesdiqle_Click(object sender, EventArgs e)
        {
            if (herseytam == true && mail == true)
            {
                panel5.Visible = true;
                if (code == Convert.ToInt32(textBoxCode.Text))
                {
                    panel5.Visible = false;
                    elqe.Open();
                    SqlCommand cmd_reg = new SqlCommand("Insert Into Registration (Ad,Soyad,Hesab,Parol) Values(@a,@s,@m,@p)", elqe);
                    cmd_reg.Parameters.AddWithValue("@a", txtAd.Text);
                    cmd_reg.Parameters.AddWithValue("@s", txtSoyad.Text);
                    cmd_reg.Parameters.AddWithValue("@m", txtEmail.Text);
                    cmd_reg.Parameters.AddWithValue("@p", txtParol.Text);
                    cmd_reg.ExecuteNonQuery();
                    elqe.Close();
                    elqe.Open();
                    SqlCommand cmd_log = new SqlCommand("Insert Into Log_in (Hesab,Parol) Values(@m,@p)", elqe);
                    cmd_log.Parameters.AddWithValue("@m", txtEmail.Text);
                    cmd_log.Parameters.AddWithValue("@p", txtParol.Text);
                    cmd_log.ExecuteNonQuery();
                    elqe.Close();
                    DaxilOL yeni = new DaxilOL();
                    yeni.txtLogin.Text = txtEmail.Text;
                    yeni.txtPassword.Text = txtParol.Text;
                    this.Close();
                    new DaxilOL().Show();
                    yox = true;
                }
                else
                {
                    label11.Text = "Doğrulama kodunuz yalnışdır!";
                }
            }
        }
    }
}
