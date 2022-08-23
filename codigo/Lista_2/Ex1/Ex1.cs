using System;

namespace Program
{
    class Program
    {
        static double Fat(double n)
        {
            if (n != 2)
            {
                n = n * Fat(n-1);
            }
            
            return n;
        } 

        static void Main(string[] args)
        {
            Console.WriteLine("Digite um número");
            double n = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("O fatorial é " + Fat(n));
        }
    }
}