namespace AdminDashboard
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            SearchButton = new Button();
            DashboardButton = new Button();
            MenuButton = new Button();
            SettingsButton = new Button();
            textBox1 = new TextBox();
            Sidebar = new FlowLayoutPanel();
            panel1 = new Panel();
            OpenMenuButton = new PictureBox();
            DashboardPanel = new Panel();
            MenuPanel = new Panel();
            AllBooksButton = new Button();
            UsersButton = new Button();
            SettingsPanel = new Panel();
            LogoutButton = new Button();
            SidebarTimer = new System.Windows.Forms.Timer(components);
            MenuTimer = new System.Windows.Forms.Timer(components);
            SettingsTimer = new System.Windows.Forms.Timer(components);
            Sidebar.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)OpenMenuButton).BeginInit();
            DashboardPanel.SuspendLayout();
            MenuPanel.SuspendLayout();
            SettingsPanel.SuspendLayout();
            SuspendLayout();
            // 
            // SearchButton
            // 
            SearchButton.BackColor = Color.FromArgb(28, 28, 28);
            SearchButton.FlatAppearance.BorderColor = Color.FromArgb(64, 64, 64);
            SearchButton.FlatStyle = FlatStyle.Flat;
            SearchButton.ForeColor = Color.White;
            SearchButton.Location = new Point(818, 106);
            SearchButton.Name = "SearchButton";
            SearchButton.Size = new Size(261, 77);
            SearchButton.TabIndex = 1;
            SearchButton.Text = "Search";
            SearchButton.UseVisualStyleBackColor = false;
            SearchButton.Click += SearchButton_Click;
            // 
            // DashboardButton
            // 
            DashboardButton.BackColor = Color.FromArgb(28, 28, 28);
            DashboardButton.FlatAppearance.BorderColor = Color.FromArgb(64, 64, 64);
            DashboardButton.FlatAppearance.BorderSize = 0;
            DashboardButton.FlatStyle = FlatStyle.Flat;
            DashboardButton.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            DashboardButton.ForeColor = Color.White;
            DashboardButton.Image = (Image)resources.GetObject("DashboardButton.Image");
            DashboardButton.ImageAlign = ContentAlignment.MiddleLeft;
            DashboardButton.Location = new Point(0, 3);
            DashboardButton.Name = "DashboardButton";
            DashboardButton.Size = new Size(197, 46);
            DashboardButton.TabIndex = 2;
            DashboardButton.Text = "           Dashboard";
            DashboardButton.TextAlign = ContentAlignment.MiddleLeft;
            DashboardButton.UseVisualStyleBackColor = false;
            DashboardButton.Click += DashboardButton_Click;
            // 
            // MenuButton
            // 
            MenuButton.BackColor = Color.FromArgb(28, 28, 28);
            MenuButton.FlatAppearance.BorderColor = Color.FromArgb(64, 64, 64);
            MenuButton.FlatAppearance.BorderSize = 0;
            MenuButton.FlatStyle = FlatStyle.Flat;
            MenuButton.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            MenuButton.ForeColor = Color.White;
            MenuButton.Image = (Image)resources.GetObject("MenuButton.Image");
            MenuButton.ImageAlign = ContentAlignment.MiddleLeft;
            MenuButton.Location = new Point(0, 3);
            MenuButton.Name = "MenuButton";
            MenuButton.Size = new Size(197, 43);
            MenuButton.TabIndex = 3;
            MenuButton.Text = "           Home";
            MenuButton.TextAlign = ContentAlignment.MiddleLeft;
            MenuButton.UseVisualStyleBackColor = false;
            MenuButton.Click += MenuButton_Click;
            // 
            // SettingsButton
            // 
            SettingsButton.BackColor = Color.FromArgb(28, 28, 28);
            SettingsButton.FlatAppearance.BorderColor = Color.FromArgb(64, 64, 64);
            SettingsButton.FlatAppearance.BorderSize = 0;
            SettingsButton.FlatStyle = FlatStyle.Flat;
            SettingsButton.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            SettingsButton.ForeColor = Color.White;
            SettingsButton.Image = (Image)resources.GetObject("SettingsButton.Image");
            SettingsButton.ImageAlign = ContentAlignment.MiddleLeft;
            SettingsButton.Location = new Point(0, 3);
            SettingsButton.Name = "SettingsButton";
            SettingsButton.Size = new Size(197, 43);
            SettingsButton.TabIndex = 4;
            SettingsButton.Text = "           Settings";
            SettingsButton.TextAlign = ContentAlignment.MiddleLeft;
            SettingsButton.UseVisualStyleBackColor = false;
            SettingsButton.Click += SettingsButton_Click;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.FromArgb(30, 30, 30);
            textBox1.Font = new Font("Cascadia Code SemiLight", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.ForeColor = SystemColors.Info;
            textBox1.Location = new Point(688, 61);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Add book title, author, ...";
            textBox1.Size = new Size(518, 39);
            textBox1.TabIndex = 5;
            // 
            // Sidebar
            // 
            Sidebar.BackColor = Color.FromArgb(28, 28, 28);
            Sidebar.Controls.Add(panel1);
            Sidebar.Controls.Add(DashboardPanel);
            Sidebar.Controls.Add(MenuPanel);
            Sidebar.Controls.Add(SettingsPanel);
            Sidebar.Dock = DockStyle.Left;
            Sidebar.Location = new Point(0, 0);
            Sidebar.MaximumSize = new Size(200, 1080);
            Sidebar.MinimumSize = new Size(50, 1080);
            Sidebar.Name = "Sidebar";
            Sidebar.Size = new Size(50, 1080);
            Sidebar.TabIndex = 6;
            Sidebar.Paint += Sidebar_Paint;
            // 
            // panel1
            // 
            panel1.Controls.Add(OpenMenuButton);
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(197, 97);
            panel1.TabIndex = 7;
            // 
            // OpenMenuButton
            // 
            OpenMenuButton.Image = (Image)resources.GetObject("OpenMenuButton.Image");
            OpenMenuButton.Location = new Point(0, 23);
            OpenMenuButton.Name = "OpenMenuButton";
            OpenMenuButton.Size = new Size(40, 40);
            OpenMenuButton.TabIndex = 7;
            OpenMenuButton.TabStop = false;
            OpenMenuButton.Click += OpenMenuButton_Click;
            // 
            // DashboardPanel
            // 
            DashboardPanel.Controls.Add(DashboardButton);
            DashboardPanel.Location = new Point(3, 106);
            DashboardPanel.Name = "DashboardPanel";
            DashboardPanel.Size = new Size(200, 52);
            DashboardPanel.TabIndex = 8;
            // 
            // MenuPanel
            // 
            MenuPanel.Controls.Add(MenuButton);
            MenuPanel.Controls.Add(AllBooksButton);
            MenuPanel.Controls.Add(UsersButton);
            MenuPanel.Location = new Point(3, 164);
            MenuPanel.MaximumSize = new Size(200, 105);
            MenuPanel.MinimumSize = new Size(200, 52);
            MenuPanel.Name = "MenuPanel";
            MenuPanel.Size = new Size(200, 52);
            MenuPanel.TabIndex = 8;
            // 
            // AllBooksButton
            // 
            AllBooksButton.BackColor = Color.FromArgb(28, 28, 28);
            AllBooksButton.FlatAppearance.BorderColor = Color.FromArgb(64, 64, 64);
            AllBooksButton.FlatAppearance.BorderSize = 0;
            AllBooksButton.FlatStyle = FlatStyle.Flat;
            AllBooksButton.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            AllBooksButton.ForeColor = Color.White;
            AllBooksButton.Image = (Image)resources.GetObject("AllBooksButton.Image");
            AllBooksButton.ImageAlign = ContentAlignment.MiddleLeft;
            AllBooksButton.Location = new Point(43, 80);
            AllBooksButton.Name = "AllBooksButton";
            AllBooksButton.Size = new Size(154, 22);
            AllBooksButton.TabIndex = 9;
            AllBooksButton.Text = "       All books";
            AllBooksButton.TextAlign = ContentAlignment.MiddleLeft;
            AllBooksButton.UseVisualStyleBackColor = false;
            AllBooksButton.Click += AllBooksButton_Click;
            // 
            // UsersButton
            // 
            UsersButton.BackColor = Color.FromArgb(28, 28, 28);
            UsersButton.FlatAppearance.BorderColor = Color.FromArgb(64, 64, 64);
            UsersButton.FlatAppearance.BorderSize = 0;
            UsersButton.FlatStyle = FlatStyle.Flat;
            UsersButton.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            UsersButton.ForeColor = Color.White;
            UsersButton.Image = (Image)resources.GetObject("UsersButton.Image");
            UsersButton.ImageAlign = ContentAlignment.MiddleLeft;
            UsersButton.Location = new Point(43, 52);
            UsersButton.Name = "UsersButton";
            UsersButton.Size = new Size(154, 22);
            UsersButton.TabIndex = 10;
            UsersButton.Text = "       Users";
            UsersButton.TextAlign = ContentAlignment.MiddleLeft;
            UsersButton.UseVisualStyleBackColor = false;
            UsersButton.Click += UsersButton_Click;
            // 
            // SettingsPanel
            // 
            SettingsPanel.Controls.Add(LogoutButton);
            SettingsPanel.Controls.Add(SettingsButton);
            SettingsPanel.Location = new Point(3, 222);
            SettingsPanel.MaximumSize = new Size(200, 77);
            SettingsPanel.MinimumSize = new Size(200, 52);
            SettingsPanel.Name = "SettingsPanel";
            SettingsPanel.Size = new Size(200, 52);
            SettingsPanel.TabIndex = 8;
            // 
            // LogoutButton
            // 
            LogoutButton.BackColor = Color.FromArgb(28, 28, 28);
            LogoutButton.FlatAppearance.BorderColor = Color.FromArgb(64, 64, 64);
            LogoutButton.FlatAppearance.BorderSize = 0;
            LogoutButton.FlatStyle = FlatStyle.Flat;
            LogoutButton.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LogoutButton.ForeColor = Color.White;
            LogoutButton.Image = (Image)resources.GetObject("LogoutButton.Image");
            LogoutButton.ImageAlign = ContentAlignment.MiddleLeft;
            LogoutButton.Location = new Point(43, 52);
            LogoutButton.Name = "LogoutButton";
            LogoutButton.Size = new Size(154, 22);
            LogoutButton.TabIndex = 11;
            LogoutButton.Text = "       Logout";
            LogoutButton.TextAlign = ContentAlignment.MiddleLeft;
            LogoutButton.UseVisualStyleBackColor = false;
            LogoutButton.Click += LogoutButton_Click;
            // 
            // SidebarTimer
            // 
            SidebarTimer.Interval = 25;
            SidebarTimer.Tick += SidebarTimer_Tick;
            // 
            // MenuTimer
            // 
            MenuTimer.Interval = 25;
            MenuTimer.Tick += MenuTimer_Tick;
            // 
            // SettingsTimer
            // 
            SettingsTimer.Interval = 25;
            SettingsTimer.Tick += SettingsTimer_Tick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(45, 45, 48);
            ClientSize = new Size(1494, 887);
            Controls.Add(Sidebar);
            Controls.Add(textBox1);
            Controls.Add(SearchButton);
            MaximumSize = new Size(1920, 1080);
            Name = "Form1";
            Text = "Form1";
            Sidebar.ResumeLayout(false);
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)OpenMenuButton).EndInit();
            DashboardPanel.ResumeLayout(false);
            MenuPanel.ResumeLayout(false);
            SettingsPanel.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button SearchButton;
        private Button DashboardButton;
        private Button MenuButton;
        private Button SettingsButton;
        private TextBox textBox1;
        private FlowLayoutPanel Sidebar;
        private Panel panel1;
        private Panel DashboardPanel;
        private Panel MenuPanel;
        private Panel SettingsPanel;
        private System.Windows.Forms.Timer SidebarTimer;
        private PictureBox OpenMenuButton;
        private System.Windows.Forms.Timer MenuTimer;
        private System.Windows.Forms.Timer SettingsTimer;
        private Button AllBooksButton;
        private Button UsersButton;
        private Button LogoutButton;
    }
}
