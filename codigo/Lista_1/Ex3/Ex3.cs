using System;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] vetA = new int[5];
            int[] vetB = new int[5];
            int[] vetC = new int[5];
            int[] vetD = new int[10];

            //Definir vetor A
            Console.WriteLine("Digite os valores do vetor A");
            for (int i = 0; i < 5; i++)
            {
                vetA[i] = Convert.ToInt32(Console.ReadLine());
            }

            //Definir vetor B
            Console.WriteLine("\nDigite os valores do vetor B");
            for (int i = 0; i < 5; i++)
            {
                vetB[i] = Convert.ToInt32(Console.ReadLine());
            }

            //Checar vetores
            int arC=0, arD=0;
            for (int check=0; check<vetA.Length; check++)
            {
                if (vetA.Contains(vetB[check]))
                {
                    vetC[arC] = vetB[check];
                    arC++;
                }
            }
            for (int check=0; check<vetA.Length; check++)
            {
                if (!vetC.Contains(vetA[check]))
                {
                    vetD[arD] = vetA[check];
                    arD++;
                }
                if (!vetC.Contains(vetB[check]))
                {
                    vetD[arD] = vetB[check];
                    arD++;
                }
            }

            //Resize vetor C
            int rsC=0, rsD=0;
            for (int rs=0; rs < vetC.Length; rs++)
            {
                if (vetC[rs] != 0) rsC++;
            }
            Array.Resize<int>(ref vetC, rsC);
            //Resize vetor D
            for (int rs = 0; rs < vetD.Length; rs++)
            {
                if (vetD[rs] != 0) rsD++;
            }
            Array.Resize<int>(ref vetD, rsD);

            //Print vetor C
            Console.WriteLine("\n\nVetor C");
            for (int i = 0; i < vetC.Length; i++)
            {
                Console.WriteLine(vetC[i]);
            }
            //Print vetor D
            Console.WriteLine("\n\nVetor D");
            for (int i = 0; i < vetD.Length; i++)
            {
                Console.WriteLine(vetD[i]);
            }
        }
    }
}