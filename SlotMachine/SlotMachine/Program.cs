using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SlotMachine
{
    class Program
    {
        static void Main(string[] args)
        {
            Slot();

        }
        static void Slot()
        {
            Random rnd = new Random();
            int score = 10;
            Console.WriteLine("Your score = " + score);
            Console.WriteLine("Press any key to start!");
            string answer1 = Console.ReadLine();

            Console.WriteLine("Press n when you want to quit the game.");
            
            while (!(score==0))
            {
                
                int[] slots = new int[9];
                for (int i = 0; i < slots.Length; i++)
                {
                    slots[i] = rnd.Next(1, 10);

                }
                Console.WriteLine("\n");
                Console.WriteLine(" | " + slots[0] + " | " + slots[1] + " | " + slots[2] + " | ");
                
                Console.Write("\n");
                Console.WriteLine(" | " + slots[3] + " | " + slots[4] + " | " + slots[5] + " | ");
                Console.Write("\n");

                Console.WriteLine(" | " + slots[6] + " | " + slots[7] + " | " + slots[8] + " | ");
                Console.WriteLine("\n");

                if (slots[3] == slots[4] && slots[4] == slots[5])
                {
                    score += 4;
                    Console.WriteLine("Score = " +score );
                }
                else if(slots[3] == slots[4] || slots[4] == slots[5] || slots[3] == slots[5])
                {
                    score += 2;
                    Console.WriteLine("Score = " + score);
                }
                else
                {
                    score -= 1;
                    Console.WriteLine("Score = " + score);
                }
                string answer2 = Console.ReadLine();
                Console.Clear();
                if (answer2 == "n")
                {
                    score = 0;
                }

            }
            

        }
    }
}
