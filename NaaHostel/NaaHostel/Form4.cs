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

namespace NaaHostel
{
    public partial class Form4 : Form
    {
        private bool clickOlub = false;
        private int a = 0;
        private int b = 0;
        public Form4()
        {
            InitializeComponent();
        }
        SqlConnection elaqe = new SqlConnection(@"Data Source=DESKTOP-5KG7HFR\SQLEXPRESS;Initial Catalog=Hostel;Integrated Security=True");

        private void Form4_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hostelDataSet.General' table. You can move, or remove it, as needed.
            this.generalTableAdapter.Fill(this.hostelDataSet.General);
            // TODO: This line of code loads data into the 'hostelDataSet.Courpus' table. You can move, or remove it, as needed.
            this.courpusTableAdapter.Fill(this.hostelDataSet.Courpus);
            //elaqe.Open();
            //SqlCommand cmd = new SqlCommand("Select *from General Where RoomNumber=@room", elaqe);
            //cmd.Parameters.AddWithValue(@"room", txtBoxOtaq.Text);
            //cmd.ExecuteNonQuery();
            //dataGridView2.DataSource = cmd;
            //MessageBox.Show(dataGridView1.CurrentRow.Cells[0].Value.ToString());
            //elaqe.Close();
            txtBoxOtaq.Focus();
        }

        //
        //textBox-lara bazanı köcurən funksiyasi
        //
        private void CellsEnter()
        {
            txtBoxOtaq.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txtBoxAd.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txtBoxQrp.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            txtBoxUnvan.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            txtBoxTf.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            txtBoxDiger.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
        }
        //
        //textBox-ları təmizləyən funksiyasi
        //
        private void ClearBox()
        {
            txtBoxAd.Clear();
            txtBoxOtaq.Clear();
            txtBoxQrp.Clear();
            txtBoxTf.Clear();
            txtBoxDiger.Clear();
            txtBoxUnvan.Text = "";
        }
        //
        //textBox-ları acıb-bağlayan funksiyasi
        //
        private void TxtEnabled(bool n)
        {
            switch (n)
            {
                case true:
                    {
                        txtBoxAd.Enabled = true;
                        txtBoxOtaq.Enabled = true;
                        txtBoxQrp.Enabled = true;
                        txtBoxTf.Enabled = true;
                        txtBoxDiger.Enabled = true;
                        txtBoxUnvan.Enabled = true;
                    }
                    break;
                case false:
                    {
                        txtBoxAd.Enabled = false;
                        txtBoxOtaq.Enabled = false;
                        txtBoxQrp.Enabled = false;
                        txtBoxTf.Enabled = false;
                        txtBoxDiger.Enabled = false;
                        txtBoxUnvan.Enabled = false;
                    }
                    break;
            }
        }
        //
        //Otağın tutumunu təyin edən funksiyasi
        //
        private void  roomCapacity()
        {
            elaqe.Open();
            SqlDataAdapter dtadptr = new SqlDataAdapter("select *from General Where RoomNumber like '" + txtBoxOtaq.Text + "' ", elaqe);
            DataTable dt = new DataTable();
            dtadptr.Fill(dt);
            dataGridView3.DataSource = dt;
            a = dataGridView3.RowCount.GetHashCode();
            SqlDataAdapter dtadptdr = new SqlDataAdapter("select *from Courpus Where RoomNumber like '" + txtBoxOtaq.Text + "' ", elaqe);
            DataTable ddt = new DataTable();
            dtadptdr.Fill(ddt);
            dataGridView2.DataSource = ddt;
            if (dataGridView2.RowCount.GetHashCode() > 0)
                b = Convert.ToInt32(dataGridView2.CurrentRow.Cells[4].Value);
            elaqe.Close();
            elaqe.Close();
        }

        //
        //Datadridview bazasının CellEnter hadisəsi
        //
        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            CellsEnter();
        }


        //
        //Əlavə et buttonun hadisəsi
        //
        private void ıcnBtnAdd_Click(object sender, EventArgs e)
        {
            if(clickOlub==false)//Ilk defe kilik olubsa saheleri temizleyir ve acir
            {
                ClearBox();
                TxtEnabled(true);
            }
            if(clickOlub==true)//ikinci sefer kilik olubsa sahelerin dulu ve ya bos odldugunu yoxlayir
            {
                //bu if ise sahelerin dolu oldugu halda isleyir 
                if (txtBoxAd.Text != "" && txtBoxOtaq.Text != "" && txtBoxQrp.Text != "" && txtBoxTf.Text != "" && txtBoxDiger.Text != "" && txtBoxUnvan.Text != "")
                {
                    roomCapacity();
                    if (a < b)
                    {
                        elaqe.Open();
                        SqlCommand cmd = new SqlCommand("Insert Into General( RoomNumber,Name,Qroup,Address,Phone,Other) Values(@otaq,@name,@qrup,@adres,@mobil,@diger)", elaqe);
                        cmd.Parameters.AddWithValue(@"otaq", Convert.ToInt32(txtBoxOtaq.Text));
                        cmd.Parameters.AddWithValue(@"name", txtBoxAd.Text.ToString());
                        cmd.Parameters.AddWithValue(@"qrup", txtBoxQrp.Text.ToString());
                        cmd.Parameters.AddWithValue(@"adres", txtBoxUnvan.Text.ToString());
                        cmd.Parameters.AddWithValue(@"mobil", txtBoxTf.Text.ToString());
                        cmd.Parameters.AddWithValue(@"diger", txtBoxDiger.Text.ToString());
                        cmd.ExecuteNonQuery();
                        SqlDataAdapter dtadptr = new SqlDataAdapter("select *from General ", elaqe);
                        DataTable dt = new DataTable();
                        dtadptr.Fill(dt);
                        dataGridView1.DataSource = dt;
                        elaqe.Close();

                    }
                    else
                    {
                        MessageBox.Show(Text = "Bu otaq dolub!", "Informasiya", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else //saheleri bosdusa eger onda isleyir
                {
                    MessageBox.Show("Sahələr tam daxil edilməyib!", "Xəbərdarlıq", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else //ilk defe kilik olubsa eger mesaj verir acildigi haqqinda
            {
                MessageBox.Show("Müvafiq xanalar aktivləşdirildi!\nMəlumatları daxil edə bilərsiz.", "Informasiya", MessageBoxButtons.OK, MessageBoxIcon.Information);
                clickOlub = true;
            }
        }
        //
        //Təmizlə buttonun hadisəsi
        //
        private void ıcnBtnAdjust_Click(object sender, EventArgs e)
        {
            CellsEnter();
            TxtEnabled(false);
        }
        //
        //Yenilə buttonun hadisəsi
        //
        private void ıcnBtnRefresh_Click(object sender, EventArgs e)
        {
           
        }
        //
        //Sil buttonun hadisəsi
        //
        private void ıcnBtnDelete_Click(object sender, EventArgs e)
        {
        }
    }
}
