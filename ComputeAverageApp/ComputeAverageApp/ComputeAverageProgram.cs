using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputeAverageApp
{
    internal class ComputeAverageProgram
    {
        public static void Main(String[] args)
        {
            //Main objective: Grade computation
            Console.Write("Enter student name: "); //Asks you to type your name
            String name = Console.ReadLine(); //Type your name here
            Console.WriteLine("\nGrade computation:"); //Nothing special, only to make the output look better
            Console.WriteLine("\nEnter all your 5 grades (per subject): "); //Asks you to type your grades below
            Console.Write("Subject 1: "); //How high/low is your grade in the first subject?
            double g1 = double.Parse(Console.ReadLine()); //Input grade here
            Console.Write("Subject 2: "); //Another one
            double g2 = double.Parse(Console.ReadLine()); //Input grade here(1)
            Console.Write("Subject 3: "); //Halfway there
            double g3 = double.Parse(Console.ReadLine()); //Input grade here(2)
            Console.Write("Subject 4: "); //Almost there
            double g4 = double.Parse(Console.ReadLine()); //Input grade here(3)
            Console.Write("Subject 5: "); //Finally, last required grade
            double g5 = double.Parse(Console.ReadLine()); //Input grade here(4)
            double gave = (g1 + g2 + g3 + g4 + g5) / 5; //For calculating average (add all grades then divide by amount of subjects)
            Console.WriteLine("Your average grade is: " + gave); //What is your final grade?
            int gaverounded = Convert.ToInt32(gave);
            Console.WriteLine("Your final grade if rounded: " + gaverounded);

            //Optional objective: if else statement for checking if you passed or failed
            if (gave >= 75) //If your final grade is at least 75
            {
                Console.WriteLine("Congrats " + name + ", you passed!"); //You cooked. You passed.
            }
            else //What about below?
            {
                Console.WriteLine("Sorry " + name + ", you failed."); //Condolences
            }
        }
    }
}
