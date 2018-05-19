using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7.Basic_Math
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            float totalCost;
            float tipPercent;
            float tipAmount;
            float totalWithTip;

            Console.WriteLine("How much did it cost?");
            totalCost = float.Parse(Console.ReadLine());

            Console.WriteLine("How much would you like to tip?");
            tipPercent = float.Parse(Console.ReadLine());

            tipAmount = totalCost * (tipPercent / 100);
            totalWithTip = totalCost + tipAmount;

            Console.WriteLine("Your tip total is: {0:N2}", tipAmount);
            Console.WriteLine("Your total with tip is: {0:N2}", totalWithTip);
            Console.ReadLine();
        }
    }
}