using System;

namespace Ex5
{
    class Program
    {
        static int Fat(int n)
        {
            if (n==2)
            {
                return 2;
            }

            return n*Fat(n-1);
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Digite um número inteiro");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\nO fatorial é: " + Fat(n));
        }
    }
}