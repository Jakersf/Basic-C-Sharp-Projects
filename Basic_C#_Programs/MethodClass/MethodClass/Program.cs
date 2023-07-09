using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodClass
{
    class Program
    {
        static void Main(string[] args)
        {

            int num1 = 5; //Declares 2 numbers to pass into the method
            int num2 = 4;


            Math math = new Math(); //Instantiates the method
            math.quickmaths(num1, num2); //Calls the method and passes it two numbers

            Console.ReadLine(); 

            
        }
    }
}
