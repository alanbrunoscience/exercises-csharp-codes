using System;

namespace Exerc03_SumOfNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Data Input
            Console.WriteLine("=== Sum Of Numbers");
            Console.WriteLine("Enter the first number:");
            int n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the second number:");
            int n2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the third number:");
            int n3 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the fourth number:");
            int n4 = int.Parse(Console.ReadLine());

            // Sum of Numbers
            int sum = n1 + n2 + n3 + n4;

            // Data Output
            Console.WriteLine();
            Console.WriteLine(String.Format("{0} + {1} + {2} + {3} = {4}", n1, n2, n3, n4, sum));
        }
    }
}
