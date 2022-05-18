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
    public partial class Courpus3 : Form
    {
        private int a = 0;
        private int b = 0;
        private string ad = "";
        private bool clickOlub;
        public Courpus3()
        {
            InitializeComponent();
            
        }

        SqlConnection elaqe = new SqlConnection(@"Data Source=DESKTOP-5SN5VL1\SQLEXPRESS;Initial Catalog=Yataqxana;Integrated Security=True");

        private void Form3_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'yataqxanaDataSet.General' table. You can move, or remove it, as needed.
            this.generalTableAdapter.Fill(this.yataqxanaDataSet.General);
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
        private void roomCapacity()
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
                if (ad == dataGridView1.Rows[i].Cells[1].Value.ToString())
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
                if (txtBoxAd.Text != "" && txtBoxOtaq.Text != "" && txtBoxQrp.Text != "" && txtBoxTf.Text != "" && txtBoxDiger.Text != "" && txtBoxUnvan.Text != "")
                {
                    roomCapacity();
                    bool ab=nameYoxla();
                    if (a < b && ab== false)
                    {
                        if (b-a-1 == 0) MessageBox.Show("Boş yer qalmadı!", "Informasiya", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        else MessageBox.Show(""+(b-a-1).ToString()+" nəfərlik Boş yer qalıb!", "Informasiya", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                        MessageBox.Show("Məlumatlar əlavə edildi!", "Informasiya", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        CellsEnter();
                        TxtEnabled(false);
                        ıcnBtnRefresh.Enabled = true;
                        ıcnBtnDelete.Enabled = true;
                        clickOlub = false;
                    }
                    else
                    {
                        if(a==b)
                            MessageBox.Show(Text = "Bu otaq dolub!", "Informasiya", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        if(ab ==true)
                            MessageBox.Show(Text = "Bu Şəxs artıq yerləşdirilib!", "Informasiya", MessageBoxButtons.OK, MessageBoxIcon.Information);

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
                if (txtBoxAd.Text != "" && txtBoxOtaq.Text != "" && txtBoxQrp.Text != "" && txtBoxTf.Text != "" && txtBoxDiger.Text != "" && txtBoxUnvan.Text != "")
                {
                    elaqe.Open();
                    SqlCommand cmd = new SqlCommand("update General Set RoomNumber=@otaq, Name=@name, Qroup=@qrup, Address=@adres, Phone=@mobil, Other=@diger Where General_ID=" + dataGridView1.CurrentRow.Cells[6].Value + " ", elaqe);
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
                MessageBox.Show("Müvafiq xanalar aktivləşdirildi!\nMəlumatları daxil edə bilərsiz.", "Informasiya", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                SqlCommand cmd = new SqlCommand(" Delete from General  Where General_ID=@id ", elaqe);
                cmd.Parameters.AddWithValue(@"id", dataGridView1.CurrentRow.Cells[6].Value.ToString());
                cmd.ExecuteNonQuery();
                SqlDataAdapter dtadptr = new SqlDataAdapter("select *from General ", elaqe);
                DataTable dt = new DataTable();
                dtadptr.Fill(dt);
                dataGridView1.DataSource = dt;
                elaqe.Close();
            }
        }
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
            SqlDataAdapter dtadptr = new SqlDataAdapter("select *from General1 Where RoomNumber like '" + m[0] + "%' and Name like '%" + m[1] + "%' and Address like '" + m[2] + "%' and Qroup like '" + m[3] + "%'  and Phone like '" + m[4] + "%'   and Other like '" + m[5] + "%'  ", elaqe);
            DataTable dt = new DataTable();
            dtadptr.Fill(dt);
            dataGridView1.DataSource = dt;
            elaqe.Close();
        }
    }
}
