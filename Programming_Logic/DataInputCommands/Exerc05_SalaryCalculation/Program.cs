using System;
using System.Globalization;

namespace Exerc05_SalaryCalculation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Data Input
            Console.WriteLine("Inform your salary, please:");
            double salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            // Salary Calculation
            double newSalary = salary * 1.25;

            // Data Output
            Console.WriteLine();
            Console.WriteLine("Your new salary is US$ {0}.", newSalary.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
