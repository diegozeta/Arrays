using System;

namespace Array4
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

        static int SumaElementos(int[] S)
        {
            int sum = 0;
            foreach(int item in S)
            {
                sum += item;
            }
            return sum;
        }
        static int SumarRecursivo()

        static void Main(string[] args)
        {
            Console.WriteLine("Escriba un numero: ");
            int num = int.Parse(Console.ReadLine());

            ImprimeArray(LlenaArray(num));
        }
    }
}
