using System;

namespace BooleanComparison
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Guess a number from 1 to 5."); //Requests a number from 1 to 5
            int guess = Convert.ToInt32(Console.ReadLine()); //Stores that number as the guess var
            bool guessed = false; //Creates a boolean comparison used to execute the while statement below

            while (!guessed) //Runs the while statement until "guessed" is true.
            {
                switch (guess) //Switch statement that uses the number given to run a case.
                {
                    case 1: //This case is correct, thus sets guessed to true and ends the loop.
                        Console.WriteLine("You guessed correctly!");
                        guessed = true;
                        break;
                    case 2: //case 2 - 5 are incorrect and make the user guess again.
                        Console.WriteLine("You guessed wrong! Try again.");
                        Console.WriteLine("Guess a number from 1 to 5.");
                        guess = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 3:
                        Console.WriteLine("You guessed wrong! Try again.");
                        Console.WriteLine("Guess a number from 1 to 5.");
                        guess = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 4:
                        Console.WriteLine("You guessed wrong! Try again.");
                        Console.WriteLine("Guess a number from 1 to 5.");
                        guess = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 5:
                        Console.WriteLine("You guessed wrong! Try again.");
                        Console.WriteLine("Guess a number from 1 to 5.");
                        guess = Convert.ToInt32(Console.ReadLine());
                        break;
                    default: //If the user puts in something random that isn't 1-5 it should run this default case.
                        Console.WriteLine("Please guess a number from 1 to 5.");
                        guess = Convert.ToInt32(Console.ReadLine());
                        break;
                }
            }
            
            //Section is a very bare bones authentication program.
            Console.WriteLine("Please tell me your name."); //Requests the user's name
            string name = Console.ReadLine(); //Stores their name as a string
            bool auth = false; //Creates a boolean comparison to use for the while statement.

            do //Executes the below block of code
            {
                switch (name)
                {
                    case "Timothy": //This case is correct, and sets the auth var to true thus breaking the loop.
                        Console.WriteLine("Welcome home Timothy!");
                        auth = true;
                        break;
                    case "Bobert": //This case is also correct, and can be replicated to add more users that have authenticaiton privilidges. 
                        Console.WriteLine("Hello master Timothy's friend!");
                        auth = true;
                        break;
                    default: //This case runs if anything is inputted that isn't Timothy and re-requests their name.
                        Console.WriteLine("You're not master Timothy!");
                        Console.WriteLine("State your name once again");
                        name = Console.ReadLine();
                        break;
                }
            }
            while (!auth); //Loops the above code until the auth boolean value is true
            Console.Read();























        }
    }
}
