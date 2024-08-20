using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreetingApp
{
    internal class GreetingProgram
    {
        static void Main(string[] args)
        {
            //Inputting your information
            Console.Write("Enter your name: "); //What's your name?
            string Name = Console.ReadLine(); //Input your name in this line
            Console.Write("Enter the total number of your enrolled courses: "); //AHow many enrolled courses do you currently have?
            int EnrolledCourses = Convert.ToInt32(Console.ReadLine()); //Input your total enrolled courses
            Console.Write("Enter the price of your favorite book: "); //How much does your favorite book cost?
            int FavBookPrice = Convert.ToInt32(Console.ReadLine()); //Enter the price of your favorite book here

            //Displaying your inputted information:
            Console.WriteLine("Your name: " + Name); //Your name is what's inputted
            Console.WriteLine("Total enrolled courses: " + EnrolledCourses); //Your total courses is already inputted earlier so it's now displayed here
            Console.WriteLine("The price of your favorite book is: " + FavBookPrice); //Your favorite book must be expensive, or perhaps cheap
        }
    }
}
