using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NaaHostel
{
    public partial class AnaForm : Form
    {

        public AnaForm()
        {
            InitializeComponent();
        }
        private Form childForm;
        public static Courpus3 courpus3 = new Courpus3();
//
//Dll import ile panel hereketinin funksiyasini yaratmaq ucun kod
//

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

//
//Form icinde forum acmaq funksiyasi
//
        private void OpenChildForm(Form kicikForm)
        {
            if (childForm != null)
            {
                childForm.Close();
            }
            childForm = kicikForm;
            kicikForm.TopLevel = false;
            kicikForm.FormBorderStyle = FormBorderStyle.None;
            kicikForm.Dock = DockStyle.Fill;
            panelDesktop.Controls.Add(kicikForm);
            panelDesktop.Tag = kicikForm;
            kicikForm.BringToFront();
            kicikForm.Show();
        }
//
//Button cixis
//
        public void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void btnClose_MouseHover(object sender, EventArgs e)
        {
            btnClose.IconColor = Color.White;
            btnClose.BackColor = Color.Red;
        }
        private void btnClose_MouseLeave(object sender, EventArgs e)
        {
            btnClose.IconColor = Color.Red;
            btnClose.BackColor = Color.FromArgb(0, 159, 253);
        }
//
//Button Normal
//
        private void btnNormal_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {
                WindowState = FormWindowState.Maximized;
                btnNormal.IconChar = FontAwesome.Sharp.IconChar.WindowRestore;
            }
            else
            {
                WindowState = FormWindowState.Normal;
                btnNormal.IconChar = FontAwesome.Sharp.IconChar.Square;
            }
        }

//
//Button Gizle
//
        private void btnMinimum_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
//
//Kontrol panelinin hereketetme kodu
//
        private void panelControl_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
//
//Ana Sehifeye kecid
//
        private void homeStripItem_Click(object sender, EventArgs e)
        {
            if (childForm != null)
                childForm.Close();

            this.Size = new Size(800, 600);
        }
//
//1-cu korpusa sehifesini kecid
//
        private void coupus1StripItem_Click(object sender, EventArgs e)
        {
            this.Size = new Size(880, Height);
            OpenChildForm(new Courpus1());
        }
//
//2-cu korpusa sehifesini kecid
//
        private void coupus2StripItem_Click(object sender, EventArgs e)
        {
            this.Size = new Size(880, Height);
            OpenChildForm(new Courpus2());
        }
//
//3-cu korpusa sehifesini kecid
//
        private void coupus3StripItem_Click(object sender, EventArgs e)
        {
            this.Size = new Size(courpus3.Width,Height);
            OpenChildForm(new Courpus3());
        }
//
//4-cu korpusa sehifesini kecid
//
        private void coupus4StripItem_Click(object sender, EventArgs e)
        {
            this.Size = new Size(880, Height);
            OpenChildForm(new Courpus4());
        }

        private void studentStripItem_Click(object sender, EventArgs e)
        {
            this.Size = new Size(new Form1().Width, 60+ new Form1().Height);
            OpenChildForm(new Form1());
        }
    }
}
