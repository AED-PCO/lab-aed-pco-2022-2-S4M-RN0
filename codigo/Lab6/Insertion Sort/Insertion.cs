using System;

namespace Insertion
{
    class Insertion
    {
        static int[] vetOrd(int[] vet)
        {
            int n = vet.Length;
            for (int i = 1; i < n; ++i) 
            {
                int atu = vet[i];
                int ant = i - 1;

                while (ant >= 0 && vet[ant] > atu) 
                {
                    vet[ant + 1] = vet[ant];
                    ant = ant - 1;
                }
                vet[ant + 1] = atu;
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