using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParsingEnums
{
    class Program
    {
        static void Main(string[] args)
        {
            try 
            {
                Console.WriteLine("Please enter the current day of the week"); //Asks the user to enter a day of the week

                DaysOfTheWeek Input = (DaysOfTheWeek)Enum.Parse(typeof(DaysOfTheWeek), Console.ReadLine()); //Creates a variable named input, then uses Enum.Parse to convert the user's input to the Enum DaysOfTheWeek data type
                
                Console.WriteLine(Input); //Writes the inputted day of the week
            }

            catch (ArgumentException) //Catch blocks catch errors that commonly occur due to user error
            {
                Console.WriteLine("Please enter an actual day of the week.");
            }
            catch (OverflowException)
            {
                Console.WriteLine("Please enter an actual day of the week.");
            }
            finally
            {
                Console.ReadLine();
            }
        }



        public enum DaysOfTheWeek //Creates an Enum called DaysOfTheWeek and assigns it a value equivalent to each day of the week.
        {
            Sunday,
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday
        }
    }
}
