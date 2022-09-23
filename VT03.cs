using System;

namespace vt03
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            var s = Console.ReadLine();
            var s1 = s.Split(' ');
            int[] a = new int[n];
            for (int i = 0; i < n; i++)
                a[i] = Convert.ToInt32(s1[i]);

            int max = a[0];
            for (int i = 0; i < n; i++)
                if (max < a[i]) max = a[i];
            for (int i = n-1; i >= 0; i--)
                if(a[i] == max)
                {
                    Console.WriteLine("{0}", i);
                    break;
                }
        }
    }
}
