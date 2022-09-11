using System;

namespace Ex5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um número inteiro");
            int fat = Convert.ToInt32(Console.ReadLine());
            int cont=fat, rfat=0;

            rfat = fat * (fat-1);
            fat--;
            while (cont != 3)
            {
                rfat = rfat *(fat-1);
                fat--;
                cont--;
            }

            Console.WriteLine("\nO fatorial é: " + rfat);
        }
    }
}