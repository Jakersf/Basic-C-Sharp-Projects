using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassVoid
{
    public class Math
    {
        public void DivideBy2(int num1) //Method divides a number by 2 and then writes it to the console.
        {
            int result = num1 / 2;
            Console.WriteLine(num1 + " divided by 2 = " + result);
        }

        public void Add(int num1) //Method adds 1 to a number, and writes it to the console
        {
            int result = num1 + 1;
            Console.WriteLine(num1 + " + 1 = " + result);
        }

        public void Add( out int result, int num1, int num2) //Method adds 2 numbers, then the result is passed out via the result variable
        {
            result = num1 + num2;
        }
    }
}
