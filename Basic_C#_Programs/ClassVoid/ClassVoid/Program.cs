using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassVoid
{
    class Program
    {
        static void Main(string[] args)
        {

            Math math = new Math(); //Instantiates the Math class

            Console.WriteLine("Please enter a number."); //Asks the user for a number
            int Input = Convert.ToInt32(Console.ReadLine()); //Converts the user's input to an integer
            Console.WriteLine("Please enter another number"); //Asks the user for a 2nd number
            int Input2 = Convert.ToInt32(Console.ReadLine()); //Converts the user's input to an integer

            int result; //Declares the integer "result" so that it can be passed out by a method once the method assigns it a new value.

            

            math.DivideBy2(Input); //Calls the DivideBy2 method on the user's first input
            math.Add(Input); //Calls the Add method on the user's first input, this method is overloaded and has 2 variants.
            Double(Input); //Calls the Double method, which is static

            

            

            math.Add(out result, Input, Input2); //Method uses an out parameter to display the results, rather than writing them itself.

            Console.WriteLine(Input + " + " + Input2 + " = " + result); //Displays the results using the acquired result from the method.

            

            

            Console.ReadLine();

            
        }

        static void Double(int num) //Static class, method displays Input * 2 in the console
        {
            int result = num * 2;
            Console.WriteLine(num + " * 2 = " + result);
           
        }
    }
}
