using System.Reflection;

namespace Exerc03_PersonalInformation
{
    internal class Exerc03_PersonalInformation
    {
        static void Main(String[] args)
        {
            // Faça um algoritmo para imprimir a sua idade, o seu peso e o seu sexo.
            // Indicar o sexo como sendo: F – feminino ou M – masculino.

            // Variable Declaration
            int age = 26;
            double weight = 87.7;
            char gender = 'M';

            // Data Output
            Console.WriteLine("======= Personal Data =======");
            Console.WriteLine("> My Age: " + age + " years old;");
            Console.WriteLine("> My Weight: " + weight + " Kg;");
            Console.WriteLine("> My Gender: " + gender + ".");

            Console.ReadLine();
        }
    }
}
