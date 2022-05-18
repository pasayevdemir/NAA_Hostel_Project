using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NaaHostel
{
    public partial class DaxilOL : Form
    {
        bool check = false;
        public bool ac { get; set; }
        public bool daxilOL { get; set; }
        public bool qeydiyyat { get; set; }
        public DaxilOL()
        {
            InitializeComponent();
        }
        /*Sql ile elaqe*/
        SqlConnection elaqe = new SqlConnection(@"Data Source=DESKTOP-5KG7HFR\SQLEXPRESS;Initial Catalog=1449a;Integrated Security=True");
        

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            if (txtPassword.Text == "")
            {
                iconBtnGoz.Visible = false;
            }
            else if (txtPassword.Text != "")
            {
                iconBtnGoz.Visible = true;
            }
        }

        private void ıconButton1_Click(object sender, EventArgs e)
        {
            
            if (check == true)
            {
                txtPassword.PasswordChar = '*';
                iconBtnGoz.IconChar = FontAwesome.Sharp.IconChar.Eye;
                check = false;  
                txtPassword.Focus();
            }
            else if (check == false)
            {
                txtPassword.PasswordChar = default;
                iconBtnGoz.IconChar = FontAwesome.Sharp.IconChar.EyeSlash;
                check = true;
                txtPassword.Focus();
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            elaqe.Open();
            SqlCommand sorgu = new SqlCommand("Select *from Log_in Where Hesab='" + txtLogin.Text + "' and Parol='" + txtPassword.Text + "'", elaqe);
            if (sorgu.ExecuteReader().Read())
            {
                this.Close();
                ac = true;
            }
            else
            {
                lblInfo.Text = "İstifadəçi adı və ya Parol etibarsizdır";
            }
            elaqe.Close();
        }


        private void btnCixis_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
        //
        //Dll import ile panel hereketinin funksiyasini yaratmaq ucun kod
        //

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void panel4_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnMinimum_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Qeydiyyat().ShowDialog();
        }
    }
}
