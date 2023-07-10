using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parameters
{
    class Program
    {
        static void Main(string[] args)
        {

            Employee<string> employee = new Employee<string>() { FirstName = "Jacob", LastName = "Farr", ID = 1 }; //First employee object, assigned some basic data
            employee.Things = new List<string>() { "Thing 1", "Thing 2" }; //Instantiates the Things property with the string data type

            foreach (string thing in employee.Things) //foreach loop that prints each item in Things to the console.
            {
                Console.WriteLine(thing);
            }
            
            Employee<int> employee2 = new Employee<int>() { FirstName = "Bobert", LastName = "Jones", ID = 2 }; //Second employee object, assigned some basic data
            employee2.Things = new List<int>() { 1, 2, 3 }; //Instantiates the Things property with an integer data type

            foreach (int thing in employee2.Things) //foreach loop that prints each item in Things to the console
            {
                Console.WriteLine(thing);
            }

            Console.ReadLine();

           




        }
    }
}
