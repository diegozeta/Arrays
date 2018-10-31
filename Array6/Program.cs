using System;

namespace Array6
{
    class Program
    {
        static int[] CreaArray(int n)
        {
            int[] S = new int[n];
            Random azar = new Random();

            for(int i = 0; i < n; i++)
            {          
                S[i] = azar.Next(0,100);
                Console.WriteLine(S[i]);
            }
            return S;
        }
        static void BuscaArray(int []s)
        {
            Console.WriteLine("Busqueda de Elemento:");
            int elemento = int.Parse(Console.ReadLine());         
            bool encontrado = false;

            foreach (int item in s)
            {
                if (item == elemento)
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


        
        static void Main(string[] args)
        {
            BuscaArray(CreaArray(8));

        }
    }
}
