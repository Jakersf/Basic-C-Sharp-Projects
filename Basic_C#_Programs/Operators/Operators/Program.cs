using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operators
{
    class Program
    {
        static void Main()
        {
            Employee employee1 = new Employee() { FirstName = "John", LastName = "Doe", ID = 1 }; //Creates 2 employee objects using the employee class.
            Employee employee2 = new Employee() { FirstName = "John", LastName = "Smith", ID = 2 };

            Console.WriteLine(employee1 == employee2); //Uses the overloaded == operator to compare employee1 and employee2, then writes the result to the console.
            Console.ReadLine();
           
        }
    }
}
