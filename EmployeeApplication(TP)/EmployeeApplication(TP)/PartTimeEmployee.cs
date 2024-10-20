using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeNamespace
{
    public class PartTimeEmployee : IEmployee
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Department { get; set; }
        public string JobTitle { get; set; }
        public double RatePerHour { get; set; }
        public double TotalHoursWorked { get; set; }

        public double ComputeSalary()
        {
            return RatePerHour * TotalHoursWorked;
        }
    }
}
