using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.Switch_Statements
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Input your preferred operator:");
            string mathSign = Console.ReadLine();

            Console.WriteLine("Please input number 1:");
            string firstNum = Console.ReadLine();
            int firstNumInt = Convert.ToInt32(firstNum);

            Console.WriteLine("Input number 2:");
            string secondNum = Console.ReadLine();
            int secondNumInt = Convert.ToInt32(secondNum);

            switch (mathSign)
            {
                case "+":
                    Console.WriteLine($"{firstNum} + {secondNum} = { firstNumInt + secondNumInt}");
                    break;

                case "-":
                    Console.WriteLine($"{firstNum} - {secondNum} = { firstNumInt - secondNumInt}");
                    break;

                case "*":
                    Console.WriteLine($"{firstNum} * {secondNum} = { firstNumInt * secondNumInt}");
                    break;

                case "/":
                    Console.WriteLine($"{firstNum} / {secondNum} = { firstNumInt / secondNumInt}");
                    break;

                case "%":
                    Console.WriteLine($"{firstNum} % {secondNum} = { firstNumInt % secondNumInt}");
                    break;

                case "^":
                    Console.WriteLine($"{firstNum} ^ {secondNum} = {Math.Pow(firstNumInt, secondNumInt)}");
                    break;

                default:
                    Console.WriteLine("I'm sorry, I didn't recognize that.");
                    break;
            }

            Console.ReadLine();
        }
    }
}