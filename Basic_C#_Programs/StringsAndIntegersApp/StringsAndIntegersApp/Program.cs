using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringsAndIntegersApp
{
    class Program
    {
        static void Main(string[] args)
        {
            

            try
            {
                List<int> numbers = new List<int>() { 5, 10, 15, 20, 35, 40, 50 }; //Creates a list of numbers

                Console.WriteLine("Please enter a number"); //Asks the user for a number
                int InputNum = Convert.ToInt32(Console.ReadLine()); //Converts the string to an integer


                for (int i = 0; i < numbers.Count; i++) //For loop to iterate through the list, displaying the result of the math equation each time.
                {
                    int Total = numbers[i] / InputNum;
                    Console.WriteLine(numbers[i] + " divided by " + InputNum + " = " + Total);

                }
            }
            catch(DivideByZeroException ex) //Catches if the user tries to divide by 0 and displays an error message.
            {
                Console.WriteLine("Please don't divide by zero");
            }
            catch(FormatException ex) //Catches if the user doesn't type a whole number and displays an error message.
            {
                Console.WriteLine("Please type a whole number");
            }
            catch(OverflowException ex) //Catches if the user types a number too large, and displays an error message.
            {
                Console.WriteLine("Number was too large, please enter a smaller number");
            }
            finally //Finally ensures that the information is always paused so the user can view it no matter what.
            {
                Console.ReadLine();
            }

            Console.WriteLine("The program has emerged from the try/catch block."); //End of the try/catch block.
            Console.ReadLine();
           
        }
    }
}
