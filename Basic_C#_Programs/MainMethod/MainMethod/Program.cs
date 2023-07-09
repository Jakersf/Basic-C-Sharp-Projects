using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainMethod
{
    class Program
    {
        static void Main()
        {

            Math math = new Math(); 

            int num1 = 5;
            int total = math.Double(num1); //Performs the "Double" method on the variable num1

            decimal num2 = 10;
            int total2 = math.Add4(num2); //Performs the "Add4" method on the variable num2

            string num3 = "20";
            int total3 = math.Subtract5(num3); //Perfroms the "Subtract5" method on the variable num2
            
            


            Console.WriteLine(num1 + " times 2 = " + total); //Displays the results of the Double method
            Console.WriteLine(num2 + " plus 4 = " + total2); //Displays the results of the Add4 method
            Console.WriteLine(num3 + " minus 5 = " + total3); //Displays the results of the Subtract5 method
           
            Console.ReadLine();

        }
    }
}
