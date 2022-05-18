using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NaaHostel
{
    public partial class OYP : Form
    {
        
        public OYP()
        {
            InitializeComponent();
        }
        private string masa = "";
        private Button yeni;
        bool yoxla = false;
        private void masa_Click(object sender, EventArgs e)
        {
            Button btn = (Button) sender;
            yeni = btn;
            yoxla = true;
        }

        private void btnRezer_Click(object sender, EventArgs e)
        {
            if (yoxla==true && txtBoxAd.Text !="" && txtBoxTf.Text!= "(+994)   -   -  -")
            {
                masa = yeni.Text +", "+ txtBoxAd.Text + ", " + txtBoxTf.Text;
                listBox1.Items.Add(masa);
                yeni.Enabled = false;
                yeni.BackColor = Color.Green;
                txtBoxAd.Clear();
                txtBoxTf.Clear();
                txtBoxTf.Text = "(+994)   -   -  -";
                yoxla = false;
            }
            else
            {
                MessageBox.Show("Sahələr daxil olmayıb və ya Masa seçilməyib!!!");
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex >=0) 
            { 
                string m = listBox1.Items[listBox1.SelectedIndex].ToString();
                m = m[4].ToString();
                m = "button" + m;
                Button but = this.Controls.Find(m, true).FirstOrDefault() as Button;
                but.Enabled = true;
                but.BackColor = Color.White;
                listBox1.Items.Remove(listBox1.SelectedItem);
            }
        }
    }
}
