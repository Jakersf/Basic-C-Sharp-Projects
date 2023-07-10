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

            int number2 = 5; //Declares 2 numbers to pass into the method
            int number1 = 4;


            Math math = new Math(); //Instantiates the method
            math.quickmaths(number1, number2); //Calls the method and passes it two numbers
            math.quickmaths(num1: 5, num2: 4); //Calls the method and specifies the parameters by name

            Console.ReadLine(); 

            
        }
    }
}
