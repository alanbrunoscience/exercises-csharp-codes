using System;

namespace Exerc02_NameAgeGender
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Data Input
            Console.WriteLine("=== Name, Age, Gender ===");
            Console.WriteLine("1) Inform your name, please:");
            string name = Console.ReadLine();
            Console.WriteLine("2) What is your age?");
            int age = int.Parse(Console.ReadLine());
            Console.WriteLine("3) What is your gender (F/M)?");
            char gender = char.Parse(Console.ReadLine());

            // Data Output
            Console.WriteLine();
            Console.WriteLine(String.Format("> Your name is {0};", name));
            Console.WriteLine(String.Format("> You are {0} years old;", age));
            Console.WriteLine(String.Format("> Your gender is {0}.", gender));
        }
    }
}
