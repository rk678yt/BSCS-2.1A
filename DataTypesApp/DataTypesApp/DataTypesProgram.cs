using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTypesApp
{
    internal class DataTypesProgram
    {
        public static void Main(String[] args)
        {
            Console.WriteLine("Welcome to the literal apple store!"); //Assuming you want to purchase apples (not apple products)
            Console.Write("\nEnter the name or customer: "); //What's your name?
            String customname = Console.ReadLine(); //For inputting name
            Console.Write("How many apples do you want to buy? "); //Don't worry, those apples are not THAT expensive, unlike
            int applequant = Convert.ToInt32(Console.ReadLine()); //For inputting the amount of apples you want to buy
            Console.Write("What's the total price of " + applequant + " apple(s)? "); //How much does all cost?
            double appleprice = double.Parse(Console.ReadLine()); //For inputting the total price
            int appleorigprice = Convert.ToInt32(appleprice); //Converting to whole number by rounding up or down
            Console.WriteLine("\nMaking a receipt: "); //Self explanatory
            Console.WriteLine("\n-------------------------------"); //Lines
            Console.WriteLine("Apple store Dasmarinas, Cavite"); //Imagine if there was
            Console.WriteLine("Customer name:           " + customname); //Your inputted name goes here
            Console.WriteLine("\nItem(s):"); //For display purposes only
            Console.WriteLine("\n(" + applequant + ") apple(s):               " + appleprice); //The quantity and price goes here
            Console.WriteLine("-------------------------------"); //Lines(1)
            Console.WriteLine("Total price without tax:    " + appleorigprice); //Converted price goes here
        }
        
    }
}
