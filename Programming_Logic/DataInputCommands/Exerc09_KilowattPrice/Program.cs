using System;
using System.Globalization;

namespace Exerc09_KilowattPrice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Variables Declaration
            double salary, kilowattCons, kilowattPrice, totalPriceKlwt;

            // Data Input
            Console.WriteLine("Enter the minimum salary value:");
            salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Enter the kilowatt quantity consumed:");
            kilowattCons = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            // Kilowatt Price Calculation
            kilowattPrice = ((double) salary / 500);
            totalPriceKlwt = kilowattPrice * kilowattCons;

            // Data Output
            Console.WriteLine();
            Console.WriteLine(String.Format("a) The value, in US$, of each kilowatt is US$ {0};", (kilowattPrice.ToString("F2", CultureInfo.InvariantCulture))));
            Console.WriteLine(String.Format("b) The value, in US$, to be paid by this residence is US$ {0};", totalPriceKlwt.ToString("F2", CultureInfo.InvariantCulture)));
            Console.WriteLine(String.Format("c) The value, in US$, to be paid with a discount of 15% is US$ {0}.", (totalPriceKlwt * 0.85).ToString("F2", CultureInfo.InvariantCulture)));
        }
    }
}
