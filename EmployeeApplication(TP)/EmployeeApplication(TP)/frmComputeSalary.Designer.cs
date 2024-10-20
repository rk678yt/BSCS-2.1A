namespace EmployeeApplication_TP_
{
    partial class frmComputeSalary
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
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            SalaryButton = new Button();
            LNameTextBox = new TextBox();
            JtitleTextBox = new TextBox();
            HoursTextBox = new TextBox();
            RateTextBox = new TextBox();
            DepartmentTextBox = new TextBox();
            FNameTextBox = new TextBox();
            FNameLabel = new Label();
            LNameLabel = new Label();
            SalaryLabel = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(29, 18);
            label1.Name = "label1";
            label1.Size = new Size(64, 15);
            label1.TabIndex = 0;
            label1.Text = "First Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(309, 18);
            label2.Name = "label2";
            label2.Size = new Size(63, 15);
            label2.TabIndex = 1;
            label2.Text = "Last Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(29, 103);
            label3.Name = "label3";
            label3.Size = new Size(70, 15);
            label3.TabIndex = 2;
            label3.Text = "Department";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(309, 103);
            label4.Name = "label4";
            label4.Size = new Size(47, 15);
            label4.TabIndex = 3;
            label4.Text = "JobTitle";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(29, 199);
            label5.Name = "label5";
            label5.Size = new Size(80, 15);
            label5.TabIndex = 4;
            label5.Text = "Rate Per Hour";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(309, 199);
            label6.Name = "label6";
            label6.Size = new Size(111, 15);
            label6.TabIndex = 5;
            label6.Text = "Total Hours Worked";
            // 
            // SalaryButton
            // 
            SalaryButton.Location = new Point(139, 269);
            SalaryButton.Name = "SalaryButton";
            SalaryButton.Size = new Size(281, 54);
            SalaryButton.TabIndex = 6;
            SalaryButton.Text = "Compute Salary";
            SalaryButton.UseVisualStyleBackColor = true;
            SalaryButton.Click += SalaryButton_Click;
            // 
            // LNameTextBox
            // 
            LNameTextBox.Location = new Point(309, 36);
            LNameTextBox.Name = "LNameTextBox";
            LNameTextBox.Size = new Size(215, 23);
            LNameTextBox.TabIndex = 7;
            LNameTextBox.TextChanged += LNameTextBox_TextChanged;
            // 
            // JtitleTextBox
            // 
            JtitleTextBox.Location = new Point(309, 121);
            JtitleTextBox.Name = "JtitleTextBox";
            JtitleTextBox.Size = new Size(215, 23);
            JtitleTextBox.TabIndex = 8;
            JtitleTextBox.TextChanged += JtitleTextBox_TextChanged;
            // 
            // HoursTextBox
            // 
            HoursTextBox.Location = new Point(309, 216);
            HoursTextBox.Name = "HoursTextBox";
            HoursTextBox.Size = new Size(215, 23);
            HoursTextBox.TabIndex = 9;
            HoursTextBox.TextChanged += HoursTextBox_TextChanged;
            // 
            // RateTextBox
            // 
            RateTextBox.Location = new Point(29, 217);
            RateTextBox.Name = "RateTextBox";
            RateTextBox.Size = new Size(215, 23);
            RateTextBox.TabIndex = 10;
            RateTextBox.TextChanged += RateTextBox_TextChanged;
            // 
            // DepartmentTextBox
            // 
            DepartmentTextBox.Location = new Point(29, 121);
            DepartmentTextBox.Name = "DepartmentTextBox";
            DepartmentTextBox.Size = new Size(215, 23);
            DepartmentTextBox.TabIndex = 11;
            DepartmentTextBox.TextChanged += DepartmentTextBox_TextChanged;
            // 
            // FNameTextBox
            // 
            FNameTextBox.Location = new Point(29, 36);
            FNameTextBox.Name = "FNameTextBox";
            FNameTextBox.Size = new Size(215, 23);
            FNameTextBox.TabIndex = 12;
            FNameTextBox.TextChanged += FNameTextBox_TextChanged;
            // 
            // FNameLabel
            // 
            FNameLabel.AutoSize = true;
            FNameLabel.Location = new Point(32, 336);
            FNameLabel.Name = "FNameLabel";
            FNameLabel.Size = new Size(175, 15);
            FNameLabel.TabIndex = 13;
            FNameLabel.Text = "First name:   <Insert first name>";
            FNameLabel.Click += FNameLabel_Click;
            // 
            // LNameLabel
            // 
            LNameLabel.AutoSize = true;
            LNameLabel.Location = new Point(32, 363);
            LNameLabel.Name = "LNameLabel";
            LNameLabel.Size = new Size(172, 15);
            LNameLabel.TabIndex = 14;
            LNameLabel.Text = "Last name:   <Insert last name>";
            LNameLabel.Click += LNameLabel_Click;
            // 
            // SalaryLabel
            // 
            SalaryLabel.AutoSize = true;
            SalaryLabel.Location = new Point(32, 389);
            SalaryLabel.Name = "SalaryLabel";
            SalaryLabel.Size = new Size(101, 15);
            SalaryLabel.TabIndex = 15;
            SalaryLabel.Text = "Basic Salary: 00.00";
            SalaryLabel.Click += SalaryLabel_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(870, 450);
            Controls.Add(SalaryLabel);
            Controls.Add(LNameLabel);
            Controls.Add(FNameLabel);
            Controls.Add(FNameTextBox);
            Controls.Add(DepartmentTextBox);
            Controls.Add(RateTextBox);
            Controls.Add(HoursTextBox);
            Controls.Add(JtitleTextBox);
            Controls.Add(LNameTextBox);
            Controls.Add(SalaryButton);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Button SalaryButton;
        private TextBox LNameTextBox;
        private TextBox JtitleTextBox;
        private TextBox HoursTextBox;
        private TextBox RateTextBox;
        private TextBox DepartmentTextBox;
        private TextBox FNameTextBox;
        private Label FNameLabel;
        private Label LNameLabel;
        private Label SalaryLabel;
    }
}