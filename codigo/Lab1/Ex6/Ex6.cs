using System;

namespace Ex6
{
    class Program
    {
        static int Pot(int x, int y)
        {
            double result = Math.Pow(x, y);
            return Convert.ToInt32(result);
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Digite dois números inteiros");
            int x = Convert.ToInt32(Console.ReadLine());
            int y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\nA potência é: " + Pot(x, y));
        }
    }
}