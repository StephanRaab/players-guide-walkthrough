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
            int num = 1;
            while (num <= 10)
            {
                Console.WriteLine(num);
                num++;
            }
            Console.ReadKey();
        }
    }
}