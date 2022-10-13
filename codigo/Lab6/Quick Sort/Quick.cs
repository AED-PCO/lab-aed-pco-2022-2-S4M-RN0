using System;

namespace Quick
{
    class Program
    {
        static int[] vetTroca(int[] vet, int i, int j)
        {
            int temp = vet[i];
            vet[i] = vet[j];
            vet[j] = temp;

            return vet;
        }

        static int vetQuebra(int[] vet, int ini, int fim)
        {
    
            int pivot = vet[fim];
    
            int i = (ini - 1);
    
            for (int j = ini; j <= fim - 1; j++) {
    
                if (vet[j] < pivot) {
    
                    i++;
                    vetTroca(vet, i, j);
                }
            }
            
            vetTroca(vet, i + 1, fim);
            return (i + 1);
        }
    
        static int[] vetSort(int[] vet, int ini, int fim)
        {
            if (ini < fim) {
    
                int pivot = vetQuebra(vet, ini, fim);
    
                vetSort(vet, ini, pivot - 1);
                vetSort(vet, pivot + 1, fim);
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
            
            int ini = vet.Length-1;
            int[] vetNovo = vetSort(vet, 0, ini);

            Console.WriteLine("\n\nVetor ordenado:");
            for (int i=0; i < vet.Length; i++) 
            {
                Console.Write(vet[i] + " ");
            }
        }
    }
}