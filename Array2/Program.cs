using System;

namespace Array2
{
    class Program
    {
        static int[] LlenaArray(int n)
        {
            int[] A = new int[n];
            for (int i = 0; i < n; i++)
            {
                A[i] = i;
            }
            return A;
        }

        static void ImprimeArray(int[] N)
        {
            foreach (int i in N)
                Console.WriteLine(i);
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Escriba un Numero: ");
            int num = int.Parse(Console.ReadLine());

            ImprimeArray(LlenaArray(num));
        }
    }
}
