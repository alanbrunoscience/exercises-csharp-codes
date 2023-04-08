using System.Globalization;

namespace Exerc06_AreaOfASquare
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Variables Declaration
            double l = 350.0;
            double area = Math.Pow(l, 2);

            // Data Output
            Console.WriteLine("The area of square is: " + area.ToString("F2", CultureInfo.InvariantCulture) + " m².");
        }
    }
}
