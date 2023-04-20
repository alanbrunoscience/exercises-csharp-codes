using System;
using System.Globalization;

namespace Exerc04_AverageGrades
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Data Input
            Console.WriteLine("=== Average Grades ===");
            Console.WriteLine("Enter the first grade:");
            double g1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Enter the second grade:");
            double g2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Enter the third grade:");
            double g3 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Enter the fourth grade:");
            double g4 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            // Averaging
            double average = (g1 + g2 + g3 + g4) / 4;

            // Data Output
            Console.WriteLine();
            Console.WriteLine(String.Format("The average of grades is {0}.", average.ToString("F2", CultureInfo.InvariantCulture)));
        }
    }
}
