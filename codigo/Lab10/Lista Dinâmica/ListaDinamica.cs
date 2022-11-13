namespace TreinoClasse
{
    class ListaDinamica
    {
        static void Main(string[] args)
        {
            Lista p1 = new Lista();
            p1.Add(5);
            p1.Add(3);
            p1.Add(4);
            p1.Add(10);
            p1.Remove(4);
            Console.WriteLine(p1.Show());
        }
    }

    public class Lista
    {
        private int[] lista = new int[1];
        private int Max = 0;

        public void Add(int add)
        {
            if (lista[Max] != 0)
            {
                Array.Resize(ref lista, lista.Length + 1);
                Max++;
            }
            lista[Max] = add;
        }

        public void Remove(int valor)
        {
            int index = Array.IndexOf(lista, valor);

            for (int i = index; i < lista.Length - 1; i++)
            {
                lista[i] = lista[i + 1];
            }

            Array.Resize(ref lista, lista.Length - 1);
            Max--;
        }

        public string Show()
        {
            string show = "";
            foreach (int valor in lista)
            {
                show += valor + "\n";
            }
            return show;
        }
    }
}
