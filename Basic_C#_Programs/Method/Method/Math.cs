using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method
{
    class Math
    {
        public int Add5(int num1, int num2 = 0) //Creates a method within the Math class for adding 5 to the inputted numbers, giving num2 a default value as well.
        {
            return num1 + num2 + 5;
        }

    }
}
