using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasswordGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Select the security level up to 3.");
            int level = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Set password length.");
            int length = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(CreatePassword(length,level));
            Console.ReadKey();
        }
        public static string CreatePassword(int length, int level)
        {
            const string valid1 = "abcdefghijklmnopqrstuvwxyz1234567890";
            const string valid2 = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890";
            const string valid3 = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890!%&=?_£#$";
            StringBuilder res = new StringBuilder();
            Random rnd = new Random();
            while (0 < length--)
            {
                if (level ==1)
                {
                    res.Append(valid1[rnd.Next(valid1.Length)]);
                }
                else if (level == 2)
                {
                    res.Append(valid2[rnd.Next(valid2.Length)]);
                }
                else if (level == 3)
                {
                    res.Append(valid3[rnd.Next(valid3.Length)]);
                }


            }
            return res.ToString();

        }
    }
}
