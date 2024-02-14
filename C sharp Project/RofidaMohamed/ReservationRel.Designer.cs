namespace C_sharp_Project.RofidaMohamed
{
    partial class ReservationRel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReservationRel));
            DataGridViewCellStyle dataGridViewCellStyle13 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle14 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle15 = new DataGridViewCellStyle();
            editbtn = new Bunifu.Framework.UI.BunifuThinButton2();
            addbtn = new Bunifu.Framework.UI.BunifuThinButton2();
            delbtn = new Bunifu.Framework.UI.BunifuThinButton2();
            label6 = new Label();
            panel1 = new Panel();
            pictureBox11 = new PictureBox();
            pictureBox1 = new PictureBox();
            pictureBox7 = new PictureBox();
            pictureBox6 = new PictureBox();
            pictureBox5 = new PictureBox();
            pictureBox4 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox2 = new PictureBox();
            sqlCommand1 = new Microsoft.Data.SqlClient.SqlCommand();
            dataGridView1 = new DataGridView();
            searchbtn = new Button();
            searchBox = new TextBox();
            dtpSearch = new DateTimePicker();
            label3 = new Label();
            SelSearchbox = new ComboBox();
            pictureBox12 = new PictureBox();
            pictureBox9 = new PictureBox();
            pictureBox8 = new PictureBox();
            label4 = new Label();
            label2 = new Label();
            label1 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox11).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox12).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox9).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).BeginInit();
            SuspendLayout();
            // 
            // editbtn
            // 
            editbtn.ActiveBorderThickness = 1;
            editbtn.ActiveCornerRadius = 20;
            editbtn.ActiveFillColor = Color.SeaGreen;
            editbtn.ActiveForecolor = Color.White;
            editbtn.ActiveLineColor = Color.SeaGreen;
            editbtn.BackColor = Color.FromArgb(224, 234, 249);
            editbtn.BackgroundImage = (Image)resources.GetObject("editbtn.BackgroundImage");
            editbtn.ButtonText = "Update";
            editbtn.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            editbtn.ForeColor = Color.SeaGreen;
            editbtn.IdleBorderThickness = 1;
            editbtn.IdleCornerRadius = 20;
            editbtn.IdleFillColor = Color.Green;
            editbtn.IdleForecolor = Color.SeaShell;
            editbtn.IdleLineColor = Color.SeaGreen;
            editbtn.Location = new Point(724, 626);
            editbtn.Margin = new Padding(6, 5, 6, 5);
            editbtn.Name = "editbtn";
            editbtn.Size = new Size(159, 56);
            editbtn.TabIndex = 118;
            editbtn.TextAlign = ContentAlignment.MiddleCenter;
            editbtn.Click += editbtn_Click;
            // 
            // addbtn
            // 
            addbtn.ActiveBorderThickness = 1;
            addbtn.ActiveCornerRadius = 20;
            addbtn.ActiveFillColor = Color.SeaGreen;
            addbtn.ActiveForecolor = Color.White;
            addbtn.ActiveLineColor = Color.SeaGreen;
            addbtn.BackColor = Color.FromArgb(224, 234, 249);
            addbtn.BackgroundImage = (Image)resources.GetObject("addbtn.BackgroundImage");
            addbtn.ButtonText = "Add";
            addbtn.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            addbtn.ForeColor = Color.SeaGreen;
            addbtn.IdleBorderThickness = 1;
            addbtn.IdleCornerRadius = 20;
            addbtn.IdleFillColor = SystemColors.WindowText;
            addbtn.IdleForecolor = Color.SeaShell;
            addbtn.IdleLineColor = Color.SeaShell;
            addbtn.Location = new Point(265, 107);
            addbtn.Margin = new Padding(6, 5, 6, 5);
            addbtn.Name = "addbtn";
            addbtn.Size = new Size(159, 56);
            addbtn.TabIndex = 117;
            addbtn.TextAlign = ContentAlignment.MiddleCenter;
            addbtn.Click += addbtn_Click;
            // 
            // delbtn
            // 
            delbtn.ActiveBorderThickness = 1;
            delbtn.ActiveCornerRadius = 20;
            delbtn.ActiveFillColor = Color.Brown;
            delbtn.ActiveForecolor = Color.Snow;
            delbtn.ActiveLineColor = Color.SeaGreen;
            delbtn.BackColor = Color.FromArgb(224, 234, 249);
            delbtn.BackgroundImage = (Image)resources.GetObject("delbtn.BackgroundImage");
            delbtn.ButtonText = "Delete";
            delbtn.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            delbtn.ForeColor = Color.SeaGreen;
            delbtn.IdleBorderThickness = 1;
            delbtn.IdleCornerRadius = 20;
            delbtn.IdleFillColor = Color.FromArgb(192, 0, 0);
            delbtn.IdleForecolor = Color.Transparent;
            delbtn.IdleLineColor = Color.Sienna;
            delbtn.Location = new Point(929, 626);
            delbtn.Margin = new Padding(6, 5, 6, 5);
            delbtn.Name = "delbtn";
            delbtn.Size = new Size(159, 56);
            delbtn.TabIndex = 116;
            delbtn.TextAlign = ContentAlignment.MiddleCenter;
            delbtn.Click += delbtn_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Rockwell Extra Bold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.Black;
            label6.Location = new Point(104, 642);
            label6.Name = "label6";
            label6.Size = new Size(95, 24);
            label6.TabIndex = 22;
            label6.Text = "Logout";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(134, 191, 243);
            panel1.Controls.Add(pictureBox12);
            panel1.Controls.Add(pictureBox9);
            panel1.Controls.Add(pictureBox8);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox11);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label6);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(250, 696);
            panel1.TabIndex = 104;
            // 
            // pictureBox11
            // 
            pictureBox11.Image = (Image)resources.GetObject("pictureBox11.Image");
            pictureBox11.Location = new Point(27, 627);
            pictureBox11.Name = "pictureBox11";
            pictureBox11.Size = new Size(62, 39);
            pictureBox11.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox11.TabIndex = 27;
            pictureBox11.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(49, 50);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(127, 62);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 23;
            pictureBox1.TabStop = false;
            // 
            // pictureBox7
            // 
            pictureBox7.BackColor = Color.Transparent;
            pictureBox7.Image = (Image)resources.GetObject("pictureBox7.Image");
            pictureBox7.Location = new Point(1070, 12);
            pictureBox7.Name = "pictureBox7";
            pictureBox7.Size = new Size(35, 40);
            pictureBox7.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox7.TabIndex = 111;
            pictureBox7.TabStop = false;
            pictureBox7.Click += pictureBox7_Click;
            // 
            // pictureBox6
            // 
            pictureBox6.Image = (Image)resources.GetObject("pictureBox6.Image");
            pictureBox6.Location = new Point(-182, 732);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(62, 39);
            pictureBox6.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox6.TabIndex = 110;
            pictureBox6.TabStop = false;
            // 
            // pictureBox5
            // 
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(-193, 341);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(28, 37);
            pictureBox5.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox5.TabIndex = 109;
            pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(-197, 434);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(37, 38);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 108;
            pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(-199, 523);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(43, 30);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 107;
            pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(-193, 264);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(43, 29);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 106;
            pictureBox2.TabStop = false;
            // 
            // sqlCommand1
            // 
            sqlCommand1.CommandTimeout = 30;
            sqlCommand1.EnableOptimizedParameterBinding = false;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToResizeColumns = false;
            dataGridView1.AllowUserToResizeRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle13.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle13.BackColor = Color.FromArgb(73, 151, 229);
            dataGridViewCellStyle13.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle13.ForeColor = SystemColors.Window;
            dataGridViewCellStyle13.SelectionBackColor = Color.FromArgb(73, 151, 229);
            dataGridViewCellStyle13.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle13.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle13;
            dataGridView1.ColumnHeadersHeight = 35;
            dataGridViewCellStyle14.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = SystemColors.Window;
            dataGridViewCellStyle14.Font = new Font("Segoe UI", 12F);
            dataGridViewCellStyle14.ForeColor = SystemColors.ActiveCaptionText;
            dataGridViewCellStyle14.SelectionBackColor = Color.Azure;
            dataGridViewCellStyle14.SelectionForeColor = Color.Black;
            dataGridViewCellStyle14.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle14;
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.GridColor = Color.LightGray;
            dataGridView1.Location = new Point(265, 170);
            dataGridView1.Name = "dataGridView1";
            dataGridViewCellStyle15.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle15.BackColor = SystemColors.Control;
            dataGridViewCellStyle15.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle15.ForeColor = Color.FromArgb(134, 191, 243);
            dataGridViewCellStyle15.SelectionBackColor = Color.LightGray;
            dataGridViewCellStyle15.SelectionForeColor = Color.FromArgb(134, 191, 243);
            dataGridViewCellStyle15.WrapMode = DataGridViewTriState.True;
            dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle15;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 20;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(840, 448);
            dataGridView1.TabIndex = 126;
            dataGridView1.SelectionChanged += dataGridView1_SelectionChanged;
            // 
            // searchbtn
            // 
            searchbtn.Image = (Image)resources.GetObject("searchbtn.Image");
            searchbtn.Location = new Point(1070, 128);
            searchbtn.Name = "searchbtn";
            searchbtn.Size = new Size(35, 35);
            searchbtn.TabIndex = 127;
            searchbtn.UseVisualStyleBackColor = true;
            searchbtn.Click += searchbtn_Click;
            // 
            // searchBox
            // 
            searchBox.BorderStyle = BorderStyle.FixedSingle;
            searchBox.Font = new Font("Segoe UI", 12F);
            searchBox.Location = new Point(778, 88);
            searchBox.Name = "searchBox";
            searchBox.Size = new Size(286, 34);
            searchBox.TabIndex = 128;
            searchBox.TextChanged += searchBox_TextChanged;
            // 
            // dtpSearch
            // 
            dtpSearch.Font = new Font("Segoe UI", 10F);
            dtpSearch.Format = DateTimePickerFormat.Short;
            dtpSearch.Location = new Point(778, 133);
            dtpSearch.MinDate = new DateTime(2018, 6, 20, 0, 0, 0, 0);
            dtpSearch.Name = "dtpSearch";
            dtpSearch.ShowUpDown = true;
            dtpSearch.Size = new Size(286, 30);
            dtpSearch.TabIndex = 129;
            dtpSearch.Value = new DateTime(2024, 2, 13, 0, 0, 0, 0);
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.FlatStyle = FlatStyle.System;
            label3.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Navy;
            label3.Location = new Point(282, 40);
            label3.Name = "label3";
            label3.Size = new Size(192, 38);
            label3.TabIndex = 130;
            label3.Text = "Reservations :";
            // 
            // SelSearchbox
            // 
            SelSearchbox.Font = new Font("Segoe UI", 11F);
            SelSearchbox.FormattingEnabled = true;
            SelSearchbox.Location = new Point(602, 88);
            SelSearchbox.Name = "SelSearchbox";
            SelSearchbox.Size = new Size(151, 33);
            SelSearchbox.TabIndex = 131;
            // 
            // pictureBox12
            // 
            pictureBox12.Image = (Image)resources.GetObject("pictureBox12.Image");
            pictureBox12.Location = new Point(22, 382);
            pictureBox12.Name = "pictureBox12";
            pictureBox12.Size = new Size(47, 31);
            pictureBox12.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox12.TabIndex = 151;
            pictureBox12.TabStop = false;
            // 
            // pictureBox9
            // 
            pictureBox9.Image = (Image)resources.GetObject("pictureBox9.Image");
            pictureBox9.Location = new Point(22, 311);
            pictureBox9.Name = "pictureBox9";
            pictureBox9.Size = new Size(47, 36);
            pictureBox9.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox9.TabIndex = 150;
            pictureBox9.TabStop = false;
            // 
            // pictureBox8
            // 
            pictureBox8.Image = (Image)resources.GetObject("pictureBox8.Image");
            pictureBox8.Location = new Point(22, 242);
            pictureBox8.Name = "pictureBox8";
            pictureBox8.Size = new Size(47, 35);
            pictureBox8.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox8.TabIndex = 149;
            pictureBox8.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Rockwell", 13.8F, FontStyle.Bold);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(85, 314);
            label4.Name = "label4";
            label4.Size = new Size(91, 28);
            label4.TabIndex = 148;
            label4.Text = "Patient";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Rockwell", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(85, 244);
            label2.Name = "label2";
            label2.Size = new Size(135, 28);
            label2.TabIndex = 146;
            label2.Text = "DashBoard";
            label2.Click += label2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Rockwell", 13.8F, FontStyle.Bold);
            label1.ForeColor = Color.WhiteSmoke;
            label1.Location = new Point(85, 380);
            label1.Name = "label1";
            label1.Size = new Size(146, 28);
            label1.TabIndex = 147;
            label1.Text = "Reservation";
            // 
            // ReservationRel
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(224, 234, 249);
            ClientSize = new Size(1127, 696);
            Controls.Add(SelSearchbox);
            Controls.Add(label3);
            Controls.Add(dtpSearch);
            Controls.Add(searchBox);
            Controls.Add(searchbtn);
            Controls.Add(dataGridView1);
            Controls.Add(pictureBox7);
            Controls.Add(pictureBox6);
            Controls.Add(pictureBox5);
            Controls.Add(editbtn);
            Controls.Add(pictureBox4);
            Controls.Add(addbtn);
            Controls.Add(pictureBox3);
            Controls.Add(delbtn);
            Controls.Add(pictureBox2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ReservationRel";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ReservationPage";
            Activated += ReservationRel_Activated;
            Load += ReservationRel_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox11).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox12).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox9).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Bunifu.Framework.UI.BunifuThinButton2 editbtn;
        private Bunifu.Framework.UI.BunifuThinButton2 addbtn;
        private Bunifu.Framework.UI.BunifuThinButton2 delbtn;
        private Label label6;
        private Panel panel1;
        private PictureBox pictureBox1;
        private PictureBox pictureBox7;
        private PictureBox pictureBox6;
        private PictureBox pictureBox5;
        private PictureBox pictureBox4;
        private PictureBox pictureBox3;
        private PictureBox pictureBox2;
        private PictureBox pictureBox11;
        private Microsoft.Data.SqlClient.SqlCommand sqlCommand1;
        private DataGridView dataGridView1;
        private Button searchbtn;
        private TextBox searchBox;
        private DateTimePicker dtpSearch;
        private Label label3;
        private ComboBox SelSearchbox;
        private PictureBox pictureBox12;
        private PictureBox pictureBox9;
        private PictureBox pictureBox8;
        private Label label4;
        private Label label2;
        private Label label1;
    }
}