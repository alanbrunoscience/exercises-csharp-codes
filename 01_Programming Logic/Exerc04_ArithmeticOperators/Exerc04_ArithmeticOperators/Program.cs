namespace Exerc04_ArithmeticOperators
{
	internal class Program
	{
		static void Main(string[] args)
		{
            // Faça um algoritmo para apresentar o resultado lógico das seguintes expressões:
            // ((120 - 30) = (3 x 30))
			// (não((20 % 4) = 1) ou(9 != 9))
			// ((5 % 2 / 2) > 3)
			// (a = A)

			// Data Output
			Console.WriteLine("> ((120 - 30) = (3 x 30)): " + ((120 - 30) == (3 * 30)));
			Console.WriteLine("> (!((20 % 4) = 1) ou (9 != 9)): " + (!((20 % 4) == 1) || (9 != 9)));
            Console.WriteLine("> ((5 % 2 / 2) > 3)): " + ((5 % 2 / 2) > 3));
			Console.WriteLine("> (a = A): " + ('a' == 'A'));

			Console.ReadLine();
        }
	}
}
