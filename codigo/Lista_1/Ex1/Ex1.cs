using System;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1000; i <= 9999; i++)
            {
               int n = i;
               int n1 = n / 100;
               int n2 = n % 100;
               int n3 = n1 + n2;

               if (Math.Pow(n3, 2) == i)
               {
                   Console.WriteLine(i);
               }
            }
        }
    }
}