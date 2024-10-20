using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CashierApplication
{
    public class DiscountedItem : Item
    {
        public double Discount { get; set; }

        public DiscountedItem(string name, double price, int quantity, double discount)
            : base(name, price, quantity)
        {
            Discount = discount;
        }

        public double ComputeTotalAmount()
        {
            double discountedPrice = Price - (Price * Discount);
            return discountedPrice * Quantity;
        }
    }
}
