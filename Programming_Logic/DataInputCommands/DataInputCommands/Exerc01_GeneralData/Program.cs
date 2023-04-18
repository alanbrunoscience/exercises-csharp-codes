using System;
using System.Globalization;

namespace Exerc01_GeneralData
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Data Inputs
            Console.WriteLine("Enter your full name:");
            string fullName = Console.ReadLine();
            
            Console.WriteLine("How many bedrooms are there in your house?");
            int bedrooms = int.Parse(Console.ReadLine());
            
            Console.WriteLine("Enter product price:");
            double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            
            Console.WriteLine("Enter your last name, age, and height (same line):");
            string[] generalInfo = Console.ReadLine().Split(' ');
            string lastName = generalInfo[0];
            int age = int.Parse(generalInfo[1]);
            double height = double.Parse(generalInfo[2], CultureInfo.InvariantCulture);

            // Data Outputs
            Console.WriteLine();
            Console.WriteLine("Full name: " + fullName);
            Console.WriteLine("Number of bedrooms: " + bedrooms);
            Console.WriteLine("Product Price: " + price.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine();
            Console.WriteLine("Last Name:");
            Console.WriteLine(lastName);
            Console.WriteLine("Age:");
            Console.WriteLine(age);
            Console.WriteLine("Height:");
            Console.WriteLine(height.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
