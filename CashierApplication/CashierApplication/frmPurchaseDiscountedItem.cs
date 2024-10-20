namespace CashierApplication
{
    public partial class frmPurchaseDiscountedItem : Form
    {
        public frmPurchaseDiscountedItem()
        {
            InitializeComponent();
        }

        private void ItemTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void DiscountTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void PriceTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void QuantityTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void ComputeButton_Click(object sender, EventArgs e)
        {
            string itemName = ItemTextBox.Text;
            double price = Convert.ToDouble(PriceTextBox.Text);
            double discount = Convert.ToDouble(DiscountTextBox.Text) * 0.01;
            int quantity = Convert.ToInt32(QuantityTextBox.Text);
            double paymentReceived = Convert.ToDouble(PaymentReceivedTextBox.Text);

            DiscountedItem discountedItem = new DiscountedItem(itemName, price, quantity, discount);

            double totalAmount = discountedItem.ComputeTotalAmount();
            TotalAmountLabel.Text = "Total Amount: " + totalAmount;

            double change = paymentReceived - totalAmount;
            ChangeLabel.Text = "Change: " + change;
        }

        private void TotalAmountLabel_Click(object sender, EventArgs e)
        {

        }

        private void PaymentReceivedTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {

        }

        

        private void ChangeLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
