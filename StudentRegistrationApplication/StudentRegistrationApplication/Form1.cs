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

            StringBuilder message = new StringBuilder();


            if (!string.IsNullOrWhiteSpace(fname) || !string.IsNullOrWhiteSpace(mname) || !string.IsNullOrWhiteSpace(lname))
            {
                message.Append("Student name: ");
            
                if (!string.IsNullOrWhiteSpace(fname))
                {
                    message.Append($"{fname}");
                }
                else
                {

                }

                if (!string.IsNullOrWhiteSpace(mname))
                {
                    message.Append($" {mname}");
                }

                else
                {

                }

                if (!string.IsNullOrWhiteSpace(lname))
                {
                    message.Append($" {lname}");
                }
                else
                {

                }
            }
            else {
                message.Append("");
            }

            if (!string.IsNullOrWhiteSpace(gender))
            {
                message.Append($"\nGender: {gender}");
            }
            else
            {
                message.Append("");
            }

            if (!string.IsNullOrWhiteSpace(day) || !string.IsNullOrWhiteSpace(month) || !string.IsNullOrWhiteSpace(year))
            {
                message.Append("\nDate of Birth: ");

                if (!string.IsNullOrWhiteSpace(day))
                {
                    message.Append($"{day}/");
                }

                if (!string.IsNullOrWhiteSpace(month))
                {
                    message.Append($"{month}/");
                }

                if (!string.IsNullOrWhiteSpace(year))
                {
                    message.Append($"{year}");
                }

                if (message.ToString().EndsWith("/"))
                {
                    message.Remove(message.Length - 1, 1);
                }
            }
            else
            {
                message.Append("");
            }

            if (!string.IsNullOrWhiteSpace(program))
            {
                message.Append($"\nProgram: {program}");
            }
            else
            {

            }

            MessageBox.Show(message.ToString());
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
