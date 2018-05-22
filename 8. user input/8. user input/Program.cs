using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8.user_input
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Cylinders");
            Console.WriteLine("==========");

            Console.WriteLine("How tall is the cylinder?");
            string cylinderHeight = Console.ReadLine();
            double cylinderHeightDouble = Convert.ToDouble(cylinderHeight);

            Console.WriteLine("How big is the radius of the base??");
            string cylinderBaseRadius = Console.ReadLine();
            double cylinderBaseRadiusDouble = Convert.ToDouble(cylinderBaseRadius);

            double cylinderVolume = Math.PI *
                Math.Pow(cylinderBaseRadiusDouble, 2) *
                cylinderHeightDouble;

            double cylinderSurface = 2 *
                Math.PI *
                cylinderBaseRadiusDouble *
                (cylinderBaseRadiusDouble + cylinderHeightDouble);

            Console.WriteLine($"The volume of the cylinder is: {cylinderVolume}.");
            Console.WriteLine($"The Surface area is a whopping {cylinderSurface}!");
            Console.ReadLine();
        }
    }
}