using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor
{
    public class Math
    {
        public int num1;
        public int num2;
        private int result;

        public Math(int num1, int num2) : this(num1) 
        {
            this.num2 = num2; //Calls the constructor and makes it equal itself
        }

        public Math(int num1) 
        {
            this.num1 = num1; //Calls the constructor and makes it equal itself
        }
        public void Multiplyby2() //Calls the two constructors to use in this method
        {
            result = num1 * num2;
            Console.WriteLine(result);
        }
    }
}
