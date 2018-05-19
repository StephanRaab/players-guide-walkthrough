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
            //#1 Meet C# requirements
            //#2 Variable names should descrive the stuff you INTEND on putting in it
            //#3 Don't abbreviate or remove letters
            //#4 A good name will usually be kind of long
            //#5 If your variables end with a number, you probably need a better name
            //#6 "data", "text", "number", and "item" are usually not descriptive enough
            //#7 Make the words of the variable name stand out from each other

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