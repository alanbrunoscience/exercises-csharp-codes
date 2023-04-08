using System.Globalization;

namespace Exerc05_ArithmeticAverage
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Variable Declaration
            double n1 = 8.0;
            double n2 = 7.5;
            double n3 = 4.5;
            double n4 = 9.0;
            double average = 0;

            // Data Output
            Console.WriteLine("====== Arithmetic Average ======");
            average = (n1 + n2 + n3 + n4) / 4;
            Console.WriteLine("> The average is: " + average.ToString("F2", CultureInfo.InvariantCulture));

            Console.ReadLine();
        }
    }
}
