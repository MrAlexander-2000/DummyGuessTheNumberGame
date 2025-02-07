using System;
using System.Runtime.CompilerServices;

namespace DummyGuessTheNumberGame
{
    public class Program
    {
        public static void Main()
        {
            RunGame();
        }

        private static void RunGame()
        {
            Console.WriteLine("Guess the number!!! (1 to 100)");
            Random randomNum = new Random();
            int toBeGuessed = randomNum.Next(1, 101);
            int i = 0;
            bool isValidInput = false;

            while (i != toBeGuessed)
            {
                Console.Write("Enter your guess: ");
                string input = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(input))
                {
                    Console.WriteLine("You didn't enter a number! Please try again.");
                    continue;
                }

                isValidInput = int.TryParse(input, out i);

                if (!isValidInput)
                {
                    Console.WriteLine("Ehem... you are supposed to use numbers! Please enter a valid number.");
                    continue;
                }

                if (i > 100)
                {
                    Console.WriteLine("That's over a 100, try again!");
                }

                else if (i <= 0)
                {
                    Console.WriteLine("That's 0 or lower, try again!");
                }

                if (i > toBeGuessed)
                {
                    Console.WriteLine("Too high, try again!");
                }
                
                else if (i < toBeGuessed)
                {
                    Console.WriteLine("Too low, try again!");
                }
            }

            Console.WriteLine($"Congratulations! You guessed the number {toBeGuessed}.");
            WannaPlayAgain();


        }

        private static void WannaPlayAgain()
        {
            Console.WriteLine($"Would you like to play again? (Respond with y or n)");
            string response = Console.ReadLine().ToLower();


            if (response == "y")
            {
                RunGame();
            }

            else if (response == "n")
            {
                Console.WriteLine("Thank you for playing and goodbye!");
            }

            else if (response != "y" || response != "n")
            {
                Console.WriteLine("Please respond with y or n.");
                WannaPlayAgain();
            }

        }
    }
}