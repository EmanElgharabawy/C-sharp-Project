namespace C_sharp_Project.RofidaMohamed
{
    partial class reservation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(reservation));
            dataGridView1 = new DataGridView();
            panel1 = new Panel();
            button2 = new Button();
            patientListBtn = new Button();
            pictureBox1 = new PictureBox();
            searchBox = new TextBox();
            searchbtn = new Button();
            button1 = new Button();
            editBtn = new Button();
            deleteBtn = new Button();
            label1 = new Label();
            dateTimePicker1 = new DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.WhiteSmoke;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(266, 180);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(840, 448);
            dataGridView1.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(134, 191, 243);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(patientListBtn);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(250, 696);
            panel1.TabIndex = 1;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(33, 102, 171);
            button2.BackgroundImage = (Image)resources.GetObject("button2.BackgroundImage");
            button2.BackgroundImageLayout = ImageLayout.Zoom;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Microsoft JhengHei", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = SystemColors.ButtonHighlight;
            button2.Location = new Point(-147, 377);
            button2.Name = "button2";
            button2.Size = new Size(397, 50);
            button2.TabIndex = 8;
            button2.Text = "                                     Reservation";
            button2.UseVisualStyleBackColor = false;
            // 
            // patientListBtn
            // 
            patientListBtn.BackColor = Color.FromArgb(134, 191, 243);
            patientListBtn.BackgroundImage = (Image)resources.GetObject("patientListBtn.BackgroundImage");
            patientListBtn.BackgroundImageLayout = ImageLayout.Zoom;
            patientListBtn.FlatAppearance.BorderSize = 0;
            patientListBtn.FlatStyle = FlatStyle.Flat;
            patientListBtn.Font = new Font("Microsoft JhengHei", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            patientListBtn.ImageAlign = ContentAlignment.MiddleLeft;
            patientListBtn.Location = new Point(-147, 321);
            patientListBtn.Name = "patientListBtn";
            patientListBtn.Size = new Size(397, 50);
            patientListBtn.TabIndex = 7;
            patientListBtn.Text = "                            Patient";
            patientListBtn.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImageLayout = ImageLayout.None;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(27, 61);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(184, 183);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // searchBox
            // 
            searchBox.BorderStyle = BorderStyle.FixedSingle;
            searchBox.Font = new Font("Segoe UI", 12F);
            searchBox.Location = new Point(769, 99);
            searchBox.Name = "searchBox";
            searchBox.Size = new Size(286, 34);
            searchBox.TabIndex = 2;
            // 
            // searchbtn
            // 
            searchbtn.Image = (Image)resources.GetObject("searchbtn.Image");
            searchbtn.Location = new Point(1071, 134);
            searchbtn.Name = "searchbtn";
            searchbtn.Size = new Size(35, 35);
            searchbtn.TabIndex = 3;
            searchbtn.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.BackColor = Color.MintCream;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.DodgerBlue;
            button1.Location = new Point(266, 128);
            button1.Name = "button1";
            button1.Size = new Size(120, 35);
            button1.TabIndex = 4;
            button1.Text = "Add";
            button1.UseVisualStyleBackColor = false;
            // 
            // editBtn
            // 
            editBtn.BackColor = Color.MediumSeaGreen;
            editBtn.FlatAppearance.BorderSize = 0;
            editBtn.FlatStyle = FlatStyle.Flat;
            editBtn.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            editBtn.ForeColor = SystemColors.ButtonHighlight;
            editBtn.Location = new Point(832, 645);
            editBtn.Name = "editBtn";
            editBtn.Size = new Size(118, 39);
            editBtn.TabIndex = 5;
            editBtn.Text = "Edit";
            editBtn.UseVisualStyleBackColor = false;
            // 
            // deleteBtn
            // 
            deleteBtn.BackColor = Color.Brown;
            deleteBtn.FlatAppearance.BorderSize = 0;
            deleteBtn.FlatStyle = FlatStyle.Flat;
            deleteBtn.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            deleteBtn.ForeColor = Color.Transparent;
            deleteBtn.Location = new Point(988, 645);
            deleteBtn.Name = "deleteBtn";
            deleteBtn.Size = new Size(118, 39);
            deleteBtn.TabIndex = 6;
            deleteBtn.Text = "Delete";
            deleteBtn.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.FlatStyle = FlatStyle.System;
            label1.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Navy;
            label1.Location = new Point(266, 56);
            label1.Name = "label1";
            label1.Size = new Size(192, 38);
            label1.TabIndex = 7;
            label1.Text = "Reservations :";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Font = new Font("Segoe UI", 10F);
            dateTimePicker1.Location = new Point(769, 139);
            dateTimePicker1.MinDate = new DateTime(2018, 6, 20, 0, 0, 0, 0);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.ShowUpDown = true;
            dateTimePicker1.Size = new Size(286, 30);
            dateTimePicker1.TabIndex = 8;
            dateTimePicker1.Value = new DateTime(2024, 2, 4, 0, 0, 0, 0);
            // 
            // reservation
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.FromArgb(224, 234, 249);
            ClientSize = new Size(1127, 696);
            Controls.Add(dateTimePicker1);
            Controls.Add(label1);
            Controls.Add(deleteBtn);
            Controls.Add(editBtn);
            Controls.Add(button1);
            Controls.Add(searchbtn);
            Controls.Add(searchBox);
            Controls.Add(panel1);
            Controls.Add(dataGridView1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "reservation";
            Text = "reservation";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Panel panel1;
        private TextBox searchBox;
        private Button searchbtn;
        private Button button1;
        private Button editBtn;
        private Button deleteBtn;
        private PictureBox pictureBox1;
        private Button patientListBtn;
        private Button button2;
        private Label label1;
        private DateTimePicker dateTimePicker1;
    }
}