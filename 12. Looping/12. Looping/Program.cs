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
            for (int x = 1; x <= 10; x++)
            {
                if (x % 2 != 0)
                    continue;
                Console.WriteLine(x);
            }
            Console.ReadKey();
        }
    }
}