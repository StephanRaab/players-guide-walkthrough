﻿using System;
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
            int count;

            Console.WriteLine("How tall do you want your stack?");
            string height = Console.ReadLine();
            Console.WriteLine("\n");

            count = Convert.ToInt32(height);

            for (int row = 0; row < count; row++)
            {
                for (int column = 0; column < row + 1; column++)
                    Console.Write("*");

                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}