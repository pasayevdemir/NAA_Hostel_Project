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
    public partial class Form1 : Form
    {
        private string ad;
        private bool clickOlub;
        SqlConnection elaqe = new SqlConnection(@"Data Source=DESKTOP-5SN5VL1\SQLEXPRESS;Initial Catalog=Yataqxana;Integrated Security=True");

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'yataqxanaDataSet.General' table. You can move, or remove it, as needed.
            this.generalTableAdapter.Fill(this.yataqxanaDataSet.General);
            // TODO: This line of code loads data into the 'yataqxanaDataSet.General' table. You can move, or remove it, as needed.
            this.generalTableAdapter.Fill(this.yataqxanaDataSet.General);

        }
        //
        //textBox-lara bazanı köcurən funksiyasi
        //
        private void CellsEnter()
        {

            txtBoxDob.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            txtBoxAd.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txtBoxQrp.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
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
            txtBoxDob.Clear();
            txtBoxQrp.Clear();
            txtBoxTf.Clear();
            txtBoxDiger.Clear();
            txtBoxUnvan.Text = "";
        }
//
//textBox-ları təmizləyən funksiyasi
//
        private void axtarClear()
        {
            txtBoxOtaq_ax.Clear();
            txtBoxAd_ax.Clear();
            txtBoxQrp_ax.Clear();
            txtBoxUnvan_ax.Text = "";
            txtBoxTf_ax.Clear();
            txtBoxDiger_ax.Clear();
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
                        txtBoxDob.Enabled = true;
                        txtBoxQrp.Enabled = true;
                        txtBoxTf.Enabled = true;
                        txtBoxDiger.Enabled = true;
                        txtBoxUnvan.Enabled = true;
                    }
                    break;
                case false:
                    {
                        txtBoxAd.Enabled = false;
                        txtBoxDob.Enabled = false;
                        txtBoxQrp.Enabled = false;
                        txtBoxTf.Enabled = false;
                        txtBoxDiger.Enabled = false;
                        txtBoxUnvan.Enabled = false;
                    }
                    break;
            }
        }

