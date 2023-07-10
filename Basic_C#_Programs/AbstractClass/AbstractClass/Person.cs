using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass
{
    public abstract class Person
    {
        public string FirstName { get; set; }  //Creates a first and last name property 
        public string LastName { get; set; }
        public virtual void SayName() //Creates a virtual method to be inherited by child classes
        {

        }
    }
}
