
namespace NaaHostel
{
    partial class AnaForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AnaForm));
            this.panelForm = new System.Windows.Forms.Panel();
            this.panelDesktop = new System.Windows.Forms.Panel();
            this.picBoxHostel = new System.Windows.Forms.PictureBox();
            this.panelControl = new System.Windows.Forms.Panel();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.homeStripItem = new System.Windows.Forms.ToolStripMenuItem();
            this.courpusStripItem = new System.Windows.Forms.ToolStripMenuItem();
            this.coupus1StripItem = new System.Windows.Forms.ToolStripMenuItem();
            this.coupus2StripItem = new System.Windows.Forms.ToolStripMenuItem();
            this.coupus3StripItem = new System.Windows.Forms.ToolStripMenuItem();
            this.coupus4StripItem = new System.Windows.Forms.ToolStripMenuItem();
            this.studentStripItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panelControlBtn = new System.Windows.Forms.Panel();
            this.btnMinimum = new FontAwesome.Sharp.IconButton();
            this.btnNormal = new FontAwesome.Sharp.IconButton();
            this.btnClose = new FontAwesome.Sharp.IconButton();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.picBoxLogo = new System.Windows.Forms.PictureBox();
            this.panelForm.SuspendLayout();
            this.panelDesktop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxHostel)).BeginInit();
            this.panelControl.SuspendLayout();
            this.panelMenu.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.panelControlBtn.SuspendLayout();
            this.panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // panelForm
            // 
            this.panelForm.AccessibleRole = System.Windows.Forms.AccessibleRole.Window;
            this.panelForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.panelForm.Controls.Add(this.panelDesktop);
            this.panelForm.Controls.Add(this.panelControl);
            this.panelForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelForm.Location = new System.Drawing.Point(0, 0);
            this.panelForm.Name = "panelForm";
            this.panelForm.Padding = new System.Windows.Forms.Padding(3);
            this.panelForm.Size = new System.Drawing.Size(700, 600);
            this.panelForm.TabIndex = 0;
            this.panelForm.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelControl_MouseDown);
            // 
            // panelDesktop
            // 
            this.panelDesktop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.panelDesktop.Controls.Add(this.picBoxHostel);
            this.panelDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktop.Location = new System.Drawing.Point(3, 63);
            this.panelDesktop.Name = "panelDesktop";
            this.panelDesktop.Size = new System.Drawing.Size(694, 534);
            this.panelDesktop.TabIndex = 1;
            // 
            // picBoxHostel
            // 
            this.picBoxHostel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picBoxHostel.Image = ((System.Drawing.Image)(resources.GetObject("picBoxHostel.Image")));
            this.picBoxHostel.Location = new System.Drawing.Point(0, 0);
            this.picBoxHostel.Name = "picBoxHostel";
            this.picBoxHostel.Size = new System.Drawing.Size(694, 534);
            this.picBoxHostel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoxHostel.TabIndex = 0;
            this.picBoxHostel.TabStop = false;
            // 
            // panelControl
            // 
            this.panelControl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(159)))), ((int)(((byte)(253)))));
            this.panelControl.Controls.Add(this.panelMenu);
            this.panelControl.Controls.Add(this.panelControlBtn);
            this.panelControl.Controls.Add(this.panelLogo);
            this.panelControl.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl.Location = new System.Drawing.Point(3, 3);
            this.panelControl.Name = "panelControl";
            this.panelControl.Size = new System.Drawing.Size(694, 60);
            this.panelControl.TabIndex = 0;
            this.panelControl.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelControl_MouseDown);
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(159)))), ((int)(((byte)(253)))));
            this.panelMenu.Controls.Add(this.menuStrip1);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMenu.Location = new System.Drawing.Point(60, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(514, 60);
            this.panelMenu.TabIndex = 3;
            // 
            // menuStrip1
            // 
            this.menuStrip1.AutoSize = false;
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(159)))), ((int)(((byte)(253)))));
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.homeStripItem,
            this.courpusStripItem,
            this.studentStripItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(514, 60);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "mnStrpMenu";
            this.menuStrip1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelControl_MouseDown);
            // 
            // homeStripItem
            // 
            this.homeStripItem.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.homeStripItem.Name = "homeStripItem";
            this.homeStripItem.Size = new System.Drawing.Size(92, 56);
            this.homeStripItem.Text = "Ana Səhifə";
            this.homeStripItem.Click += new System.EventHandler(this.homeStripItem_Click);
            // 
            // courpusStripItem
            // 
            this.courpusStripItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.coupus1StripItem,
            this.coupus2StripItem,
            this.coupus3StripItem,
            this.coupus4StripItem});
            this.courpusStripItem.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.courpusStripItem.Name = "courpusStripItem";
            this.courpusStripItem.Size = new System.Drawing.Size(84, 56);
            this.courpusStripItem.Text = "Korpuslar";
            // 
            // coupus1StripItem
            // 
            this.coupus1StripItem.Name = "coupus1StripItem";
            this.coupus1StripItem.Size = new System.Drawing.Size(155, 24);
            this.coupus1StripItem.Text = "1-ci korpus";
            this.coupus1StripItem.Visible = false;
            this.coupus1StripItem.Click += new System.EventHandler(this.coupus1StripItem_Click);
            // 
            // coupus2StripItem
            // 
            this.coupus2StripItem.Name = "coupus2StripItem";
            this.coupus2StripItem.Size = new System.Drawing.Size(155, 24);
            this.coupus2StripItem.Text = "2-ci korpus";
            this.coupus2StripItem.Visible = false;
            this.coupus2StripItem.Click += new System.EventHandler(this.coupus2StripItem_Click);
            // 
            // coupus3StripItem
            // 
            this.coupus3StripItem.Name = "coupus3StripItem";
            this.coupus3StripItem.Size = new System.Drawing.Size(155, 24);
            this.coupus3StripItem.Text = "3-cü korpus";
            this.coupus3StripItem.Click += new System.EventHandler(this.coupus3StripItem_Click);
            // 
            // coupus4StripItem
            // 
            this.coupus4StripItem.Name = "coupus4StripItem";
            this.coupus4StripItem.Size = new System.Drawing.Size(155, 24);
            this.coupus4StripItem.Text = "4-cü korpus";
            this.coupus4StripItem.Visible = false;
            this.coupus4StripItem.Click += new System.EventHandler(this.coupus4StripItem_Click);
            // 
            // studentStripItem
            // 
            this.studentStripItem.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.studentStripItem.Name = "studentStripItem";
            this.studentStripItem.Size = new System.Drawing.Size(66, 56);
            this.studentStripItem.Text = "Tələbə";
            this.studentStripItem.Click += new System.EventHandler(this.studentStripItem_Click);
            // 
            // panelControlBtn
            // 
            this.panelControlBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(159)))), ((int)(((byte)(253)))));
            this.panelControlBtn.Controls.Add(this.btnMinimum);
            this.panelControlBtn.Controls.Add(this.btnNormal);
            this.panelControlBtn.Controls.Add(this.btnClose);
            this.panelControlBtn.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelControlBtn.Location = new System.Drawing.Point(574, 0);
            this.panelControlBtn.Name = "panelControlBtn";
            this.panelControlBtn.Size = new System.Drawing.Size(120, 60);
            this.panelControlBtn.TabIndex = 2;
            this.panelControlBtn.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelControl_MouseDown);
            // 
            // btnMinimum
            // 
            this.btnMinimum.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(159)))), ((int)(((byte)(253)))));
            this.btnMinimum.FlatAppearance.BorderSize = 0;
            this.btnMinimum.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimum.IconChar = FontAwesome.Sharp.IconChar.WindowMinimize;
            this.btnMinimum.IconColor = System.Drawing.SystemColors.ControlText;
            this.btnMinimum.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnMinimum.IconSize = 20;
            this.btnMinimum.Location = new System.Drawing.Point(0, 0);
            this.btnMinimum.Name = "btnMinimum";
            this.btnMinimum.Size = new System.Drawing.Size(40, 40);
            this.btnMinimum.TabIndex = 8;
            this.btnMinimum.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnMinimum.UseVisualStyleBackColor = false;
            this.btnMinimum.Click += new System.EventHandler(this.btnMinimum_Click);
            // 
            // btnNormal
            // 
            this.btnNormal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(159)))), ((int)(((byte)(253)))));
            this.btnNormal.FlatAppearance.BorderSize = 0;
            this.btnNormal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNormal.IconChar = FontAwesome.Sharp.IconChar.Square;
            this.btnNormal.IconColor = System.Drawing.SystemColors.ControlText;
            this.btnNormal.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnNormal.IconSize = 18;
            this.btnNormal.Location = new System.Drawing.Point(40, 0);
            this.btnNormal.Name = "btnNormal";
            this.btnNormal.Size = new System.Drawing.Size(40, 40);
            this.btnNormal.TabIndex = 7;
            this.btnNormal.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnNormal.UseVisualStyleBackColor = false;
            this.btnNormal.Click += new System.EventHandler(this.btnNormal_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(159)))), ((int)(((byte)(253)))));
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnClose.IconChar = FontAwesome.Sharp.IconChar.Times;
            this.btnClose.IconColor = System.Drawing.Color.Red;
            this.btnClose.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnClose.IconSize = 18;
            this.btnClose.Location = new System.Drawing.Point(80, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(40, 40);
            this.btnClose.TabIndex = 6;
            this.btnClose.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            this.btnClose.MouseLeave += new System.EventHandler(this.btnClose_MouseLeave);
            this.btnClose.MouseHover += new System.EventHandler(this.btnClose_MouseHover);
            // 
            // panelLogo
            // 
            this.panelLogo.Controls.Add(this.picBoxLogo);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(60, 60);
            this.panelLogo.TabIndex = 0;
            // 
            // picBoxLogo
            // 
            this.picBoxLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(159)))), ((int)(((byte)(253)))));
            this.picBoxLogo.Dock = System.Windows.Forms.DockStyle.Left;
            this.picBoxLogo.Image = ((System.Drawing.Image)(resources.GetObject("picBoxLogo.Image")));
            this.picBoxLogo.Location = new System.Drawing.Point(0, 0);
            this.picBoxLogo.Name = "picBoxLogo";
            this.picBoxLogo.Size = new System.Drawing.Size(60, 60);
            this.picBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoxLogo.TabIndex = 0;
            this.picBoxLogo.TabStop = false;
            this.picBoxLogo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelControl_MouseDown);
            // 
            // AnaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 600);
            this.Controls.Add(this.panelForm);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "AnaForm";
            this.Text = "Form1";
            this.panelForm.ResumeLayout(false);
            this.panelDesktop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picBoxHostel)).EndInit();
            this.panelControl.ResumeLayout(false);
            this.panelMenu.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panelControlBtn.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picBoxLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelForm;
        private System.Windows.Forms.Panel panelDesktop;
        private System.Windows.Forms.Panel panelControl;
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel panelControlBtn;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.PictureBox picBoxLogo;
        private FontAwesome.Sharp.IconButton btnMinimum;
        private FontAwesome.Sharp.IconButton btnNormal;
        private FontAwesome.Sharp.IconButton btnClose;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem homeStripItem;
        private System.Windows.Forms.ToolStripMenuItem courpusStripItem;
        private System.Windows.Forms.ToolStripMenuItem coupus1StripItem;
        private System.Windows.Forms.ToolStripMenuItem studentStripItem;
        private System.Windows.Forms.ToolStripMenuItem coupus2StripItem;
        private System.Windows.Forms.ToolStripMenuItem coupus3StripItem;
        private System.Windows.Forms.ToolStripMenuItem coupus4StripItem;
        private System.Windows.Forms.PictureBox picBoxHostel;
    }
}