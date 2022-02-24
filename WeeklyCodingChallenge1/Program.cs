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
            int output = 0;

            for (int i = 0; i < 10000; i++)
            {
                StringBuilder stringBuilder = new StringBuilder();

                for (int j = 1; stringBuilder.Length < 9; j++)
                {
                    stringBuilder.Append(i * j);
                }

                if (stringBuilder.Length == 9)
                {
                    HashSet<char> newHash = new HashSet<char>();

                    foreach (char item in stringBuilder.ToString().ToCharArray())
                        newHash.Add(item);

                    if (newHash.Count == 9 && Convert.ToInt32(stringBuilder.ToString()) > output)
                        output = Convert.ToInt32(stringBuilder.ToString());
                }
            }

            Console.WriteLine($"The largest pandigital is: {output}");
            Console.ReadKey();
        }

    }
}