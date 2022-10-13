using System;

namespace Shell
{
    class Program
    {
        static int[] vetOrd(int[] vet)
        {
            int n = vet.Length;
    
            for (int gap = n/2; gap > 0; gap /= 2)
            {
                for (int i = gap; i < n; i += 1)
                {
                    int temp = vet[i];
                    int j;

                    for (j = i; j >= gap && vet[j - gap] > temp; j -= gap) vet[j] = vet[j - gap];
    
                    vet[j] = temp;
                }
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