using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass
{
    public class Employee : Person
    {
        public override void SayName() //Uses the inherited SayName() method, with new functionally added via the override tag
        {
            Console.WriteLine("Name: " + FirstName + " " + LastName);
        }



    }
}
