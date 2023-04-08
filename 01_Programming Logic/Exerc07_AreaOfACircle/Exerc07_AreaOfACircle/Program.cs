using System.Globalization;

namespace Exerc07_AreaOfACircle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Variables Declaration
            double pi = Math.PI;
            double radius = 5.0;

            // Area of a circle
            double circleArea = (pi * Math.Pow(radius, 2));

            // Data Output
            Console.WriteLine("The area of circle is: " + circleArea.ToString("F2", CultureInfo.InvariantCulture) + " cm².");

            Console.ReadLine();
        }
    }
}
