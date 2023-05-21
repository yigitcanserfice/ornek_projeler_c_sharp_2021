using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace basitHesapMakinesi
{
    class Program
    {
        static void Main(string[] args)
        {
            int sayı1, sayı2;
            Console.WriteLine("1. sayıyı giriniz.");
            sayı1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Hangi işlemi yapacağınızı seçiniz.");//\n1-Toplama\n2-Çıkarma \n3-Çarpma\n4-Bölme
            string secenek = Console.ReadLine();
            Console.WriteLine("2. sayıyı giriniz.");
            sayı2 = Convert.ToInt32(Console.ReadLine());

            switch (secenek)
            {
                case "+":
                    topla(sayı1, sayı2);
                    break;
                case "-":
                    Console.WriteLine(cıkar(sayı1, sayı2));
                    break;
                case "*":
                    Console.WriteLine(carp(sayı1, sayı2));
                    break;
                case "/":
                    Console.WriteLine(bol(sayı1, sayı2));
                    break;

                default:
                    break;
            }

            //if (secenek == "+")
            //    topla(sayı1,sayı2);
            //if (secenek == "-")
            //    Console.WriteLine(çıkar(sayı1, sayı2));
            //if (secenek == "*")
            //    Console.WriteLine(çarp(sayı1, sayı2));
            //if (secenek == "/")
            //    Console.WriteLine(böl(sayı1, sayı2));

        }
        static void topla(float sayı1,float sayı2)
        {
            Console.WriteLine(sayı1+sayı2); 
        }
        static float cıkar(float sayı1, float sayı2)
        {
            return sayı1 - sayı2;
        }
        static float carp(float sayı1, float sayı2)
        {
            return sayı1 * sayı2;
        }
        static float bol(float sayı1, float sayı2)
        {
            return sayı1 / sayı2;
        }
        
    }
}
