using System;

namespace Selection
{
    class Program
    {
        static int[] vetOrd(int[] vet)
        {
            int n = vet.Length;
    
            for (int i = 0; i < n - 1; i++)
            {
                int menor = i;
                for (int j = i + 1; j < n; j++)
                    if (vet[j] < vet[menor])
                        menor = j;
    
                int temp = vet[menor];
                vet[menor] = vet[i];
                vet[i] = temp;
            }

            return vet;
        }

        static void Main(string[] args) 
        {
            int[] vet = new int[7];
            Random rnd = new Random();
            
            Console.WriteLine("Vetor normal");
            for (int i=0; i < vet.Length; i++)
            {
                vet[i] = rnd.Next(1, 100);
                Console.Write(vet[i] + " ");
            }

            int[] vetNovo = vetOrd(vet);

            Console.WriteLine("\n\nVetor ordenado:");
            for (int i=0; i < vet.Length; i++) 
            {
                Console.Write(vet[i] + " ");
            }
        }
    }
}