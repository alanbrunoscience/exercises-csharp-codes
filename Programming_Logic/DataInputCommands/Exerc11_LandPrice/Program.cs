using System;
using System.Globalization;

namespace Exerc11_LandPrice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Variables Declaration
            double width, lenght, squareMeterPrice, area, price;

            // Data Input
            width = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            lenght = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            squareMeterPrice = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            // Area and Price Calculation
            area = width * lenght;
            price = area * squareMeterPrice;

            // Data Output
            Console.WriteLine(String.Format("AREA = {0}", area.ToString("F2", CultureInfo.InvariantCulture)));
            Console.WriteLine(String.Format("PRECO = {0}", price.ToString("F2", CultureInfo.InvariantCulture)));
        }
    }
}
