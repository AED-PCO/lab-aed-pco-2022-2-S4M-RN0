using System;

namespace Ex3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] matriz = new int[5,3];

            for (int row=0; row<matriz.GetLength(0); row++)
            {
                Console.WriteLine("Digite os valores da {0}° linha", row+1);
                for (int col=0; col<matriz.GetLength(1); col++)
                {
                   matriz[row,col] = Convert.ToInt32(Console.ReadLine());
                }
                Console.WriteLine("");
            }

            for (int row=0; row<matriz.GetLength(0); row++)
            {
                int soma=0;
                Console.WriteLine("Soma da {0}° linha", row+1);
                for (int col=0; col<matriz.GetLength(1); col++)
                {
                   soma+= matriz[row,col];
                }
                Console.WriteLine(soma+"\n");
            }
            for (int col=0; col<matriz.GetLength(1); col++)
            {
                int soma=0;
                Console.WriteLine("Soma da {0}° coluna", col+1);
                for (int row=0; row<matriz.GetLength(0); row++)
                {
                   soma+= matriz[row,col];
                }
                Console.WriteLine(soma+"\n");
            }
        }
    }
}