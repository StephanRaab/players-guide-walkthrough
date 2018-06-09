using System;

namespace _10.Decision_Making
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Input your first number:");
            string firstNum = Console.ReadLine();

            Console.WriteLine("Thanks, now input your second number:");
            string secondNum = Console.ReadLine();

            if ((Convert.ToInt32(firstNum) < 0 && Convert.ToInt32(secondNum) < 0) ||
                (Convert.ToInt32(firstNum) > 0 && Convert.ToInt32(secondNum) > 0))
            {
                Console.WriteLine("Multiplying these together will be positive");
            }
            else
            {
                Console.WriteLine("The result will be a negative number");
            }

            Console.ReadLine();
        }
    }
}