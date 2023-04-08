using System.Globalization;

namespace Exerc08_RectanglePerimeter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Variables Declaration
            double rectangleBase = 10.0;
            double rectangleHeight = 35.0;

            // Rectangle Perimeter
            double perimeter = 2 * (rectangleBase + rectangleHeight);

            // Data Output
            Console.WriteLine("The rectangle perimeter is: " + perimeter.ToString("F2", CultureInfo.InvariantCulture) + " cm." );

            Console.ReadLine();
        }
    }
}
