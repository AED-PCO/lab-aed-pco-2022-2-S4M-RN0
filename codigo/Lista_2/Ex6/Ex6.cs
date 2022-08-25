using System;

namespace Ex6
{
    class Program
    {
        static string Frase(string f, int fleng)
        { 
            string vogais = "aàáâãäåeèéêëiìíîïoòóôõöuùúûü";
            if (fleng >= 0)
            {
                if (vogais.Contains(f[fleng]))
                {
                    f = f.Remove(fleng, 1);
                    return Frase(f, fleng-1);
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

            Console.WriteLine($"A frase modificada é: {Frase(f, f.Length-1)}");
        }
    }
}