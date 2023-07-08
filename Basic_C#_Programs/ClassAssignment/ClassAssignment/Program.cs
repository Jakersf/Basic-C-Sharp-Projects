using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number so I can do some math with it."); //Asks the user for a number

            int Input = Convert.ToInt32(Console.ReadLine()); //Converts their input to an integer and stores it

            Math math = new Math(); //Creates a new object using the Math class
            int total1 = math.Add10(Input); //Uses the method with the users input to produce results and assign them to a variable
            int total2 = math.DivideBy4(Input);
            int total3 = math.Subtract100(Input);

            Console.WriteLine(Input + " plus 10 = " + total1); //Writes out all of the results to be displayed in the console.
            Console.WriteLine(Input + " divided by 4 = " + total2);
            Console.WriteLine(Input + " minus 100 = " + total3);



            Console.ReadLine();



        }


    }
}
