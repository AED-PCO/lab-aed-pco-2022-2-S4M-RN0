using System;

namespace Ex1 
{
    class Program 
    {
        static int[] vetMerge(int[] vet, int esq, int m, int dir)
        {
            int n1 = m - esq + 1;
            int n2 = dir - m;
    
            int[] vetE = new int[n1];
            int[] vetD = new int[n2];
            int i, j;
    
            for (i = 0; i < n1; ++i) vetE[i] = vet[esq + i];
            
            for (j = 0; j < n2; ++j) vetD[j] = vet[m + 1 + j];
    

            i = 0;
            j = 0;

            int k = esq;
            while (i < n1 && j < n2) {
                if (vetE[i] <= vetD[j]) {
                    vet[k] = vetE[i];
                    i++;
                }
                else {
                    vet[k] = vetD[j];
                    j++;
                }
                k++;
            }

            while (i < n1) {
                vet[k] = vetE[i];
                i++;
                k++;
            }
    
            while (j < n2) {
                vet[k] = vetD[j];
                j++;
                k++;
            }

            return vet;
        }

        static int[] vetSort(int[] vet, int esq, int dir)
        {
            if (esq < dir) {
                int m = esq + (dir - esq) / 2;
    
                vetSort(vet, esq, m);
                vetSort(vet, m + 1, dir);
    
                vetMerge(vet, esq, m, dir);
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
            
            int dir = vet.Length-1;
            int[] vetNovo = vetSort(vet, 0, dir);

            Console.WriteLine("\n\nVetor ordenado:");
            for (int i=0; i < vet.Length; i++) 
            {
                Console.Write(vet[i] + " ");
            }
        }
    }
}