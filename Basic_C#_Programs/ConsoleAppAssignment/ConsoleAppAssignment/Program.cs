using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            ////Assignment Part 1

            string[] stringArray = new string[3]; //creates an array with 3 values for text input

            int j = 0; //Uses the j variable for my while loop to set the conditions on it ending and to assign the index value where the input is stored.

            while (j <= 2)
            {
                Console.WriteLine("Please input some text"); //Asks the user for some text
                stringArray[j] = Console.ReadLine(); //Stores that text in the current index stated through the j variable
                j++; //Adds 1 to j until the loop is finished
            }

            foreach (string text in stringArray) //Foreach loop to iterate through  
            {
                Console.WriteLine(text); //Displays each index value in the array
            }
            Console.ReadLine();

            ////Assignment Part 2

            int k = 0; //uses k for the while condition
            while (k < 1)
            {
                Console.WriteLine("help me"); //
                Console.ReadLine();
                k++; //Added this line to fix it looping infinitely, without this line the loop never ends.
            }

            ////Assignment Part 3

            int u = 0; //uses u for the conditional statement 

            while (u < 5) //Repeats the while loop as long as u is less than 5
            {
                Console.WriteLine("This loop iterates on the condition that u is less than 5"); //Displays this message each time the loop repeats
                u++; //Adds 1 to the value of u
                Console.ReadLine();
            }

            int o = 0; //Very similar to the loop above this one, except the comparison made is while o is less than or equal to 3, rather than it just being less than.
            while (o <= 3)
            {
                Console.WriteLine("This loop iterates on the condition that o is less than or equal to 3");
                o++;
                Console.ReadLine();
            }

            //Assignment Part 4

            List<string> inputtext = new List<string>() { "Bobert", "Boberto", "Roberto", "Julio" }; //Creates a list of strings

            Console.WriteLine("Please input a search you would like to make through my list. (it's a name)"); //Asks the user for an input
            string InputValue = Console.ReadLine(); //Stores their input as a string for further use

            int y = 0; //y is used for the conditional in the loop.
            while (y < 1) //The conditional is basically a fake condition and the if statement is the actual condition.
            {
                if (inputtext.Contains(InputValue)) //This if statement determines if the user's input is contained within the list, then prints the index value using the .IndexOf method
                {
                    Console.WriteLine(inputtext.IndexOf(InputValue));
                    break; //Exits the loop
                }
                Console.WriteLine("Your input does not match anything in our index. Please try again."); //Asks the user to input another value
                InputValue = Console.ReadLine(); //Stores their value for reuse until they select a matching value
            }
            Console.ReadLine();

            //Assignment Part 5

            List<string> CarParts = new List<string>() { "Engine", "Wheel", "Brakes", "Engine" }; //Creates a list of car parts 

            Console.WriteLine("Please select a car part you would like to know the value of"); //Ask the user to ask for a car part that might match theirs on the list.

            string carpart = Console.ReadLine();  //Stores the users input as a variable to use as a comparison

            bool partfound = false; //Boolean variable to determine whether or not the user selected a part from the list or not

            for (int v = 0; v < CarParts.Count; v++) //Iterates through the index, running the contained code until it reaches the end.
            {
                if (CarParts[v] == carpart) //Compares the index value to the inputted value, if it is equal it runs the if statement.
                {
                    Console.WriteLine("Your part was found at the index: " + v); //Displays the part they searched for, and if it was found multiple times it will be displayed multiple times.
                    partfound = true; //Logic for if the user inputted a part from the list is set to true, meaning they inputted a correct value.
                }
            }

            if (!partfound) //If the partfound value is false, it displays an error message for the user and closes the program.
            {
                Console.WriteLine("Your part was not found in our list.");
            }

            Console.ReadLine();

            //Assignment Part 6

            List<string> FruitList = new List<string>() { "Apple", "Banana", "Pear", "Banana", "Apple", "Peach" }; //Creates a list of fruit with a few duplicates

            List<string> DuplicateFruit = new List<string>(); //This list is used to store which fruits have already been listed as a duplicate

       

            for (int f = 0; f < FruitList.Count; f++) //Iteration loop that goes until the end of the index
            {

                string CurrentFruit = FruitList[f]; //This variable tracks the current index value of the fruit
                if (DuplicateFruit.Contains(CurrentFruit)) //If statement checks if the DuplicateFruit list contains the current fruit yet
                {
                    Console.WriteLine(CurrentFruit + " - this item is a duplicate"); //If the fruit is a duplicate this line is displayed in the console
                }
                else
                {
                    Console.WriteLine(CurrentFruit + " - this item is unique"); //If the fruit is unique this line is displayed in the console
                    DuplicateFruit.Add(CurrentFruit); //Adds the current fruit to the duplicate list, and if used again is displayed as a duplicate
                }
            }

            Console.ReadLine();

        }
    }
}
