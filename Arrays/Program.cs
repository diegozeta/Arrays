using System;

namespace Arrays
{

    class Program
    {
        static int[] LlenaArray(int n)
        {
            int []A = new int[n];
            for(int i=0;i<n;i++){
                A[i]= i*2;
            }
            return A;
        }

        static void ImprimeArray(int []N)
        {
            foreach (int i in N)
                Console.WriteLine(i);
        }

        static void Main(string[] args)
        {
            ImprimeArray(LlenaArray(10)); 
        }
    }
}
