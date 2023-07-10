using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass
{
    class Program
    {
        static void Main(string[] args)
        {

            Employee employee = new Employee() { FirstName = "Sample", LastName = "Student" }; //Instantiates an employee object, with the First and Last name property being Sample and Student

            employee.SayName(); //Calls the SayName() method on the employee object

            Console.ReadLine();
        }
    }
}
