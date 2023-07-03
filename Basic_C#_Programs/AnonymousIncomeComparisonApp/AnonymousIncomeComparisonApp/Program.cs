using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnonymousIncomeComparisonApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Anonymous Income Comparison Program");
            Console.WriteLine("Person 1's hourly rate:"); //Requests person 1's hourly rate
            string hourlyRate1 = Console.ReadLine(); //creates a variable using the inputted value
            Console.WriteLine("Person 1's hours per week"); //Requests person 1's hours worked per week
            string hoursWorked1 = Console.ReadLine(); //creates a variable using the inputted value
            Console.WriteLine("Person 2's hourly rate:"); //Requests person 2's hourly rate
            string hourlyRate2 = Console.ReadLine(); //creates a variable using the inputted value
            Console.WriteLine("Person 2's hours per week"); //Requests person 2's hours worked per week
            string hoursWorked2 = Console.ReadLine(); //creates a variable using the inputted value
            decimal Salary1 = Convert.ToDecimal(hourlyRate1) * Convert.ToDecimal(hoursWorked1) * 52; //Multiplies person 1's hours worked by their hourly rate then multiplies that by 52 to get their salary.
            decimal Salary2 = Convert.ToDecimal(hourlyRate2) * Convert.ToDecimal(hoursWorked2) * 52; //Exactly the same as the above line but for person 2.
            bool SalaryComparison = Salary1 > Salary2; //Compares Salary1 and Salary2
            Console.WriteLine("Annual Salary of Person 1:"); 
            Console.WriteLine(Salary1); //Displays Person 1's Salary
            Console.WriteLine("Annual Salary of Person 2:");
            Console.WriteLine(Salary2); //Displays Person 2's Salary
            Console.WriteLine("Does Person 1 make more than Person 2?");
            Console.WriteLine(SalaryComparison.ToString()); //Displays the comparison between the two salaries.
            Console.ReadLine();



        }
    }
}
