using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainMethod
{
    public class Math
    {
        public int Double(int num) // method that returns the number the method is performed on times 2
        {
            return num * 2; 
        }
        public int Add4(decimal num) // method that returns the number the method is performed on plus 4
        {
            return Convert.ToInt32(num + 4); //This method takes in a decimal and converts it to an integer
        }
        public int Subtract5(string numString) // method that returns the number the method is performed on minus 5
        {
            
            int result = Convert.ToInt32(numString) - 5; //This method converts the integer equatable string to an integer and uses it in the calculations
            return result;

        }
        

    }
}
