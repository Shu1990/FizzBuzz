using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FizzBuzz;

namespace ConsoleApplication1
{
    class GameConsole
    {

        private const string YesAnswer = "y";
        private const string NoAnswer = "n";
        private const string QuitCommand = "q";


        static void Main(string[] args)
        {
            Console.WriteLine("FIZZBUZZ Counting Game");
            Console.WriteLine("Would you like to play (" + YesAnswer + " or " + NoAnswer + ") ?");

            string wantsToPlayAnswer = Console.ReadLine();

            switch (wantsToPlayAnswer)
            {
                case YesAnswer:
                    PlayNewGame();
                    break;
                case NoAnswer:
                    Console.Write("Please come back and play soon");
                    break;
            }
        }

        private static void PlayNewGame()
        {
            string userInputGuess;

            var fizzBuzzTranslator = new FizzBuzzTranslator();
            var game = new FizzBuzzGame(fizzBuzzTranslator);

            bool continuePlaying = true;
            while (continuePlaying && !game.AtEndOfGame())
            {
                Console.WriteLine("Please enter the next value. Enter q at any time to quit");

                userInputGuess = Console.ReadLine();
  
                if (userInputGuess == QuitCommand)
                {
                    continuePlaying = false;
                }
                else if (game.CheckNextValue(userInputGuess))
                {
                    Console.WriteLine(userInputGuess + " is correct");
                }
                else
                {
                    Console.WriteLine("Incorrect. Please try again");
                }
            }
        }
    }
}
