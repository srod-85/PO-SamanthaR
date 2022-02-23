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
            Console.WriteLine("Enter a 9-digit integer.");
            do
            {
                str1 = Console.ReadLine();
                try
                {
                    input = int.Parse(str1);
                    
                }
                catch(Exception)
                {
                    
                    Console.Write("That is not an integer. ");
                }
                         

            } while (output == 0);
            Console.WriteLine("outside of the do-while loop");
        }

        public static int PandigitalOutput(int c)
        {

            return 0;
        }

    }
}