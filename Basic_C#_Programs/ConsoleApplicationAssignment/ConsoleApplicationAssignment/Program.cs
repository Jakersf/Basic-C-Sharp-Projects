using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplicationAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please input a random number"); //Requests a random number from the user
            string num1 = Console.ReadLine(); //stores the users input as a string
            int total = Convert.ToInt32(num1) * 50; //The string variable is converted to and integer, then multiplied by 50.
            Console.WriteLine(num1 + " multiplied by 50 is: " + total); //Displays the num1 variable multiplied by 50 to the user via the console.
            Console.ReadLine();

            Console.WriteLine("Please input a random number"); //Requests a random number from the user
            string num2 = Console.ReadLine(); // stores the users input as a string
            int total2 = Convert.ToInt32(num2) + 25; //Converts the string to an integer and adds 25 to it
            Console.WriteLine(num2 + " plus 25 is: " + total2); //Displays the inputted number + 25 to the user.
            Console.ReadLine();

            Console.WriteLine("Please input a random number"); //Requests a random number from the user
            string num3 = Console.ReadLine(); //stores the users input as a string
            double total3 = Convert.ToInt32(num3) / 12.5; //The string variable is converted to an integer then divided by 12.5
            Console.WriteLine(num3 + " divided by 12.5 is: " + total3); //Displays the result of the above line.
            Console.ReadLine();

            Console.WriteLine("Please input a random number to see whether it is greater(true) or lesser(false) than 50."); //Requests a random number from the user
            string num4 = Console.ReadLine(); //stores the users input as a string
            bool total4 = Convert.ToInt32(num4) > 50; //Compares the inputted number to 50
            Console.WriteLine(total4); //Prints the result of the above line
            Console.ReadLine();

            Console.WriteLine("Please input a random number that you would like to see the remainder of if divided by 7."); //Requests a random number from the user
            string num5 = Console.ReadLine(); //stores the users input as a string
            int total5 = Convert.ToInt32(num5) % 7; //Uses the modulus operator on the value given by the user
            Console.WriteLine("The remainder of " + num5 + " divided by 7 is " + total5); //Displays the users input % 7
            Console.ReadLine();
        }
    }
}
