using System;

namespace Exerc10_MathExpressions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Variables Declaration
            int num;

            // Data Input
            Console.WriteLine("Enter a number:");
            num = int.Parse(Console.ReadLine());

            // Data Output
            Console.WriteLine();
            Console.WriteLine(String.Format("a) {0}² = {1}", num, Math.Pow(num, 2)));
            Console.WriteLine(String.Format("b) {0}³ = {1}", num, Math.Pow(num, 3)));
            Console.WriteLine(String.Format("b) {0}^10 = {1}", num, Math.Pow(num, 10)));
        }
    }
}
