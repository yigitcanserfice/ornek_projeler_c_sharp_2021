using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessTheNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            //Guess(10);

            ComputerGuess(1000);

            Console.ReadLine();
        }
        
        static void Guess(int x)
        {     
            Random rnd = new Random();
            int number = rnd.Next(1, x);
            int guess;
            int numberOfGuesses = 3;
            bool gameOver = false;

            Console.WriteLine("I am thinking of a number between 1-" + x + ". You have three guesses. Can you guess what it is?");

            while (gameOver == false)
            {
                guess = Convert.ToInt32(Console.ReadLine());
                numberOfGuesses--;
                if (guess != number && numberOfGuesses == 0)
                {
                    gameOver = true;
                    Console.WriteLine("Three guesses and you couldn't guess the correct number. YOU LOSE!!");
                }

                else if (guess < number)
                    Console.WriteLine("No, the number I am thinking of is higher than " + guess + " . Try again.");
                else if (guess > number)
                    Console.WriteLine("No, the number I am thinking of is lower than " + guess + " . Try again.");
                else
                {
                    Console.WriteLine("Well done! The answer was " + number + ". YOU WIN!");
                    gameOver = true;
                }
            }
        }
        static void ComputerGuess(int x)
        {
            
            int low = 1;
            int high = x;            
            char feedback;
            bool gameOver = false;

            Console.WriteLine("Remember a number between 1-{0}. Then computer will guess it.",x);

            while (gameOver == false)
            {
                Random rnd = new Random();
                int guess = rnd.Next(low, high);
                
                Console.WriteLine("Is {0} too high (h), too low (l) or correct (c)?? ",guess );
                feedback = Convert.ToChar(Console.ReadLine());
                if (feedback == 'h')
                    high = guess - 1;
                else if (feedback == 'l')
                    low = guess + 1;
                else if (feedback == 'c' || low == high)
                {
                    gameOver = true;
                    Console.WriteLine("Yes. The computer guessed your number, {0} correctly!",guess);
                }
                    
                
                        
                        
                    
                

                
                

            }
        }


    }
}
