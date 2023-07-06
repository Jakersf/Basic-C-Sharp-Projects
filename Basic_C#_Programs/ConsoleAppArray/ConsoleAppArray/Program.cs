using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppArray
{
    class Program
    {
        static void Main()
        {
            //One-dimensional string array section
            string[] stringArray = { "Robert", "Bobert", "Joseph", "Hubert", "Jebediah" }; //Creates a string array of made up names
            Console.WriteLine("Please select an index value of 0 - 4 to be displayed."); //Asks the user to select an index number

            int StrArrayValue = Convert.ToInt32(Console.ReadLine()); //Stores their inputted value 
            bool ArrayCheck = false;


            //Catches values that aren't in the index
            while (!ArrayCheck)// Creates a while loop that runs until a correct index is selected
            {
                switch (StrArrayValue) //Switch that has a case for each correct index, and defaults if a number that isnt 0-4 is entered.
                {
                    case 0:
                        ArrayCheck = true;
                        break;
                    case 1:
                        ArrayCheck = true;
                        break;
                    case 2:
                        ArrayCheck = true;
                        break;
                    case 3:
                        ArrayCheck = true;
                        break;
                    case 4:
                        ArrayCheck = true;
                        break;
                    default: //This default simply reruns the question with an added error message, then stores that value and reuses it to determine if the while loop should end.
                        Console.WriteLine("You selected an index that doesn't exist. Please select an index value of 0 - 4");
                        StrArrayValue = Convert.ToInt32(Console.ReadLine());
                        break;
                }
            }

            Console.WriteLine(stringArray[StrArrayValue]); //Uses the inputted value in the stringArray[] to select a name and displays it
            Console.ReadLine();



            //One-dimensional integer array section
            int[] intArray = { 3, 5, 7, 9, 11 }; //Creates a integer array 
            Console.WriteLine("Please select an index value of 0 - 4"); //Asks the user to select an index number

            int IntArrayValue = Convert.ToInt32(Console.ReadLine()); //Stores their inputted value

            //Catches values that aren't in the index
            bool ArrayCheck1 = false;

            while (!ArrayCheck1)// Creates a while loop that runs until a correct index is selected
            {
                switch(IntArrayValue) //Switch that has a case for each correct index, and defaults if a number that isnt 0-4 is entered.
                {
                    case 0:
                        ArrayCheck1 = true;
                        break;
                    case 1:
                        ArrayCheck1 = true;
                        break;
                    case 2:
                        ArrayCheck1 = true;
                        break;
                    case 3:
                        ArrayCheck1 = true;
                        break;
                    case 4:
                        ArrayCheck1 = true;
                        break;
                    default: //This default simply reruns the question with an added error message, then stores that value and reuses it to determine if the while loop should end.
                        Console.WriteLine("You selected an index that doesn't exist. Please select an index value of 0 - 4");
                        IntArrayValue = Convert.ToInt32(Console.ReadLine());
                        break;
                }
            }

            Console.WriteLine(intArray[IntArrayValue]); //Uses the inputted value in the intArray[] to select a number and displays it
            Console.ReadLine();


            //String list section

            List<string> stringList = new List<string>(); //Creates a list of strings
            stringList.Add("United States"); //Each add statement adds another string to the list.
            stringList.Add("Canada");
            stringList.Add("Russia");
            stringList.Add("Australia");

            Console.WriteLine("Please select an index value of 0 - 3"); //Asks the user to select an index from 0-3
            int stringListValue = Convert.ToInt32(Console.ReadLine()); //Stores their inputted value for further use

            //Catches values that aren't in the index
            bool ListCheck = false;

            while (!ListCheck)// Creates a while loop that runs until a correct index is selected
            {
                switch (stringListValue) //Switch that has a case for each correct index, and defaults if a number that isnt 0-3 is entered.
                {
                    case 0:
                        ListCheck = true;
                        break;
                    case 1:
                        ListCheck = true;
                        break;
                    case 2:
                        ListCheck = true;
                        break;
                    case 3:
                        ListCheck = true;
                        break;
                    default: //This default simply reruns the question with an added error message, then stores that value and reuses it to determine if the while loop should end.
                        Console.WriteLine("You selected an index that doesn't exist. Please select an index value of 0 - 3");
                        stringListValue = Convert.ToInt32(Console.ReadLine());
                        break;
                }
            }


            Console.WriteLine(stringList[stringListValue]); //Displays the inputted list value.
            Console.ReadLine();

            
        }
    }
}
