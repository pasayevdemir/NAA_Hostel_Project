
namespace NaaHostel
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.roomNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qroupDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.otherDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.generalBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hostelDataSet = new NaaHostel.HostelDataSet();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBoxOtaq = new System.Windows.Forms.TextBox();
            this.generalTableAdapter = new NaaHostel.HostelDataSetTableAdapters.GeneralTableAdapter();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.fKStudentHostelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.courpusBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.courpusTableAdapter = new NaaHostel.HostelDataSetTableAdapters.CourpusTableAdapter();
            this.studentTableAdapter = new NaaHostel.HostelDataSetTableAdapters.StudentTableAdapter();
            this.studentIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.corpusIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dOBDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qroupDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.otherDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtBoxUnvan = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.generalBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hostelDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKStudentHostelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.courpusBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.roomNumberDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.addressDataGridViewTextBoxColumn,
            this.qroupDataGridViewTextBoxColumn,
            this.phoneDataGridViewTextBoxColumn,
            this.otherDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.generalBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView1.Location = new System.Drawing.Point(0, 360);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(800, 233);
            this.dataGridView1.TabIndex = 0;
            // 
            // roomNumberDataGridViewTextBoxColumn
            // 
            this.roomNumberDataGridViewTextBoxColumn.DataPropertyName = "RoomNumber";
            this.roomNumberDataGridViewTextBoxColumn.HeaderText = "RoomNumber";
            this.roomNumberDataGridViewTextBoxColumn.Name = "roomNumberDataGridViewTextBoxColumn";
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // addressDataGridViewTextBoxColumn
            // 
            this.addressDataGridViewTextBoxColumn.DataPropertyName = "Address";
            this.addressDataGridViewTextBoxColumn.HeaderText = "Address";
            this.addressDataGridViewTextBoxColumn.Name = "addressDataGridViewTextBoxColumn";
            // 
            // qroupDataGridViewTextBoxColumn
            // 
            this.qroupDataGridViewTextBoxColumn.DataPropertyName = "Qroup";
            this.qroupDataGridViewTextBoxColumn.HeaderText = "Qroup";
            this.qroupDataGridViewTextBoxColumn.Name = "qroupDataGridViewTextBoxColumn";
            // 
            // phoneDataGridViewTextBoxColumn
            // 
            this.phoneDataGridViewTextBoxColumn.DataPropertyName = "Phone";
            this.phoneDataGridViewTextBoxColumn.HeaderText = "Phone";
            this.phoneDataGridViewTextBoxColumn.Name = "phoneDataGridViewTextBoxColumn";
            // 
            // otherDataGridViewTextBoxColumn
            // 
            this.otherDataGridViewTextBoxColumn.DataPropertyName = "Other";
            this.otherDataGridViewTextBoxColumn.HeaderText = "Other";
            this.otherDataGridViewTextBoxColumn.Name = "otherDataGridViewTextBoxColumn";
            // 
            // generalBindingSource
            // 
            this.generalBindingSource.DataMember = "General";
            this.generalBindingSource.DataSource = this.hostelDataSet;
            // 
            // hostelDataSet
            // 
            this.hostelDataSet.DataSetName = "HostelDataSet";
            this.hostelDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(111, 50);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "axtar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(242, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "label1";
            // 
            // txtBoxOtaq
            // 
            this.txtBoxOtaq.Location = new System.Drawing.Point(5, 52);
            this.txtBoxOtaq.Name = "txtBoxOtaq";
            this.txtBoxOtaq.Size = new System.Drawing.Size(100, 20);
            this.txtBoxOtaq.TabIndex = 3;
            // 
            // generalTableAdapter
            // 
            this.generalTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.studentIDDataGridViewTextBoxColumn,
            this.corpusIDDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn1,
            this.addressDataGridViewTextBoxColumn1,
            this.dOBDataGridViewTextBoxColumn,
            this.qroupDataGridViewTextBoxColumn1,
            this.phoneDataGridViewTextBoxColumn1,
            this.otherDataGridViewTextBoxColumn1});
            this.dataGridView2.DataSource = this.fKStudentHostelBindingSource;
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView2.Location = new System.Drawing.Point(0, 210);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(800, 150);
            this.dataGridView2.TabIndex = 4;
            // 
            // fKStudentHostelBindingSource
            // 
            this.fKStudentHostelBindingSource.DataMember = "FK_Student_Hostel";
            this.fKStudentHostelBindingSource.DataSource = this.courpusBindingSource;
            // 
            // courpusBindingSource
            // 
            this.courpusBindingSource.DataMember = "Courpus";
            this.courpusBindingSource.DataSource = this.hostelDataSet;
            // 
            // courpusTableAdapter
            // 
            this.courpusTableAdapter.ClearBeforeFill = true;
            // 
            // studentTableAdapter
            // 
            this.studentTableAdapter.ClearBeforeFill = true;
            // 
            // studentIDDataGridViewTextBoxColumn
            // 
            this.studentIDDataGridViewTextBoxColumn.DataPropertyName = "Student_ID";
            this.studentIDDataGridViewTextBoxColumn.HeaderText = "Student_ID";
            this.studentIDDataGridViewTextBoxColumn.Name = "studentIDDataGridViewTextBoxColumn";
            this.studentIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // corpusIDDataGridViewTextBoxColumn
            // 
            this.corpusIDDataGridViewTextBoxColumn.DataPropertyName = "Corpus_ID";
            this.corpusIDDataGridViewTextBoxColumn.HeaderText = "Corpus_ID";
            this.corpusIDDataGridViewTextBoxColumn.Name = "corpusIDDataGridViewTextBoxColumn";
            // 
            // nameDataGridViewTextBoxColumn1
            // 
            this.nameDataGridViewTextBoxColumn1.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn1.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn1.Name = "nameDataGridViewTextBoxColumn1";
            // 
            // addressDataGridViewTextBoxColumn1
            // 
            this.addressDataGridViewTextBoxColumn1.DataPropertyName = "Address";
            this.addressDataGridViewTextBoxColumn1.HeaderText = "Address";
            this.addressDataGridViewTextBoxColumn1.Name = "addressDataGridViewTextBoxColumn1";
            // 
            // dOBDataGridViewTextBoxColumn
            // 
            this.dOBDataGridViewTextBoxColumn.DataPropertyName = "DOB";
            this.dOBDataGridViewTextBoxColumn.HeaderText = "DOB";
            this.dOBDataGridViewTextBoxColumn.Name = "dOBDataGridViewTextBoxColumn";
            // 
            // qroupDataGridViewTextBoxColumn1
            // 
            this.qroupDataGridViewTextBoxColumn1.DataPropertyName = "Qroup";
            this.qroupDataGridViewTextBoxColumn1.HeaderText = "Qroup";
            this.qroupDataGridViewTextBoxColumn1.Name = "qroupDataGridViewTextBoxColumn1";
            // 
            // phoneDataGridViewTextBoxColumn1
            // 
            this.phoneDataGridViewTextBoxColumn1.DataPropertyName = "Phone";
            this.phoneDataGridViewTextBoxColumn1.HeaderText = "Phone";
            this.phoneDataGridViewTextBoxColumn1.Name = "phoneDataGridViewTextBoxColumn1";
            // 
            // otherDataGridViewTextBoxColumn1
            // 
            this.otherDataGridViewTextBoxColumn1.DataPropertyName = "Other";
            this.otherDataGridViewTextBoxColumn1.HeaderText = "Other";
            this.otherDataGridViewTextBoxColumn1.Name = "otherDataGridViewTextBoxColumn1";
            // 
            // txtBoxUnvan
            // 
            this.txtBoxUnvan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.txtBoxUnvan.Enabled = false;
            this.txtBoxUnvan.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.txtBoxUnvan.FormattingEnabled = true;
            this.txtBoxUnvan.Items.AddRange(new object[] {
            "Abşeron rayonu ",
            "Ağcabədi rayonu",
            "Ağdam rayonu",
            "Ağdaş rayonu",
            "Ağstafa rayonu",
            "Ağsu rayonu",
            "Astara rayonu",
            "Bakı şəhəri",
            "Babək rayonu",
            "Balakən rayonu",
            "Beyləqan rayonu",
            "Bərdə rayonu",
            "Biləsuvar rayonu",
            "Cəbrayıl rayonu",
            "Cəlilabad rayonu",
            "Culfa rayonu",
            "Daşkəsən rayonu",
            "Füzuli rayonu ",
            "Gəncə şəhəri",
            "Gədəbəy rayonu",
            "Goranboy rayonu",
            "Göyçay rayonu",
            "Göygöl rayonu",
            "Hacıqabul rayonu",
            "Xankəndi şəhəri",
            "Xaçmaz rayonu",
            "Xızı rayonu",
            "Xocalı rayonu",
            "Xocavənd rayonu",
            "İmişli rayonu",
            "İsmayıllı rayonu",
            "Kəlbəcər rayonu",
            "Kəngərli rayonu",
            "Kürdəmir rayonu",
            "Qax rayonu",
            "Qazax rayonu",
            "Qəbələ rayonu",
            "Qobustan rayonu",
            "Quba rayonu",
            "Qubadlı rayonu",
            "Qusar rayonu",
            "Laçın rayonu",
            "Lerik rayonu",
            "Lənkəran şəhəri",
            "Masallı rayonu",
            "Mingəçevir şəhəri",
            "Naxçıvan şəhəri",
            "Naftalan şəhəri",
            "Neftçala rayonu",
            "Oğuz rayonu",
            "Ordubad rayonu",
            "Saatlı rayonu",
            "Sabirabad rayonu",
            "Salyan rayonu",
            "Samux rayonu",
            "Sədərək rayonu",
            "Siyəzən rayonu",
            "Sumqayıt şəhəri",
            "Şabran rayonu",
            "Şahbuz rayonu",
            "Şamaxı rayonu",
            "Şəki şəhəri",
            "Şəmkir şəhəri",
            "Şərur rayonu",
            "Şuşa rayonu",
            "Şirvan şəhəri",
            "Tərtər rayonu",
            "Tovuz rayonu",
            "Ucar rayonu",
            "Yardımlı rayonu",
            "Yevlax şəhəri",
            "Zaqatala rayonu",
            "Zəngilan rayonu",
            "Zərdab rayonu"});
            this.txtBoxUnvan.Location = new System.Drawing.Point(353, 59);
            this.txtBoxUnvan.Name = "txtBoxUnvan";
            this.txtBoxUnvan.Size = new System.Drawing.Size(200, 21);
            this.txtBoxUnvan.TabIndex = 60;
            this.txtBoxUnvan.SelectedIndexChanged += new System.EventHandler(this.txtBoxUnvan_SelectedIndexChanged);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 593);
            this.Controls.Add(this.txtBoxUnvan);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.txtBoxOtaq);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.generalBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hostelDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKStudentHostelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.courpusBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBoxOtaq;
        private HostelDataSet hostelDataSet;
        private System.Windows.Forms.BindingSource generalBindingSource;
        private HostelDataSetTableAdapters.GeneralTableAdapter generalTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.BindingSource courpusBindingSource;
        private HostelDataSetTableAdapters.CourpusTableAdapter courpusTableAdapter;
        private System.Windows.Forms.BindingSource fKStudentHostelBindingSource;
        private HostelDataSetTableAdapters.StudentTableAdapter studentTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn roomNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn qroupDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn otherDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn corpusIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dOBDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn qroupDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn otherDataGridViewTextBoxColumn1;
        private System.Windows.Forms.ComboBox txtBoxUnvan;
    }
}