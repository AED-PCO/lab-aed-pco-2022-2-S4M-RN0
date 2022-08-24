using System;

namespace Ex6
{
    class Program
    {
        // Não  finalizada
           static string Frase(string f, int fleng)
        { 
            if (f.Length > 0)
            {
                if (f[fleng-1] == 'a' || f[fleng-1] == 'e' || f[fleng-1] == 'i' || f[fleng-1] == 'o' || f[fleng-1] == 'u')
                {
                    f = f.Remove(fleng-1, 1);
                    return Frase(f, f.Length);
                }
                else
                {
                    return Frase(f, fleng-1);
                }
            }
            
            return f;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Digite uma frase");
            String f = Console.ReadLine();
            f = f.ToLower();

            Console.WriteLine($"A frase modificada é: {Frase(f, f.Length)}");
        }
    }
}