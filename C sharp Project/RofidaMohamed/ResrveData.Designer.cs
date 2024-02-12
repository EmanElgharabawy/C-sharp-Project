namespace C_sharp_Project.RofidaMohamed
{
    partial class ResrveData
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
            label1 = new Label();
            PatientBox = new ComboBox();
            drBox = new ComboBox();
            dateTimePicker1 = new DateTimePicker();
            priceTextBox = new TextBox();
            StateBox = new ComboBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft JhengHei", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(41, 39);
            label1.Name = "label1";
            label1.Size = new Size(272, 29);
            label1.TabIndex = 0;
            label1.Text = "Add New Appointment";
            // 
            // PatientBox
            // 
            PatientBox.FormattingEnabled = true;
            PatientBox.Location = new Point(38, 144);
            PatientBox.Name = "PatientBox";
            PatientBox.Size = new Size(272, 28);
            PatientBox.TabIndex = 1;
            // 
            // drBox
            // 
            drBox.FormattingEnabled = true;
            drBox.Location = new Point(38, 218);
            drBox.Name = "drBox";
            drBox.Size = new Size(272, 28);
            drBox.TabIndex = 2;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(38, 307);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(272, 27);
            dateTimePicker1.TabIndex = 3;
            // 
            // priceTextBox
            // 
            priceTextBox.Location = new Point(38, 389);
            priceTextBox.Name = "priceTextBox";
            priceTextBox.Size = new Size(272, 27);
            priceTextBox.TabIndex = 4;
            // 
            // StateBox
            // 
            StateBox.FormattingEnabled = true;
            StateBox.Location = new Point(38, 473);
            StateBox.Name = "StateBox";
            StateBox.Size = new Size(272, 28);
            StateBox.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(41, 98);
            label2.Name = "label2";
            label2.Size = new Size(72, 28);
            label2.TabIndex = 6;
            label2.Text = "Patient";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(40, 175);
            label3.Name = "label3";
            label3.Size = new Size(73, 28);
            label3.TabIndex = 7;
            label3.Text = "Doctor";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F);
            label4.Location = new Point(40, 265);
            label4.Name = "label4";
            label4.Size = new Size(54, 28);
            label4.TabIndex = 8;
            label4.Text = "Time";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F);
            label5.Location = new Point(38, 349);
            label5.Name = "label5";
            label5.Size = new Size(54, 28);
            label5.TabIndex = 9;
            label5.Text = "Price";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F);
            label6.Location = new Point(38, 432);
            label6.Name = "label6";
            label6.Size = new Size(56, 28);
            label6.TabIndex = 10;
            label6.Text = "State";
            // 
            // button1
            // 
            button1.BackColor = Color.SeaGreen;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Microsoft JhengHei", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.ButtonHighlight;
            button1.Location = new Point(38, 528);
            button1.Name = "button1";
            button1.Size = new Size(134, 40);
            button1.TabIndex = 11;
            button1.Text = "Save";
            button1.UseVisualStyleBackColor = false;
            // 
            // ResrveData
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(224, 234, 249);
            ClientSize = new Size(410, 612);
            Controls.Add(button1);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(StateBox);
            Controls.Add(priceTextBox);
            Controls.Add(dateTimePicker1);
            Controls.Add(drBox);
            Controls.Add(PatientBox);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ResrveData";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox PatientBox;
        private ComboBox drBox;
        private DateTimePicker dateTimePicker1;
        private TextBox priceTextBox;
        private ComboBox StateBox;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Button button1;
    }
}