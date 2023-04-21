using System;
using System.Globalization;

namespace Exerc06_TriangleArea
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Data Input
            Console.WriteLine("Enter the value of the triangle base (cm):");
            double triangleBase = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Enter the value of the triangle height (cm):");
            double triangleHeight = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            // Area Calculation
            double area = ((triangleBase * triangleHeight) / 2);

            // Data Output
            Console.WriteLine();
            Console.WriteLine(String.Format("The triangle area is {0} cm².", area.ToString("F2", CultureInfo.InvariantCulture)));
        }
    }
}
