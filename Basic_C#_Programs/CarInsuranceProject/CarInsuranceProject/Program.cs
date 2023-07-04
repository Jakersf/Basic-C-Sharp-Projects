using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarInsuranceProject
{
    class Program
    {
        static void Main(string[] args)
        {   
            //Section collects the user's age
            Console.WriteLine("What is your age?"); //Asks the user their age
            string Age = Console.ReadLine(); //Stores the user's age as a string
            //int AgeNum = Convert.ToInt32(Age);
            bool AgeCheck = Convert.ToInt32(Age) > 15; //Compares the users age to the requirement.

            //Section determines if the user has a DUI or not
            Console.WriteLine("Have you ever had a DUI? (Please answer true or false)"); //Asks the user if they have a DUI
            string DUI = Console.ReadLine(); //Stores the user's answer as a string
            bool DUICheck = !Convert.ToBoolean(DUI); //Declares the boolean status of this variable as the opposite of whatever the user answers
            
            //Section determines how many speeding tickets the user has
            Console.WriteLine("How many speeding tickets do you have?"); //Asks the user how many speeding tickets they have
            string Speeding = Console.ReadLine(); //Stores the number of tickets the user has in string form
            bool SpeedCheck = Convert.ToInt32(Speeding) <= 3; //Compares that string after it is convert to an integer to the requirement

            //Section takes the above 3 sections and makes a comparison to determine if the user is qualified
            bool Qualified = (SpeedCheck && DUICheck && AgeCheck); //Creates a variable that checks if all of the above sections registered as "true"
            Console.WriteLine("Qualified?");
            Console.WriteLine(Qualified); //Displays the result of the above variable
            Console.ReadLine();
        }
    }
}
