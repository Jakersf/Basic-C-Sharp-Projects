using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DailyReport
{
    class Program
    {
        static void Main(string[] args)
        {
            //Daily Report Program
            Console.WriteLine("The Tech Academy"); 
            Console.WriteLine("Student Daily Report");
            Console.ReadLine(); //Waits until the user presses enter to display the next string.

            Console.WriteLine("What is your name?"); //Asks the user their name
            string StudentName = Console.ReadLine(); //Creates a variable for the users inputted name

            Console.WriteLine("What course are you on?"); //Asks the user the course they are currently on
            string Course = Console.ReadLine(); //Creates a variable for the course the user inputs.

            Console.WriteLine("What page number are you on in the " + Course + " course?"); ; //Asks the user for their page number
            int PageNum = Convert.ToInt32(Console.ReadLine()); //Creates an integer variable with the page number

            
            Console.WriteLine("Do you need help with anything? Please answer true or false."); //Asks the user to answer either true or false to a question
            bool Help = Convert.ToBoolean(Console.ReadLine()); //Converts the users answer to boolean (Can add a section to guarantee the user enters boolean.)

            Console.WriteLine("Were there any positive experiences you'd like to share? Please give specifics"); //Asks the users for any positive experiences they had
            string Experiences = Console.ReadLine(); //Stores their input as a string variable.

            Console.WriteLine("Is there any other feedback you'd like to provide? Please be specific."); //Asks the user for feedback
            string Feedback = Console.ReadLine(); //Stores their input as a string variable.

            Console.WriteLine("How many hours did you study today?"); //Asks the user how many hours they studied
            int HoursStudied = Convert.ToInt32(Console.ReadLine()); //Stores their input as an integer by conerting the string they input to an integer

            Console.WriteLine("Thank you for your answers. An instructor will respond to this shortly. Have a great day!"); //Ending of the program
            Console.ReadLine();
   

            
    



            
        
  


        }
    }
}
