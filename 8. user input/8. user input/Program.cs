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

            Console.WriteLine("Did you know that the volume of that Cylinder is {0}?", cylinderVolume);
            Console.WriteLine("Or, did you know that the surface of that Cylinder is a whopping {0}!", cylinderSurface);
            Console.ReadLine();
        }
    }
}