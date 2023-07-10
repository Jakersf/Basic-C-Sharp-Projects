using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    class Program
    {
        static void Main(string[] args)
        {
            IQuittable employee = new Employee() { FirstName = "Sample", LastName = "Student" }; //Instantiates an object of the type IQuittable, which demonstrates polymorphism.
            employee.Quit(); //Executes the method Quit() which has displays that the employee who the method was called on quit.
            Console.ReadLine();
    }
    }
}
