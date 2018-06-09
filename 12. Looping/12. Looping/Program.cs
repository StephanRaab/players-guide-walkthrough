using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.Looping
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int rows;

            Console.WriteLine("How tall do you want your stack?");
            string height = Console.ReadLine();
            Console.WriteLine("\n");

            rows = Convert.ToInt32(height);

            for (int x = 0; x < rows; x++)
            {
                for (int column = 0; column < x + 1; column++)
                    Console.Write("*");

                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}