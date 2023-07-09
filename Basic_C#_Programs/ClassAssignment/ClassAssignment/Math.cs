using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassAssignment
{
    public class Math //Each class is public so that it can be accessed by the rest of the solution
    {
        //Creates 3 methods, each having their own use. 
        public int Add10(int num) //This method adds 10 to whatever number it is given
        {
            return num + 10;
        }
        public int DivideBy4(int num) //This method divides whatever number it is given by 4
        {
            return num / 4;
        }
        public int Subtract100(int num) //This method subtracts 100 from whatever number it is given
        {
            return num - 100;
        }
        
    }
}
