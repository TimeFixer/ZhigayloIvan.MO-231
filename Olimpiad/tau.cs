using System;
using System.IO;
class HelloWorld
{
    static void Main()
    {
        StreamReader reader = new StreamReader("input.txt");
        string[] read = reader.ReadLine().Split();
        string[] ans = new string[read.Length];
        int start1 = read.Length / 2;
        for (int i = 0; i < read.Length; i++)
        {
            int dif1;
            if (i % 2 == 0) dif1 = i;
            else dif1 = -i;
            start1 += dif1;
            int start2 = read[start1].Length / 2;
            for (int j = 0; j < read[start1].Length; j++)
            {
                int dif2;
                if (j % 2 == 0) dif2 = j;
                else dif2 = -j;
                start2 += dif2;
                ans[i] += read[start1][start2];
            }
        }
        StreamWriter writer = new StreamWriter("output.txt");
        writer.Write(string.Join(" ", ans));
        writer.Close();
    }
}