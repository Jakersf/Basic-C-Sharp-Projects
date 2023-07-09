using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method
{
    class Program
    {
        static void Main()
        {
           

            Console.WriteLine("Please input the first number.");

            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please input the second number.(OPTIONAL)");

            string emptycheck = Console.ReadLine();
            int num2 = 0;

            if (!string.IsNullOrEmpty(emptycheck))
            {
                num2 = int.Parse(emptycheck);
            }

            Math math = new Math();

            int total = math.Add5(num1, num2);

            Console.WriteLine(num1 + " + " + num2 + " + 5 = " + total);
            Console.ReadLine();
            

        }
    }
}
