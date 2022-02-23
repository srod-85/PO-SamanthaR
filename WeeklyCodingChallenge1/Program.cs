using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace weeklyCodingChallenge1
{
    class Program
    {
        public static void Main(string[] args)
        {
            string? str1 = "";
            int input = 0;
            int output = 0;
            Console.WriteLine("Enter a number between 1 and 9");
            do
            {
                str1 = Console.ReadLine();
                try
                {
                    input = int.Parse(str1);
                }
                catch(Exception)
                {
                    Console.WriteLine("Please enter a valid integer");
                }
                if(input < 1 || input > 9)
                {
                    Console.WriteLine("That number is out of range. Please enter a number between 1 and 9");
                }

            } while (str1 != null);
        }

    }
}