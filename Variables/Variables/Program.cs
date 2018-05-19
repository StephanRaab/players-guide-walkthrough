using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variables
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int a = 5;
            int b = 2;

            b = a;
            a = -3;
            Console.WriteLine("a is " + a);
            Console.WriteLine("b is " + b);
            Console.ReadLine();
        }
    }
}