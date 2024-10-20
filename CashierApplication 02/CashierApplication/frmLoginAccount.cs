using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CashierApplication
{
    public partial class frmLoginAccount : Form
    {
        private Cashier cashier;
        public frmLoginAccount()
        {
            InitializeComponent();

            cashier = new Cashier ("Admin", "2468", "Davon Gempis", "Dasmainas");
        }

        private void UsernameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void PasswordTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            string inputUsername = UsernameTextBox.Text;
            string inputPassword = PasswordTextBox.Text;

            if (cashier.ValidateLogin(inputUsername, inputPassword))
            {
                MessageBox.Show("Welcome " + cashier.FullName + " from " + cashier.Department);

                frmPurchaseDiscountedItem purchaseForm = new frmPurchaseDiscountedItem();
                purchaseForm.Show();

                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid username or password.");
            }
        }
    }
}
