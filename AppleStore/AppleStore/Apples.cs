using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppleStore
{
    internal class Apples
    {
        public static void Main(String[] args)
        {
            Console.WriteLine("Welcome back to the literal apple store!"); //Buy apples again?
            Console.Write("\nEnter your name: "); //What's your name?
            String name = Console.ReadLine(); //Input name here
            Console.WriteLine("The price per apple is now 32.5 pesos."); //Inflation is real
            Console.Write("How many apples do you want to buy? "); //You either ant to buy a single apple or be a guy from a math question
            int quant = Convert.ToInt32(Console.ReadLine()); //Input how many apples you want to purchase each
            double price = 32.5; //The price per apple
            double totalprice = price * quant; //Calculating the original price
            Console.WriteLine("The total price of (" + quant + ") apple(s) are: " + totalprice); //Shows the total price
            double convertedprice = Math.Round(totalprice);//Converting to whole number by rounding up or down
            Console.WriteLine("The converted price is: " + convertedprice); //Conversion is shown here
            Console.WriteLine("\nMaking a receipt: "); //Self explanatory
            Console.WriteLine("\n-------------------------------"); //Lines
            Console.WriteLine("Apple store Dasmarinas, Cavite"); //Fictional area
            Console.WriteLine("Customer name:           " + name); //Name shown here
            Console.WriteLine("\nItem(s):"); //Formatting purposes
            Console.WriteLine("\n(" + quant + ") apple(s):               " + totalprice); //Just like what's shown earlier
            Console.WriteLine("-------------------------------"); //Lines(1)
            Console.WriteLine("Total price without tax:    " + convertedprice); //Also, what's basically shown earlier
        }
    }
}
