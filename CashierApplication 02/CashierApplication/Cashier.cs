using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CashierApplication
{
    public class Cashier : UserAccount
    {
        public Cashier(string username, string password, string fullName, string department)
            : base(username, password, fullName, department)
        {
        }
    }
}
