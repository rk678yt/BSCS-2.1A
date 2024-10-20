using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeInterface
{
    internal interface IEmployee
    {
        public interface IEmployee
        {
            string FirstName { get; set; }
            string LastName { get; set; }
            string Department { get; set; }
            string JobTitle { get; set; }
            double RatePerHour { get; set; }
            double TotalHoursWorked { get; set; }
            double ComputeSalary();
        }
    }
}
