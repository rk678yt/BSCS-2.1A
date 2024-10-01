namespace StudentRegistrationApplication
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            BrowseButton = new Button();
            openFileDialog1 = new OpenFileDialog();
            LastNameTextbox = new TextBox();
            FirstNameTextbox = new TextBox();
            MiddleNameTextbox = new TextBox();
            label1 = new Label();
            LastName = new Label();
            FirstName = new Label();
            Middle = new Label();
            Gender = new Label();
            DayList = new ComboBox();
            MonthList = new ComboBox();
            YearList = new ComboBox();
            MaleButton = new RadioButton();
            FemaleButton = new RadioButton();
            OthersButton = new RadioButton();
            DateofBirth = new Label();
            ProgramtoApply = new Label();
            ProgramList = new ComboBox();
            RegisterStudentButton = new Button();
            StudentPictureBox = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)StudentPictureBox).BeginInit();
            SuspendLayout();
            // 
            // BrowseButton
            // 
            BrowseButton.Location = new Point(361, 254);
            BrowseButton.Name = "BrowseButton";
            BrowseButton.Size = new Size(199, 23);
            BrowseButton.TabIndex = 1;
            BrowseButton.Text = "Browse";
            BrowseButton.UseVisualStyleBackColor = true;
            BrowseButton.Click += BrowseButton_Click;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // LastNameTextbox
            // 
            LastNameTextbox.Location = new Point(12, 82);
            LastNameTextbox.Name = "LastNameTextbox";
            LastNameTextbox.Size = new Size(313, 23);
            LastNameTextbox.TabIndex = 2;
            LastNameTextbox.TextChanged += LastNameTextbox_TextChanged;
            // 
            // FirstNameTextbox
            // 
            FirstNameTextbox.Location = new Point(12, 131);
            FirstNameTextbox.Name = "FirstNameTextbox";
            FirstNameTextbox.Size = new Size(313, 23);
            FirstNameTextbox.TabIndex = 3;
            FirstNameTextbox.TextChanged += FirstNameTextbox_TextChanged;
            // 
            // MiddleNameTextbox
            // 
            MiddleNameTextbox.Location = new Point(14, 180);
            MiddleNameTextbox.Name = "MiddleNameTextbox";
            MiddleNameTextbox.Size = new Size(311, 23);
            MiddleNameTextbox.TabIndex = 4;
            MiddleNameTextbox.TextChanged += MiddleNameTextbox_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(356, 37);
            label1.TabIndex = 5;
            label1.Text = "Student Registration Form";
            label1.Click += label1_Click;
            // 
            // LastName
            // 
            LastName.AutoSize = true;
            LastName.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LastName.Location = new Point(14, 59);
            LastName.Name = "LastName";
            LastName.Size = new Size(84, 20);
            LastName.TabIndex = 6;
            LastName.Text = "Last Name";
            // 
            // FirstName
            // 
            FirstName.AutoSize = true;
            FirstName.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            FirstName.Location = new Point(12, 108);
            FirstName.Name = "FirstName";
            FirstName.Size = new Size(86, 20);
            FirstName.TabIndex = 7;
            FirstName.Text = "First Name";
            // 
            // Middle
            // 
            Middle.AutoSize = true;
            Middle.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Middle.Location = new Point(12, 157);
            Middle.Name = "Middle";
            Middle.Size = new Size(103, 20);
            Middle.TabIndex = 8;
            Middle.Text = "Middle Name";
            Middle.Click += Middle_Click;
            // 
            // Gender
            // 
            Gender.AutoSize = true;
            Gender.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Gender.Location = new Point(11, 206);
            Gender.Name = "Gender";
            Gender.Size = new Size(60, 20);
            Gender.TabIndex = 9;
            Gender.Text = "Gender";
            // 
            // DayList
            // 
            DayList.Anchor = AnchorStyles.Top;
            DayList.FormattingEnabled = true;
            DayList.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "30", "31" });
            DayList.Location = new Point(16, 254);
            DayList.Name = "DayList";
            DayList.Size = new Size(99, 23);
            DayList.TabIndex = 10;
            DayList.Text = "Day";
            DayList.SelectedIndexChanged += DayList_SelectedIndexChanged;
            // 
            // MonthList
            // 
            MonthList.Anchor = AnchorStyles.Top;
            MonthList.FormattingEnabled = true;
            MonthList.Items.AddRange(new object[] { "January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December" });
            MonthList.Location = new Point(121, 254);
            MonthList.Name = "MonthList";
            MonthList.Size = new Size(99, 23);
            MonthList.TabIndex = 11;
            MonthList.Text = "Month";
            MonthList.SelectedIndexChanged += MonthList_SelectedIndexChanged;
            // 
            // YearList
            // 
            YearList.Anchor = AnchorStyles.Top;
            YearList.FormattingEnabled = true;
            YearList.Items.AddRange(new object[] { "2024", "2023", "2022", "2021", "2020", "2019", "2018", "2017", "2016", "2015", "2014", "2013", "2012", "2011", "2010", "2009", "2008", "2007", "2006", "2005", "2004", "2003", "2002", "2001", "2000", "1999", "1998", "1997", "1996", "1995", "1994", "1993", "1992", "1991", "1990", "1989", "1988", "1987", "1986", "1985", "1984", "1983", "1982", "1981", "1980", "1979", "1978", "1977", "1976", "1975", "1974", "1973", "1972", "1971", "1970", "1969", "1968", "1967", "1966", "1965", "1964", "1963", "1962", "1961", "1960", "1959", "1958", "1957", "1956", "1955", "1954", "1953", "1952", "1951", "1950", "1949", "1948", "1947", "1946", "1945", "1944", "1943", "1942", "1941", "1940", "1939", "1938", "1937", "1936", "1935", "1934", "1933", "1932", "1931", "1930", "1929", "1928", "1927", "1926", "1925", "1924", "1923", "1922", "1921", "1920", "1919", "1918", "1917", "1916", "1915", "1914", "1913", "1912", "1911", "1910", "1909", "1908", "1907", "1906", "1905", "1904", "1903", "1902", "1901", "1900" });
            YearList.Location = new Point(226, 254);
            YearList.Name = "YearList";
            YearList.Size = new Size(99, 23);
            YearList.TabIndex = 12;
            YearList.Text = "Year";
            YearList.SelectedIndexChanged += YearList_SelectedIndexChanged;
            // 
            // MaleButton
            // 
            MaleButton.AutoSize = true;
            MaleButton.Location = new Point(77, 209);
            MaleButton.Name = "MaleButton";
            MaleButton.Size = new Size(51, 19);
            MaleButton.TabIndex = 13;
            MaleButton.TabStop = true;
            MaleButton.Text = "Male";
            MaleButton.UseVisualStyleBackColor = true;
            MaleButton.CheckedChanged += MaleButton_CheckedChanged;
            // 
            // FemaleButton
            // 
            FemaleButton.AutoSize = true;
            FemaleButton.Location = new Point(134, 209);
            FemaleButton.Name = "FemaleButton";
            FemaleButton.Size = new Size(63, 19);
            FemaleButton.TabIndex = 14;
            FemaleButton.TabStop = true;
            FemaleButton.Text = "Female";
            FemaleButton.UseVisualStyleBackColor = true;
            FemaleButton.CheckedChanged += FemaleButton_CheckedChanged;
            // 
            // OthersButton
            // 
            OthersButton.AutoSize = true;
            OthersButton.Location = new Point(203, 209);
            OthersButton.Name = "OthersButton";
            OthersButton.Size = new Size(111, 19);
            OthersButton.TabIndex = 15;
            OthersButton.TabStop = true;
            OthersButton.Text = "Prefer not to say";
            OthersButton.UseVisualStyleBackColor = true;
            OthersButton.CheckedChanged += OthersButton_CheckedChanged;
            // 
            // DateofBirth
            // 
            DateofBirth.AutoSize = true;
            DateofBirth.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            DateofBirth.Location = new Point(11, 231);
            DateofBirth.Name = "DateofBirth";
            DateofBirth.Size = new Size(103, 20);
            DateofBirth.TabIndex = 16;
            DateofBirth.Text = "Date of birth:";
            // 
            // ProgramtoApply
            // 
            ProgramtoApply.AutoSize = true;
            ProgramtoApply.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ProgramtoApply.Location = new Point(12, 280);
            ProgramtoApply.Name = "ProgramtoApply";
            ProgramtoApply.Size = new Size(135, 20);
            ProgramtoApply.TabIndex = 17;
            ProgramtoApply.Text = "Program to apply:";
            // 
            // ProgramList
            // 
            ProgramList.FormattingEnabled = true;
            ProgramList.Items.AddRange(new object[] { "Bachelor of Science in Computer Science", "Bachelor of Science in Information Technology", "Bachelor of Science in Business Administrationh", "Bachelor of Science in Accountancy", "Bachelor of Science in Management Accounting" });
            ProgramList.Location = new Point(16, 303);
            ProgramList.Name = "ProgramList";
            ProgramList.Size = new Size(309, 23);
            ProgramList.TabIndex = 18;
            ProgramList.Text = "Course";
            ProgramList.SelectedIndexChanged += ProgramList_SelectedIndexChanged;
            // 
            // RegisterStudentButton
            // 
            RegisterStudentButton.BackColor = Color.Crimson;
            RegisterStudentButton.ForeColor = SystemColors.ControlLightLight;
            RegisterStudentButton.Location = new Point(16, 332);
            RegisterStudentButton.Name = "RegisterStudentButton";
            RegisterStudentButton.Size = new Size(205, 40);
            RegisterStudentButton.TabIndex = 19;
            RegisterStudentButton.Text = "Register Student";
            RegisterStudentButton.UseVisualStyleBackColor = false;
            RegisterStudentButton.Click += RegisterStudentButton_Click;
            // 
            // StudentPictureBox
            // 
            StudentPictureBox.Location = new Point(365, 77);
            StudentPictureBox.Name = "StudentPictureBox";
            StudentPictureBox.Size = new Size(197, 151);
            StudentPictureBox.TabIndex = 20;
            StudentPictureBox.TabStop = false;
            StudentPictureBox.Click += StudentPictureBox_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(970, 620);
            Controls.Add(StudentPictureBox);
            Controls.Add(RegisterStudentButton);
            Controls.Add(ProgramList);
            Controls.Add(ProgramtoApply);
            Controls.Add(DateofBirth);
            Controls.Add(OthersButton);
            Controls.Add(FemaleButton);
            Controls.Add(MaleButton);
            Controls.Add(YearList);
            Controls.Add(MonthList);
            Controls.Add(DayList);
            Controls.Add(Gender);
            Controls.Add(Middle);
            Controls.Add(FirstName);
            Controls.Add(LastName);
            Controls.Add(label1);
            Controls.Add(MiddleNameTextbox);
            Controls.Add(FirstNameTextbox);
            Controls.Add(LastNameTextbox);
            Controls.Add(BrowseButton);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)StudentPictureBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button BrowseButton;
        private OpenFileDialog openFileDialog1;
        private TextBox LastNameTextbox;
        private TextBox FirstNameTextbox;
        private TextBox MiddleNameTextbox;
        private Label label1;
        private Label LastName;
        private Label FirstName;
        private Label Middle;
        private Label Gender;
        private ComboBox DayList;
        private ComboBox MonthList;
        private ComboBox YearList;
        private RadioButton MaleButton;
        private RadioButton FemaleButton;
        private RadioButton OthersButton;
        private Label DateofBirth;
        private Label ProgramtoApply;
        private ComboBox ProgramList;
        private Button RegisterStudentButton;
        private PictureBox StudentPictureBox;
    }
}
