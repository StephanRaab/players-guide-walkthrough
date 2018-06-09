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
            //print pyramid
            int count;

            Console.WriteLine("How tall should the pyramid be?");
            string height = Console.ReadLine();
            Console.WriteLine("\n");

            count = Convert.ToInt32(height);

            for (int row = 0; row < count; row++)
            {
                for (int column = count; column > row + 1; column--)
                    Console.Write(" ");

                for (int column = 0; column < row + 1; column++)
                    Console.Write("*");

                for (int column = 0; column < (row - 1) + 1; column++)
                    Console.Write("*");

                Console.WriteLine();
            }
            Console.ReadKey();

            //fizzbuzz
            for (int i = 1; i <= 100; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    Console.WriteLine("FizzBuzz");
                }
                else if (i % 3 == 0)
                {
                    Console.WriteLine("Fizz");
                }
                else if (i % 5 == 0)
                {
                    Console.WriteLine("Buzz");
                }
                else
                {
                    Console.WriteLine(i);
                }
            }
            Console.ReadKey();
        }
    }
}