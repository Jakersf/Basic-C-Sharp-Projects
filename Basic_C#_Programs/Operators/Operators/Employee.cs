using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operators
{
    public class Employee //Creates a public class called employee
    {
        public string FirstName { get; set; } //These 3 properties are the FirstName, LastName, and ID properties.
        public string LastName { get; set; }
        public int ID { get; set; }

        public static bool operator== (Employee employee1, Employee employee2) //Overloads the == operator and compares the first inputted employee's id and the second one's id to see if they are equal.
        {
            return employee1.ID == employee2.ID;

        }
        public static bool operator!= (Employee employee1, Employee employee2) //Overloads the == operator and compares the first inputted employee's id and the second one's id to see if they are not equal.
        {
            return employee1.ID != employee2.ID;
        }
    }

}
