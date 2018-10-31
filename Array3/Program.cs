using System;

namespace Array3
{
    class Program
    {
        static int[] LlenaArray(int n)
        {
            int[] A = new int[n];
            Random r = new Random();
            for (int i = 0; i < n; i++)
            {
                A[i] = r.Next(0, 20);
            }
            return A;
        }

        static void ImprimeArray(int[] N)
        {
            foreach (int i in N)
                Console.WriteLine(i);
        }
        static int SumaElementos(int[] S)
        {
            int sum = 0;
            foreach (int item in S)
            {
                sum += item;
            }
            return sum;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Escriba cuantos numeros aleatorios: ");
            int num = int.Parse(Console.ReadLine());

            Console.WriteLine(SumaElementos(LlenaArray(num)));
        }
    }
}
