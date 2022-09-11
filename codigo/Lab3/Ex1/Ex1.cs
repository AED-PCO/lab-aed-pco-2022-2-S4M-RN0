using System;

namespace Ex1 
{
    class Program 
    {

        //Com pos
        static int[] vetOrd(int[] vet) 
        {
            //int[] vetNovo = new int[];
            int temp = 0;  
  
            for (int i = 0; i < vet.Length; i++)  
            {  
                for (int j = i+1; j < vet.Length; j++)  
                {  
                    if (vet[i] > vet[j])  
                    {  
                        temp = vet[i];  
                        vet[i] = vet[j];  
                        vet[j] = temp;  
                    }  
                }  
            }

            return vet;
        }

        static void Main(string[] args) 
        {
            Console.WriteLine("Digite os valores do vetor:");
            int[] vet = new int[10];
            
            for (int i=0; i < vet.Length; i++)
            {
                vet[i] = Convert.ToInt32(Console.ReadLine());
            }

            int[] vetNovo = vetOrd(vet);

            Console.WriteLine("\nVetor ordenado:");
            for (int i=0; i < vet.Length; i++) 
            {
                Console.WriteLine(vet[i]);
            }
        }
    }
}