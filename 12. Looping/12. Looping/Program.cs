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
            int playersNum;

            do
            {
                Console.WriteLine("Enter a number between 0 and 10:");
                string playerResponse = Console.ReadLine();
                playersNum = Convert.ToInt32(playerResponse);
            }

            while (playersNum < 0 || playersNum > 10);
        }
    }
}