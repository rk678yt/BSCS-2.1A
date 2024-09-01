using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentRegistrationApplication
{
    internal class StudentRegistrationProgram
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("STI Dasmarinas Enrollment Form");
            Console.Write("\nEnter your name: ");
            String name = Console.ReadLine();
            


            Console.WriteLine("\nWhich course are you taking?");
            Console.WriteLine("1 - BS in Computer Science\n2 - BS in Information Technology\n3 - BS in Hospitality Management\n4 - BS in Tourism Management\n5 - BS in Business Administration\n6 - Bachelor of Multimedia Arts");
            Console.Write("\nSelect your course (only type the number): ");
            int coursenum = Convert.ToInt32(Console.ReadLine());
            


            string selectedcourse = string.Empty;
            if (coursenum == 1){
                selectedcourse = "BS in Computer Science";
            }
            else if (coursenum == 2){
                selectedcourse = "BS in Information Technology";
            }
            else if (coursenum == 3){
                selectedcourse = "BS in Hospitality Management";
            }
            else if (coursenum == 4){
                selectedcourse = "BS in Tourism Management";
            }
            else if (coursenum == 5){
                selectedcourse = "BS in Business Administration";
            }
            else if (coursenum == 6){
                selectedcourse = "Bachelor of Multimedia Arts";
            }
            else{
                Console.WriteLine("Invalid input.");
            }
            Console.WriteLine("Your selected course is: " + selectedcourse);
            
            
            
            Console.Write("\nHow much is your budget? ");
            int budget = Convert.ToInt32(Console.ReadLine());



            if (budget >= 30000){
                Console.WriteLine("You have enough budget for tuition payment.");
                Console.WriteLine("\nChecking for files...");
                string directory = @"C:\Users\Gempis\Documents\C#Files";
                string[] checkfiles = { "GoodMoral.pdf", "form137.pdf", "grades.xlsx" };
                bool allfilesexist = true;


                foreach (string filename in checkfiles)
                {
                    string filepath = Path.Combine(directory, filename);
                    if (File.Exists(filepath))
                    {
                        Console.WriteLine($"File {filename} exists.");
                    }
                    else
                    {
                        Console.WriteLine($"File {filename} does not exist.");
                        allfilesexist = false;
                    }
                }


                if (allfilesexist){
                    Console.WriteLine("\nAll files exist. You can proceed with the payment inside the school.");
                    Console.WriteLine("Preparing registration papers:\n");
                    Console.WriteLine("----------------------------------------");
                    Console.WriteLine("Name of student: " + name);
                    Console.WriteLine("Course enrolled: " + selectedcourse);
                    Console.WriteLine("Enough budget: true");
                    Console.WriteLine("All files check: true");
                    Console.WriteLine("----------------------------------------");
                }
                else{
                    Console.WriteLine("Not all required files are present. Please ensure all files are available.");
                }
            }
            else {
                Console.Write("Sorry. Budget required for tuition must be at least 30,000.");
            }


        }
    }
}
