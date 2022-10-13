using System;

namespace Bubble
{
    class Program 
    {
        static int[] vetOrd(int[] vet) 
        {
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
            int[] vet = new int[10];
            Random rnd = new Random();  
            
            for (int i=0; i < vet.Length; i++)
            {
                vet[i] = rnd.Next(1, 100);
            }

            int[] vetNovo = vetOrd(vet);

            Console.WriteLine("\nVetor ordenado:");
            for (int i=0; i < vet.Length; i++) 
            {
                Console.Write(vet[i] + " ");
            }
        }
    }
}