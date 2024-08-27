using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentGradeApplication
{
    internal class frmStudentGradeProgram
    {
        public static void Main(String[] args)
        {
            Console.Write("Enter your name: ");
            String name = Console.ReadLine();

            Console.WriteLine("Grades");
            Console.Write(" English: ");
            double g1 = double.Parse(Console.ReadLine());
            Console.Write("    Math: ");
            double g2 = double.Parse(Console.ReadLine());
            Console.Write(" Science: ");
            double g3 = double.Parse(Console.ReadLine());
            Console.Write("Filipino: ");
            double g4 = double.Parse(Console.ReadLine());
            Console.Write(" History: ");
            double g5 = double.Parse(Console.ReadLine());
            double ave = (g1 + g2 + g3 + g4 + g5) / 5;

            if (ave >= 75)
            {
                Console.WriteLine("\nThe student passed.");
                Console.Write("The general average of " + name + " is " + ave + ".");
            }
            else
            {
                Console.WriteLine("\nThe student failed.");
                Console.Write("The general average of " + name + " is " + ave + ".");
            }
        }
    }
}
