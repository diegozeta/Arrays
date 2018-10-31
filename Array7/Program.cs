using System;

namespace Array7
{
    class Program
    {
        static int[] CreaArray(int n)
        {
            int[] S = new int[n];
            Random azar = new Random();

            for (int i = 0; i < n; i++)
            {
                S[i] = azar.Next(0, 100);
                Console.WriteLine(S[i]);
            }
            return S;
        }
        static void BuscaArray(int[] s, int num)
        {
            bool encontrado = false;

            foreach (int item in s)
            {
                if (item == num)
                {
                    encontrado = true;
                }
            }
            if (encontrado == true)
            {
                Console.WriteLine("SE ENCONTRO EL ELEMENTO");
            }
            else
            {
                Console.WriteLine("NO SE ENCONTRO EL ELEMENTO");
            }
        }
        static void Recursivo()
        {
            int[] azar = CreaArray(8);

            Console.WriteLine("Busqueda de Elemento:");
            int elemento = int.Parse(Console.ReadLine());

            BuscaArray(azar, elemento);

        }

            static void Main(string[] args)
        {
            Recursivo();
        }
    }
}
