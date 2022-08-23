using System;

namespace Ex2
{
    class Program
    {
        static int Mult(int a, int b)
        {
            if (b != 1)
            {
                a += Mult(a, b-1);
            }

            return a;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Digite dois números inteiros");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("A multiplicação é " + Mult(a, b));
        }
    }
}