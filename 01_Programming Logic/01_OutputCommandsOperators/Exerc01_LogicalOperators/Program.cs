namespace Exerc01_LogicalOperators
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Variables Declaration
            bool A = true;
            bool B = false;

            // Logical Results
            Console.WriteLine("a) !A && B || A && !B = " + (!A && B || A && !B));
            Console.WriteLine("b) !(!(A || B) && (A || B)) = " + (!(!(A || B) && (A || B))));
            Console.WriteLine("c) A || B && !A || !B = " + (A || B && !A || !B));
            Console.WriteLine("d) (A || B) && (!A || B) = " + ((A || B) && (!A || B)));

            Console.ReadLine();
        }
    }
}
