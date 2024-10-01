using System.Text;

namespace StudentRegistrationApplication
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Middle_Click(object sender, EventArgs e)
        {

        }

        private void LastNameTextbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void FirstNameTextbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void MiddleNameTextbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void MaleButton_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void FemaleButton_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void OthersButton_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void DayList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void MonthList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void YearList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ProgramList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void StudentPictureBox_Click(object sender, EventArgs e)
        {

        }

        private void BrowseButton_Click(object sender, EventArgs e)
        {

        }

        private void RegisterStudentButton_Click(object sender, EventArgs e)
        {
            string lname = LastNameTextbox.Text;
            string fname = FirstNameTextbox.Text;
            string mname = MiddleNameTextbox.Text;
            string gender = MaleButton.Checked ? "Male" : FemaleButton.Checked ? "Female" : OthersButton.Checked ? "Others" : "";
            string day = DayList.SelectedItem?.ToString();
            string month = MonthList.SelectedItem?.ToString();
            string year = YearList.SelectedItem?.ToString();
            string program = ProgramList.SelectedItem?.ToString();

                MessageBox.Show($"Student name: {fname} {mname} {lname}\nGender: {gender}\nDate of birth: {day}/{month}/{year}\nProgram: {program}");
                ClearInputFields();
        }
        private void ClearInputFields()
        {
            LastNameTextbox.Text = string.Empty;
            FirstNameTextbox.Text = string.Empty;
            MiddleNameTextbox.Text= string.Empty;
            MaleButton.Checked = false;
            FemaleButton.Checked = false;
            OthersButton.Checked = false;
            DayList.SelectedIndex = -1;
            MonthList.SelectedIndex = -1;
            YearList.SelectedIndex = -1;
            ProgramList.SelectedIndex = -1;
        }
    }
}
