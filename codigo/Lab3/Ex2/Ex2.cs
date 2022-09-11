using System;

namespace Ex2
{
    class Program
    {
        static string Busca(int[] vet, int num)
        {
            int min = 0;
            int max = vet.Length - 1;
            int mid = (min + max) / 2;

            while (min <=max) 
            {
                mid = (min + max) / 2;

                if (num > vet[mid]) 
                {
                    min = mid + 1;
                    
                } 
                else if (num < vet[mid]) 
                {
                    max = mid - 1;
                }
                else return mid.ToString();
            }

            return "Número não encontrado";
        }

        static void Main(string[] args)
        {
            int[] vet = new int[10] {-20, -6, 2, 7, 10, 13, 23, 28, 45, 65};

            Console.WriteLine("Digite o número que você quer encontrar:");
            int num = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine(Busca(vet, num));
        }
    }
}