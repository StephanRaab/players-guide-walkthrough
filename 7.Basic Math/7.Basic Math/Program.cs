﻿using System;
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
            // Tipping Calculator
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

            // Area of a triangle
            double area;
            double areaBase = 1.5;
            double areaHeight = 4;
            area = 0.5 * areaBase * areaHeight;
            Console.WriteLine("The area of a triangle with base " + areaBase + " and height " + areaHeight + " is " + area + ".");
            Console.ReadLine();

            // Remainders
            int a;
            int b;
            Console.WriteLine("Enter your first integer:");
            a = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine("Enter your second integer:");
            b = Convert.ToInt16(Console.ReadLine());

            int quotient = a / b;
            int remainder = a % b;
            int aTestCase = b * quotient + remainder;

            Console.WriteLine("{0}/{1} = {2}, with a remainder of {3}", a, b, quotient, remainder);
            Console.WriteLine("Is {0} equal to {1}?", aTestCase, a);
            Console.ReadLine();
        }
    }
}