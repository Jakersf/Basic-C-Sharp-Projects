using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeAssignment
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine(DateTime.Now); //Displays the current date and time in the console
            
            Console.WriteLine("Please enter a number, anywhere from 1 to 24"); //Ask the user for a number
            int Input = Convert.ToInt32(Console.ReadLine());

            DateTime Future = DateTime.Now.AddHours(Input); //Creates a Future datetime that takes the current date time, and adds the number of hours the user specified to it.
      
            Console.WriteLine(Future); //Displays the future variable to the console.
            Console.ReadLine();

        }
    }
}
