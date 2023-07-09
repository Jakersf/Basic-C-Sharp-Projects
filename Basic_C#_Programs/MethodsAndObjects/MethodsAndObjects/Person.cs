using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsAndObjects
{
    public class Person
    {
        public string FirstName { get; set; } //Creates two properties, first and last name with the data type string
        public string LastName  { get; set; }

        public void SayName() //Method that displays the first and last name properties
        {
            Console.WriteLine("Name: " + FirstName + " " + LastName);
        }
    }
}
