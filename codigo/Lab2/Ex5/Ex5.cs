using System;

namespace Ex5
{
    class Program
    {
        static int Soma(int[] vet, int vleng)
        {
            if (vleng > 0)
            {
                if (vet[vleng-1]%2 == 0)
                {
                    return vet[vleng-1] + Soma(vet, vleng-1);
                }
                else if (vet[vleng-1]%2 != 0)
                {
                    return Soma(vet, vleng-1);
                }
            }

            return 0;
        }
        

        static void Main(string[] args)
        {
            int[] vet = new int[5];
            
            Console.WriteLine("Digite os valores do vetor");

            for (int i=0; i<vet.Length; i++)
            {
                vet[i] = Convert.ToInt32(Console.ReadLine());

                if (vet[i] < 0)
                {
                    Console.WriteLine("Erro! Digite um número positivo");
                    i--;
                }
            }

            Console.WriteLine($"A soma é {Soma(vet, 5)}");
        }
    }
}