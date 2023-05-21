using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors
{
    class Program
    {
        static void Main(string[] args)
        {
            Play();

            Console.ReadLine();
        }
        public static void Play()
        {
            int userScore = 0;
            int computerScore = 0;
            while (!(userScore==3||computerScore==3))
            {
                Console.WriteLine("'r' for rock, 'p' for paper, 's' for scissors");
                string user = Console.ReadLine();
                Random rnd = new Random();
                string[] rps = { "r", "p", "s" };
                int computer = rnd.Next(0, rps.Length);
                if (user == rps[computer])
                {
                    Console.WriteLine("Your choice = {0} \t Computer choice = {1}", user, rps[computer]);
                    
                    Console.WriteLine("Your score = {0} \t Computer Score = {1}", userScore, computerScore);
                    Console.WriteLine("-------------------------------------------");

                }
                else if (IsWin(user, rps[computer]))
                {
                    Console.WriteLine("Your choice = {0} \t Computer choice = {1}", user, rps[computer]);
                    
                    userScore++;
                    Console.WriteLine("Your score = {0} \t Computer Score = {1}",userScore,computerScore);
                    Console.WriteLine("-------------------------------------------");
                }
                else if (IsWin(rps[computer], user))
                {
                    Console.WriteLine("Your choice = {0} \t Computer choice = {1}", user, rps[computer]);
                    
                    computerScore++;
                    Console.WriteLine("Your score = {0} \t Computer Score = {1}", userScore, computerScore);
                    Console.WriteLine("-------------------------------------------");
                }

            }
            if (userScore>computerScore)
            {
                Console.WriteLine("YOU WIN!");
                Console.Clear();
            }
            else if (computerScore>userScore)
            {
                Console.WriteLine("YOU LOSE!");
                Console.Clear();
            }
            
            
            
        }
        public static bool IsWin(string player, string opponnet)
        {
            if ((player == "r" && opponnet == "s") || (player == "s" && opponnet == "p") || (player == "p" && opponnet == "r"))
            {
                return true;

            }
            else return false;

            
        }
        
    }
    
}
