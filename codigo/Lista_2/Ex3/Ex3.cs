using System;

namespace Ex3
{
    class Program
    {
        static int Pot(int a, int b)
        {
            double result = Math.Pow(a, b);
            return Convert.ToInt32(result);
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Digite dois números inteiros");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\nA potência é: " + Pot(a, b));
        }
    }
}