using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor
{
    class Program
    {
        static void Main(string[] args)
        {
            const int range = 10; //Creates a constant
            var range2 = 10; //Creates a variable using var


            Math math = new Math(range, range2); //Instantiates the class, and passing it 2 parameters to a constructor
            math.Multiplyby2(); //Void method for multiplication is called
            Console.ReadLine();

            
            
    




        }
    }
}
