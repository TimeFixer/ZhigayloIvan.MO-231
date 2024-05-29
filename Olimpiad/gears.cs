using System;
using System.IO;
using static Olimp;
class Olimp
{
    public class gear
    {
        public int number;
        public double zybs;
        public int [] Conecnt_gear; 
        public int direction; 
        public int ind = 0; 
        public int visit = 0;
    }
    static void Main()
    {
        StreamReader sr0 = new StreamReader("input.txt");
        StreamWriter sr1 = new StreamWriter("output.txt");
        string str = sr0.ReadLine();
        string[] e = str.Split(" ");
        int N = Convert.ToInt32(e[0]);
        int M = Convert.ToInt32(e[1]);
        gear[] mas = new gear[N] ;
        for (int i=0; i<N; i++)
        {
            mas[i] = new gear();
            mas[i].Conecnt_gear = new int[N];
            string str1 = sr0.ReadLine();
            string[] e1 = str1.Split(" ");
            mas[i].number = Convert.ToInt32(e1[0]);
            mas[i].zybs = Convert.ToDouble(e1[1]);
        }
        for (int i = 0; i < M; i++)
        {
            string str1 = sr0.ReadLine();
            string[] e1 = str1.Split(" ");
            int a = Convert.ToInt32(e1[0]);
            int b = Convert.ToInt32(e1[1]);
            if (a>=1|| a <= N|| b >= 1 || b <= N)
            {
                for (int j=0; j<N; j++)
                {
                    if (mas[j].number==a)
                    {
                        mas[j].Conecnt_gear[mas[j].ind] = b;
                        mas[j].ind++;
                    }
                    if (mas[j].number == b)
                    {
                        mas[j].Conecnt_gear[mas[j].ind] = a;
                        mas[j].ind++;
                    }
                }
            }
        }
        int start = 0;
        int end = 0;
        string str11 = sr0.ReadLine();
        string[] e11 = str11.Split(" ");
        string str22 = sr0.ReadLine();
        string[] e22 = str22.Split(" ");
        int a1 = Convert.ToInt32(e11[0]);
        int b1 = Convert.ToInt32(e11[1]);
        for (int j = 0; j < N; j++)
        {
            if (mas[j].number == a1)
            {
                mas[j].direction = Convert.ToInt32(e22[0]);
                start = j;
            }
            if (mas[j].number == b1) end = j;
        }
        if (search(mas[start], ref mas))
        {
            sr1.WriteLine(1);
            sr1.WriteLine(mas[end].direction);
            sr1.WriteLine("{0:N3}", mas[start].zybs / mas[end].zybs);
        }
        else sr1.WriteLine(-1);
        sr0.Close(); sr1.Close();
    }
    static bool search(gear A, ref gear[] mas)
    {
        for (int i=0; i<A.ind; i++)
        {
            for (int j=0; j<mas.Length; j++)
            {
                if (A.Conecnt_gear[i] == mas[j].number)
                {
                    if (mas[j].direction==0) mas[j].direction = -A.direction;
                    else if (mas[j].direction!=-A.direction) return false;
                    if (mas[j].visit != 1)
                    {
                        mas[j].visit = 1;
                        if (search(mas[j], ref mas)==false) return false;
                    }
                }
            }
        }
        return true;
    }
}