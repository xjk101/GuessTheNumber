using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessTheNumberUpdate
{
    class Program
    {
        static void Main(string[] args)
        {
            long level;

            Console.WriteLine("Guess the number");
            Console.WriteLine("1 - Easy\n2 - Moderate\n3 - Hard");
            Console.Write("Type your number option and press enter: ");
            level = Convert.ToInt64(Console.ReadLine());
            Console.WriteLine();

            while(level > 3 | level < 0)
            {
                Console.WriteLine("Please read your options again. Type a number between (1) and (3): ");
                level = Convert.ToInt64(Console.ReadLine());
            }

            NewGame(level);

            Console.WriteLine("Thanks for playing.");
            Console.ReadKey();
             
        }

        static void NewGame(long difficulty)
        {
            switch (difficulty)
            {
                case 1:
                    Console.WriteLine("You chose Easy");
                    GuessIt(1, 10);
                    break;
                case 2:
                    Console.WriteLine("You chose Moderate");
                    GuessIt(1, 100);
                    break;
                case 3:
                    Console.WriteLine("You chose Hard");
                    GuessIt(1, 1000);
                    break;
            }
        }

        static void GuessIt(int min, int max)
        {
            Random rng = new Random();
            long yourguess;
            int secretnumber = rng.Next(min, max + 1);
            int tries = 1;
            Console.Write("Pick a number between {0} and {1}: ", min, max);
            yourguess = Convert.ToInt64(Console.ReadLine());

            while(yourguess != secretnumber)
            {

                tries++;
                Console.WriteLine();
                if (yourguess < min | yourguess > max)
                {
                    Console.Write("That number is out of bounds. Please choose a number between {0} and {1}: ", min, max);
                    yourguess = Convert.ToInt64(Console.ReadLine());
                }
                if (yourguess > secretnumber)
                {
                    Console.Write("Too high! Try again: ");
                    yourguess = Convert.ToInt64(Console.ReadLine());
                }
                else
                {
                    Console.Write("Too low! Try again: ");
                    yourguess = Convert.ToInt64(Console.ReadLine());
                }
            }

            Console.WriteLine("Congrats! You guessed that the correct number was {0}. It took you {1} tries.", secretnumber, tries);
            Console.WriteLine();
        }
    }
}
