using System;

namespace Exerc08_AgeOfPerson
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Variables Declaration
            int birthYear, currentYear, age, newAge, futureYear;

            // Data Input
            Console.WriteLine("Inform your birth year:");
            birthYear = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the current year:");
            currentYear = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the future year:");
            futureYear = int.Parse(Console.ReadLine());

            // Age Calculation
            age = currentYear - birthYear;
            newAge = futureYear - birthYear;

            // Data Output
            Console.WriteLine();
            Console.WriteLine(String.Format("Your are {0} years old.", age));
            Console.WriteLine(String.Format("In {0} you will be {1} years old.", futureYear, newAge));
        }
    }
}
