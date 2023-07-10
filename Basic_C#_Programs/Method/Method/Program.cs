using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method
{
    class Program
    {
        static void Main()
        {
            Math math = new Math(); //Instantiates the class within the program

            Console.WriteLine("Please input the first number."); //Asks the user for a number

            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please input the second number.(OPTIONAL)"); //Asks the user for an optional second number.

            string emptycheck = Console.ReadLine(); //Stores the user's input as a variable
            int num2 = 0; //Sets the default value of num2 to 0

            if (!string.IsNullOrEmpty(emptycheck)) //Checks if the user didn't input anything for the second number, and if so runs int.Parse to convert it to an integer so it doesn't throw an error.
            { //if block runs the code passing 2 parameters IF 2 parameters are entered. else, it just performs the method with 1 parameter passed.
                num2 = int.Parse(emptycheck);
                int total = math.Add5(num1, num2); //Uses the Add5 method with num1 and num2
                Console.WriteLine(num1 + " + " + num2 + " + 5 = " + total); //Displays the results
            }
            else
            {
                int total = math.Add5(num1); //Uses the add5 method with num1, since a second number was not passed.
                Console.WriteLine(num1 + " + 5 = " + total);//Displays the results
            }
            Console.ReadLine();
            

        }
    }
}