//
//Sexsin olub olmamasini təyin edən funksiyasi
//
        private bool nameYoxla()
        {
            ad = txtBoxAd.Text;
            bool nam = false;
            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                if (ad == dataGridView1.Rows[i].Cells[0].Value.ToString())
                {
                    nam = true;
                    break;
                }
            }
            return nam;
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
            ıcnBtnRefresh.Enabled = false;
            ıcnBtnDelete.Enabled = false;
            axtarClear();
            if (clickOlub == false)//Ilk defe kilik olubsa saheleri temizleyir ve acir
            {
                ClearBox();
                TxtEnabled(true);
            }
            if (clickOlub == true)//ikinci sefer kilik olubsa sahelerin dulu ve ya bos odldugunu yoxlayir
            {
                //bu if ise sahelerin dolu oldugu halda isleyir 
                if (txtBoxAd.Text != "" && txtBoxDob.Text != "" && txtBoxQrp.Text != "" && txtBoxTf.Text != "" && txtBoxDiger.Text != "" && txtBoxUnvan.Text != "")
                {
                    bool ab = nameYoxla();
                    if (ab == false)
                    {
                        elaqe.Open();
                        SqlCommand cmd = new SqlCommand("Insert Into General( Name,Qroup,DOB,Address,Phone,Other) Values(@name,@qrup,@dob,@adres,@mobil,@diger)", elaqe);
                        cmd.Parameters.AddWithValue(@"dob", txtBoxDob.Text);
                        cmd.Parameters.AddWithValue(@"name", txtBoxAd.Text.ToString());
                        cmd.Parameters.AddWithValue(@"qrup", txtBoxQrp.Text.ToString());
                        cmd.Parameters.AddWithValue(@"adres", txtBoxUnvan.Text.ToString());
                        cmd.Parameters.AddWithValue(@"mobil", txtBoxTf.Text.ToString());
                        cmd.Parameters.AddWithValue(@"diger", txtBoxDiger.Text.ToString());
                        cmd.ExecuteNonQuery();
                        SqlDataAdapter dtadptr = new SqlDataAdapter("select *from General", elaqe);
                        DataTable dt = new DataTable();
                        dtadptr.Fill(dt);
                        dataGridView1.DataSource = dt;
                        elaqe.Close();
                        MessageBox.Show("Məlumatlar əlavə edildi!", "Informasiya", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        CellsEnter();
                        TxtEnabled(false);
                        ıcnBtnRefresh.Enabled = true;
                        ıcnBtnDelete.Enabled = true;
                        clickOlub = false;
                    }
                    else
                    {
                        if (ab == true)
                            MessageBox.Show(Text = "Bu Şəxs artıq var!", "Informasiya", MessageBoxButtons.OK, MessageBoxIcon.Information);

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
            axtarClear();
            ıcnBtnAdd.Enabled = true;
            ıcnBtnDelete.Enabled = true;
            ıcnBtnRefresh.Enabled = true;
            clickOlub = false;
            TxtEnabled(false);
            CellsEnter();
            MessageBox.Show(Text = "Sahələr tənzimləndi!", "Informasiya", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
//
//Yenilə buttonun hadisəsi
//
        private void ıcnBtnRefresh_Click(object sender, EventArgs e)
        {
            ıcnBtnAdd.Enabled = false;
            ıcnBtnDelete.Enabled = false;
            if (clickOlub == false)//Ilk defe kilik olubsa saheleri temizleyir ve acir
            {
                TxtEnabled(true);
            }
            if (clickOlub == true)//ikinci sefer kilik olubsa sahelerin dulu ve ya bos odldugunu yoxlayir
            {
                //bu if ise sahelerin dolu oldugu halda isleyir 
                if (txtBoxAd.Text != "" && txtBoxDob.Text != "" && txtBoxQrp.Text != "" && txtBoxTf.Text != "" && txtBoxDiger.Text != "" && txtBoxUnvan.Text != "")
                {
                    elaqe.Open();
                    SqlCommand cmd = new SqlCommand("update General Set Name=@name, Qroup=@qrup,DOB=@dob, Address=@adres, Phone=@mobil, Other=@diger Where Student_ID=" + dataGridView1.CurrentRow.Cells[6].Value + " ", elaqe);
                    cmd.Parameters.AddWithValue(@"dob", txtBoxDob.Text.ToString());
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
                    MessageBox.Show("Məlumatlar yeniləndi!", "Informasiya", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    TxtEnabled(false);
                    ıcnBtnAdd.Enabled = true;
                    ıcnBtnDelete.Enabled = true;
                    clickOlub = false;

                }
                else //saheleri bosdusa eger onda isleyir
                {
                    MessageBox.Show("Sahələr tam daxil edilməyib!", "Xəbərdarlıq", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else //ilk defe kilik olubsa eger mesaj verir acildigi haqqinda
            {
                MessageBox.Show("Müvafiq xanalar aktivləşdirildi!\nMəlumatları yeniliyə bilərsiz.", "Informasiya", MessageBoxButtons.OK, MessageBoxIcon.Information);
                clickOlub = true;
            }
        }
        //
        //Sil buttonun hadisəsi
        //
        private void ıcnBtnDelete_Click(object sender, EventArgs e)
        {
            clickOlub = false;
            if (MessageBox.Show("Məlumatı bazadan silmək istəyirmisiniz?", "Sətir Sil", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {

                elaqe.Open();
                SqlCommand cmd = new SqlCommand(" Delete from General Where Student_ID=@id ", elaqe);
                cmd.Parameters.AddWithValue(@"id", dataGridView1.CurrentRow.Cells[6].Value.ToString());
                cmd.ExecuteNonQuery();
                SqlDataAdapter dtadptr = new SqlDataAdapter("select *from General ", elaqe);
                DataTable dt = new DataTable();
                dtadptr.Fill(dt);
                dataGridView1.DataSource = dt;
                elaqe.Close();
            }
        }
//
//Axtar bolmesinin textChanged hadisesi
//
        private string[] m = new string[6];
        private void axtar_TextChanged(object sender, EventArgs e)
        {
            elaqe.Open();
            m[0] = txtBoxOtaq_ax.Text;
            m[1] = txtBoxAd_ax.Text;
            m[2] = txtBoxUnvan_ax.Text;
            m[3] = txtBoxQrp_ax.Text;
            m[4] = txtBoxTf_ax.Text;
            m[5] = txtBoxDiger_ax.Text;
            SqlDataAdapter dtadptr = new SqlDataAdapter("select *from General Where DOB like '%" + m[0] + "%' and Name like '%" + m[1] + "%' and Address like '%" + m[2] + "%' and Qroup like '%" + m[3] + "%'  and Phone like '%" + m[4] + "%'   and Other like '%" + m[5] + "%'  ", elaqe);
            DataTable dt = new DataTable();
            dtadptr.Fill(dt);
            dataGridView1.DataSource = dt;
            elaqe.Close();
        }
    }
}
