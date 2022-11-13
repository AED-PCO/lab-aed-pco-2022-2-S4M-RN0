using System;

namespace TreinoClasse
{
    class FilaDinamica
    {
        static void Main(string[] args)
        {
            Fila p1 = new Fila();
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

    public class Fila
    {
        private int[] fila = new int[1];
        private int Max = 0;

        public void Add(int add)
        {
            if (fila[Max] != 0)
            {
                Array.Resize(ref fila, fila.Length + 1);
                Max++;
            }
            fila[Max] = add;
        }

        public void Remove()
        {
            for(int i=0; i<fila.Length-1; i++)
            {
                fila[i] = fila[i+1];
            }

            Array.Resize(ref fila, fila.Length - 1);
            Max--;
        }

        public string Show()
        {
            string show = "";
            foreach (int valor in fila)
            {
                show += valor + " ";
            }
            return show;
        }
    }
}
