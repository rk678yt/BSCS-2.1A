using EmployeeNamespace;

namespace EmployeeApplication_TP_
{
    public partial class frmComputeSalary : Form
    {
        private PartTimeEmployee employee = new PartTimeEmployee();
        public frmComputeSalary()
        {
            InitializeComponent();
        }

        private void FNameTextBox_TextChanged(object sender, EventArgs e)
        {
            employee.FirstName = FNameTextBox.Text;
        }

        private void LNameTextBox_TextChanged(object sender, EventArgs e)
        {
            employee.LastName = LNameTextBox.Text;
        }

        private void DepartmentTextBox_TextChanged(object sender, EventArgs e)
        {
            employee.Department = DepartmentTextBox.Text;
        }

        private void JtitleTextBox_TextChanged(object sender, EventArgs e)
        {
            employee.JobTitle = JtitleTextBox.Text;
        }

        private void RateTextBox_TextChanged(object sender, EventArgs e)
        {
            employee.RatePerHour = double.Parse(RateTextBox.Text);
        }

        private void HoursTextBox_TextChanged(object sender, EventArgs e)
        {
            employee.TotalHoursWorked = double.Parse(HoursTextBox.Text);
        }

        private void SalaryButton_Click(object sender, EventArgs e)
        {
            double salary = employee.ComputeSalary();
            FNameLabel.Text = "First name:   " + employee.FirstName;
            LNameLabel.Text = "Last name:   " + employee.LastName;
            SalaryLabel.Text = "Basic Salary: " + salary.ToString();
        }

        private void FNameLabel_Click(object sender, EventArgs e)
        {

        }

        private void LNameLabel_Click(object sender, EventArgs e)
        {

        }

        private void SalaryLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
