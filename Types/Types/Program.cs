using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Types
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            byte aByte = 1;
            sbyte sByte = -15;
            short shortButLongerThanByte = 32000;
            ushort noNegativeShort = 65000;
            int aNormalInteger = 298927739;
            uint noNegIntDoubler = 3038373930;
            long aLongNumber = 8393928729;
            ulong wayLongerLong = 38933003838309339;
            char letter = 'c';
            float normalDecimal = 3.145f;
            double pi = 3.145782;
            decimal superSeriousDecimal = 3.1234567890123456789012345678m;
            bool trueOrFalse = true;
            string normalText = "This is a normal string";

            Console.WriteLine("So many types!!!");
            Console.WriteLine("=======================");
            Console.WriteLine("byte: " + aByte);
            Console.WriteLine("sbyte: " + sByte);
            Console.WriteLine("short: " + shortButLongerThanByte);
            Console.WriteLine("ushort: " + noNegativeShort);
            Console.WriteLine("int: " + aNormalInteger);
            Console.WriteLine("uint: " + noNegIntDoubler);
            Console.WriteLine("long: " + aLongNumber);
            Console.WriteLine("ulong: " + wayLongerLong);
            Console.WriteLine("char: " + letter);
            Console.WriteLine("float: " + normalDecimal);
            Console.WriteLine("double: " + pi);
            Console.WriteLine("decimal: " + superSeriousDecimal);
            Console.WriteLine("bool: " + trueOrFalse);
            Console.WriteLine("string: " + normalText);
            Console.ReadLine();
        }
    }
}