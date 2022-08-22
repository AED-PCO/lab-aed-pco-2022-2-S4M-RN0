using System;

namespace Ex2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um número inteiro");
            int n = Convert.ToInt32(Console.ReadLine());
            int check = 0;
            for (int i = 1; i <= n; i++)
            {
                if ((n % i) == 0)
                {
                    check++;
                }
            }

            if (check == 2)
            {
                Console.WriteLine(n + " é um número primo");
            }
            else
            {
                Console.WriteLine(n + " não é um número primo");
            }
            Console.WriteLine("\nNúmeros perfeitos");
            for (int i = 1; i <= 1000; i++)
            {
                int soma=0;

                for (int d = 1; d < i; d++)
                {
                    if (i % d == 0)
                    {
                        soma += d; 
                    }
                }

                if (i == soma && i != 1)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}