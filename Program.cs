using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoConsoleLib5EC1A
{
    /// <summary>
    /// Class Program is the entry point of the console application. It demonstrates basic input/output operations, variable declarations, and conditional statements in C#.
    /// </summary>
    internal class Program
    {
        /// <summary>
        /// Main method serves as the entry point of the application. It initializes variables, prompts the user for input, and displays messages based on the user's age.
        /// </summary>
        static void Main()
        {
            int age;
            string name, dept;

            age = 36;
            name = "Viraj Daxini";
            dept = "Computer Engineering";

            Console.WriteLine("\n Hello 5EC1A Batch Students");

            Console.WriteLine("Hello " + name + " You are from " + dept + " Department " + "Your age is " + age);

            Console.WriteLine("s\n Please enter your age");

            age = Convert.ToInt32(Console.ReadLine());
                
            Console.WriteLine("\n Good afternoon {0} You are working in {1} Department and your age is {2}", name,dept ,age );

            if (age > 35)
                Console.WriteLine("You are too old");
            else
                Console.WriteLine("You are still young");

            Console.ReadKey();  
        }
    }
}
