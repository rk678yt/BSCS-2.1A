namespace AdminDashboard
{
    public partial class Form1 : Form
    {
        bool SidebarExpand;
        bool MenuButtonExpand;
        bool SettingsButtonExpand;

        
        public Form1()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;
            this.TopMost = false;
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {

        }

        private void DashboardButton_Click(object sender, EventArgs e)
        {

        }

        private void MenuButton_Click(object sender, EventArgs e)
        {
            MenuTimer.Start();
        }

        private void SettingsButton_Click(object sender, EventArgs e)
        {
            SettingsTimer.Start();
        }

        private void SidebarTimer_Tick(object sender, EventArgs e)
        {
            if (SidebarExpand)
            {
                Sidebar.Width -= 10;
                if (Sidebar.Width == Sidebar.MinimumSize.Width)
                {
                    SidebarExpand = false;
                    SidebarTimer.Stop();
                }
            }

            else
            {
                Sidebar.Width += 10;
                if (Sidebar.Width == Sidebar.MaximumSize.Width)
                {
                    SidebarExpand = true;
                    SidebarTimer.Stop();
                }
            }
        }

        private void OpenMenuButton_Click(object sender, EventArgs e)
        {
            SidebarTimer.Start();
        }

        private void MenuPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void DashboardPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void SettingsPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void MenuTimer_Tick(object sender, EventArgs e)
        {
            if (MenuButtonExpand)
            {
                MenuPanel.Height += 10;
                if (MenuPanel.Height == MenuPanel.MaximumSize.Height)
                {
                    MenuButtonExpand = false;
                    MenuTimer.Stop();
                }
            }
            else
            {
                MenuPanel.Height -= 10;
                if (MenuPanel.Height == MenuPanel.MinimumSize.Height)
                {
                    MenuButtonExpand = true;
                    MenuTimer.Stop();
                }
            }
        }

        private void SettingsTimer_Tick(object sender, EventArgs e)
        {
            if (SettingsButtonExpand)
            {
                SettingsPanel.Height += 10;
                if (SettingsPanel.Height == SettingsPanel.MaximumSize.Height)
                {
                    SettingsButtonExpand = false;
                    SettingsTimer.Stop();
                }
            }
            else
            {
                SettingsPanel.Height -= 10;
                if (SettingsPanel.Height == SettingsPanel.MinimumSize.Height)
                {
                    SettingsButtonExpand = true;
                    SettingsTimer.Stop();
                }
            }
        }

        private void AllBooksButton_Click(object sender, EventArgs e)
        {

        }

        private void UsersButton_Click(object sender, EventArgs e)
        {

        }

        private void LogoutButton_Click(object sender, EventArgs e)
        {

        }

        private void Sidebar_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
