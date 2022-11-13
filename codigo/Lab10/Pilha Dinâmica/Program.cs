using System;

namespace TreinoClasse
{
    class PilhaDinamica
    {
        static void Main(string[] args)
        {
            Pilha p1 = new Pilha();
            p1.Add(5);
            p1.Add(3);
            p1.Add(4);
            p1.Add(10);
            p1.Remove();
            p1.Add(23);
            p1.Remove();
            p1.Remove();
            Console.WriteLine(p1.Show());
        }
    }

    public class Pilha
    {
        private int[] pilha = new int[1];
        private int Max = 0;

        public void Add(int add)
        {
            if (pilha[Max] != 0)
            {
                Array.Resize(ref pilha, pilha.Length+1);
                Max++;
            }
            pilha[Max] = add;    
        }

        public void Remove()
        {
            Array.Resize(ref pilha, pilha.Length - 1);
            Max--;
        }

        public string Show()
        {
            string show = "";
            for (int i=pilha.Length-1; i>=0; i--)
            {
                show += pilha[i] + "\n";
            }
            return show;
        }
    }
}