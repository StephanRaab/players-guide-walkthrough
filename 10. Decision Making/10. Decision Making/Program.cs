using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.Decision_Making
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Input a random number:");
            string randNum = Console.ReadLine();

            if (Convert.ToInt32(randNum) % 2 == 0)
            {
                Console.WriteLine("I see, that's an even number!");
            }
            else
            {
                Console.WriteLine("That's an odd number in so many ways..");
            }

            Console.ReadLine();
        }
    }
}