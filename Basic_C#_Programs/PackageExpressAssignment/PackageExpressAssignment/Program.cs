using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PackageExpressAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Packace Express. Please follow the instructions below."); //Introduces the user to the program

            Console.WriteLine("Please enter the package weight:"); //Requests the package weight from the user
            decimal PackageWeight = Convert.ToDecimal(Console.ReadLine()); //Stores that information as a variable

            Console.WriteLine("Please enter the package width:"); //Requests the package width from the user
            decimal PackageWidth = Convert.ToDecimal(Console.ReadLine()); //Stores that information as a variable

            Console.WriteLine("Please enter the package height:"); //Requests the package height from the user
            decimal PackageHeight = Convert.ToDecimal(Console.ReadLine()); //Stores that information as a variable

            Console.WriteLine("Please enter the package length:"); //Requests the package length from the user
            decimal PackageLength = Convert.ToDecimal(Console.ReadLine()); //Stores that information as a variable

            decimal PackageArea = PackageWidth * PackageHeight * PackageLength; //This variable's value is the product of the Package Width * Height * Length
            decimal PackageCost = PackageArea * PackageWeight / 100; //This variable's value is the final value displayed to the user. It multiplies the Package Area from the above variable by the Package Weight and divides it by 100.
            

            if (PackageWidth + PackageHeight + PackageLength > 50) //Conditional statement displays the proceeding message if the total of the weight height and length is above 50.
            {
                Console.WriteLine("Package too big to be shipped via Package Express.");
                Console.ReadLine();
            }
            else //Conditional statement displays the estimated shipping cost gathered through the "PackageCost" variable.
            {
                Console.WriteLine("Your estimated total for shipping this package is:" + " $" + PackageCost);
                Console.ReadLine();
            }

        }
    }
}
