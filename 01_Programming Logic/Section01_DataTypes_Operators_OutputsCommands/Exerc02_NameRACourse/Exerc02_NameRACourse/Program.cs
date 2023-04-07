using System;

namespace Exerc02_NameRACourse
{
    internal class Program
    {
        static void Main(String[] args)
        {
            // Faça um algoritmo para imprimir em cada linha: o seu nome completo, o seu RA e o seu curso

            // Variable Declarations
            string name = "Alan Bruno de Melo Rosa";
            string ra = "20670739";
            string course = "Computer Engineering";

            // Data Outputs
            Console.WriteLine("========== Student Data ==========");
            Console.WriteLine("> Full Name: " + name);
            Console.WriteLine("> Student Registration: " + ra);
            Console.WriteLine("> Course: " + course);

            Console.ReadLine();
        }
    }
}