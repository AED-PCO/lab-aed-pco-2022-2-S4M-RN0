using System;

namespace Ex4
{
    class Program
    {
        static int Cont(string f, char l)
        { 
            if (f.Length == 0)
            {
                return 0;
            }
            else if (f[f.Length - 1] != l)
            {
                return Cont(f.Substring(0,f.Length - 1), l);
            }
            else
            {
                return 1 + Cont(f.Substring(0,f.Length - 1), l);
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Digite uma frase e uma letra");
            String f = Console.ReadLine();
            Char l = Convert.ToChar(Console.ReadLine());

            f = f.ToLower();
            l = char.ToLower(l);

            Console.WriteLine($"O número de {l} na frase é {Cont(f, l)}");
        }
    }
}