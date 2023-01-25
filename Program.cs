/*
 * Author: Patrick Maggio
 * Date: 1/24/23
 * Despription: This is a console application to tell what letter grade 
 * the student will get based on a numerical input
 */

using System; // calling the library
using System.Xml;

namespace ConditionalStatements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number");
            try
            {
                //set the user input to a variable for calculation
                decimal input = decimal.Parse(Console.ReadLine());

                //sort the user input into grades based on how big it is
                string output = "";
                if (input < 60)
                {
                    output = "F";
                }
                else if (input < 70)
                {
                    output = "D";

                }
                else if (input < 80)
                {
                    output = "C";

                }
                else if (input < 90)
                {
                    output = "B";

                }
                else if (input >= 90)
                {
                    output = "A";

                }
                //Display the grade cooresponding to user input
                Console.WriteLine("Your grade will be: " + output);
            }
            // Exception handling in case the user input cannot be parsed into a decimal
            catch
            {
                Console.WriteLine("Please enter a real number");
            }

        }
    }
}