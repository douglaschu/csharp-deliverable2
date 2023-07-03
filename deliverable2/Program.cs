using System;

public class Program
{
    public static void Main()
    {
        //Welcome message
           Console.WriteLine("Welcome to the Coin Flip Challenge, where only the strong survive.");

        //Name input
        string name = null;
        Console.Write("What is your name?\n");
        name = Console.ReadLine();

        //Greet player by name
        Console.WriteLine($"\nWelcome {name}. \nDo you dare attempt the Coin Flip Challenge? Yes/No");
        //Ask player if they want to play
        string play = null;
        play = Console.ReadLine();
        if (play == "Yes" || play == "Y" || play == "yes" || play == "y" ) {

            
            Console.WriteLine("\nThen let us begin. \nPrepare for your doom!");

            //declare variables
            int score = 0;
            string guess;
            int guessInt;
            Random rand = new Random();

            //declare variables
            
            //for loop to run game 5 times and store results
            for (int i = 0; i < 5; i++)
            {
                

                //prompt
                Console.WriteLine("Heads or Tails?");
                guess = Console.ReadLine();

                //flips coin and stores result
                int result = rand.Next(0, 2);
                                            
                //convert player guess to integer value for comparison and store in variable
                if (guess == "Heads" || guess == "heads") {
                   guessInt = 0;

                    if (result == guessInt) {
                        Console.WriteLine("Correct!");
                        //update score
                        score++;
                    } else {
                        Console.WriteLine("Incorrect.");
                    }
                }
                else if (guess == "Tails" || guess == "tails")
                {
                    guessInt = 1;
                    if (result == guessInt)
                    {
                        Console.WriteLine("Correct!");
                        score++;
                    }
                    else
                    {
                        Console.WriteLine("Incorrect.");
                    }
                }

            }
            Console.WriteLine($"\nThank you for playing, {name}. \nYou were WORTHY of the Coin Flip Challenge! \nYou guessed correctly {score} out of 5 time(s).");

        } else {

            Console.WriteLine($"\n{name}, you are a coward and unworthy of the Coin Flip Challenge.");

        }

        //There's nothing in the build saying that the program has to evaluate if the player says no.
        //Only if they agree or fail to agree.
        //Stretch goal: draft of catch statement taunting player if they answer other than yes/no and exiting program 
        /*else {

            Console.WriteLine($"\nYes or no answers only, {name}. \nCome back when you are worthy of the Coin Flip Challenge");
        }*/
    }
}

//[DONE] Stretch goal 1: case insensitive input for "play" question
//Requires hardcoding more OR statements to if/then conditionals to include lowercase. Or use of String.Equals() method. Much to consider.
//Stretch goal 2: Catch statement taunting player for poor reading comprehension if they answer other than yes/no, and exiting program 