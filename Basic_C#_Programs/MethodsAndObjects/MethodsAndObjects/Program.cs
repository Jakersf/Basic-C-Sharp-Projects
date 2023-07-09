using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsAndObjects
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee person = new Employee(); //Initializes the Employee method as object person
            person.FirstName = "Jacob"; //Instantiates the first and last name to the object
            person.LastName = "Farr";
            person.SayName(); //Calls the SayName() method from the superclass Person
            Console.ReadLine(); 



        }
    }
}
