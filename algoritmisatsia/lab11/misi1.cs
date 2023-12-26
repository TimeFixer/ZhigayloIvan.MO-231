using System;

namespace misi
{
    internal class Program
    {
        static void Main()
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            int k = Convert.ToInt32(Console.ReadLine());
            int ans = 0;
            int[] misi = new int[n];
            int smeshenie = 0;
            for (int i = 0; i < n; i++)
            {
                misi[i] = i;
            }
            int start = 0;
            int start_pos = start;
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < k;)
                {
                    start_pos++;
                    while (start_pos > n - 1)
                    {
                        start_pos = start_pos - n;
                    }
                    if (misi[start_pos] != -1)
                    {
                        j++;
                    }
                }
                misi[start_pos] = -1;
            }
            foreach (int i in misi)
            {
                if (i != -1)
                {
                    smeshenie = i - start;
                }
            }
            if (b - smeshenie >= 0)
            {
                ans = b - smeshenie;
            }
            else if (b - smeshenie < 0)
            {
                ans = n - 1 + (b - smeshenie);
            }
            Console.WriteLine("Нужно начинать с " + ans + " позиции");

        }
    }
}