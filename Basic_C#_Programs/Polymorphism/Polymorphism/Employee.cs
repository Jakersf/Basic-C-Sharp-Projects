using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    public class Employee : Person, IQuittable
    {
        public override void SayName() //Uses the inherited SayName() method, with new functionally added via the override tag
        {
            Console.WriteLine("Name: " + FirstName + " " + LastName);  
        }

        public void Quit() //inherits the Quit(Employee employee) method from the interface IQuittable
        {
            Console.WriteLine(FirstName + " " + LastName + " quits."); //Displays a message stating that the employee the method was called on quit.
        }
    }
}
