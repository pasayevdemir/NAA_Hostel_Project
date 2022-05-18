using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Runtime.InteropServices;

namespace NaaHostel
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();

        }
        SqlConnection elaqe = new SqlConnection(@"Data Source=DESKTOP-5KG7HFR\SQLEXPRESS;Initial Catalog=Hostel;Integrated Security=True");
        private string ad;
        private int i=0;
        private void button1_Click(object sender, EventArgs e)
        {
                if (dataGridView1.RowCount >i)
                label1.Text = dataGridView1.Rows[i].Cells[1].Value.ToString();
                
                i++;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            txtBoxUnvan.Enabled = true;

        }

        private void txtBoxUnvan_SelectedIndexChanged(object sender, EventArgs e)
        {
            MessageBox.Show(txtBoxUnvan.Text);
        }
    }
}
