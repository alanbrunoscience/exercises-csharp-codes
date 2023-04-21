using System;

namespace Exerc07_ProductOfNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Variables Declaration
            int n1, n2, prod;

            // Data Input
            Console.WriteLine("Enter the first number:");
            n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the second number:");
            n2 = int.Parse(Console.ReadLine());

            // Product Of Numbers
            prod = n1 * n2;

            // Data Output
            Console.WriteLine();
            Console.WriteLine(String.Format("{0} x {1} = {2}", n1, n2, prod));
        }
    }
}
