using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp40
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] Rebra = new int[7, 7];
            Rebra[0, 2] = 11; Rebra[0, 3] = 15; Rebra[0, 4] = 7; Rebra[1, 4] = 14; Rebra[1, 5] = 18; Rebra[2, 1] = 9; Rebra[2, 3] = 13; Rebra[2, 4] = 7;
            Rebra[2, 5] = 11; Rebra[2, 6] = 22; Rebra[3, 5] = 11; Rebra[3, 6] = 16; Rebra[4, 5] = 8; Rebra[4, 6] = 23; Rebra[5, 6] = 19;
            int[,] answ = new int[7, 7];
            int max_i = 1;
            /*for (int i = 0; i < 7; i++)
            {
                for (int j = 0; j < 7; j++)
                {
                    if (j <= 5) Console.Write(Rebra[i, j] + "\t");
                    else Console.Write(Rebra[i, j] + "\n");

                }
            }*/
            for (int iteration = 0; iteration < 7; iteration++)
            {
                for (int i = 0; i < max_i; i++)
                {
                    for (int j = 0; j < 7; j++)
                    {
                        if (Rebra[i, j] != 0 && answ[i, j] == 0) answ[i, j] = Rebra[i, j];
                        if (Rebra[j, i] != 0 && answ[j, i] == 0) answ[j, i] = Rebra[j, i];
                        if (Rebra[i, j] != 0 && answ[i, j] != 0 && Rebra[i, j] < answ[i, j]) answ[i, j] = Rebra[i, j];
                        if (answ[i,j] != 0)
                        {
                            for (int k = 0; k < 7; k++)
                            {
                               if (answ[j, k] != 0 && answ[i, k] == 0 && i != k ) answ[i, k] = answ[i, j] + answ[j, k];
                               if (answ[i, j] + answ[j, k] < answ[i, k] && answ[i, k] != 0 && answ[i, j] != 0 && answ[j, k] !=0) answ[i, k] = answ[i, j] + answ[j, k];
                            }
                        }
                    }
                }
                max_i++;
            }
            Console.WriteLine("\n");
            for (int i = 0; i < 7; i++)
            {
                for (int j = 0; j < 7; j++)
                {
                    if (j <= 5) Console.Write(answ[i, j] + "\t");
                    else Console.Write(answ[i, j] + "\n");

                }
            }
            int ans = 0;
            string way = null;
            Console.Write("Из какой вершины вы хотите найти путь? "); int ans1 = Convert.ToInt32(Console.ReadLine()); Console.Write("В какую вершину вы хотите найти путь? "); int ans2 = Convert.ToInt32(Console.ReadLine());
            if ((ans1 == ans2) && (1 <= ans1 && ans1 <= 7) && (1 <= ans2 && ans2 <= 7))
            {
                Console.WriteLine("0");
                return;
            }
            if ((1 <= ans1 && ans1 <= 7) && (1 <= ans2 && ans2 <= 7))
            {
                while (ans != answ[ans1 - 1, ans2 - 1])
                {
                    for (int i = 0; i < 7; i++)
                    {
                        if (Rebra[ans1 - 1, i] == 0) continue;
                        if (answ[i, ans2 - 1] + Rebra[ans1 - 1, i] == answ[ans1 - 1, ans2 - 1])
                        {
                            way = ans1 + " ---> " + (i+1) + " ---> " + ans2;
                            ans = answ[i, ans2 - 1] + Rebra[ans1 - 1, i];
                        }
                    }
                }
            }
            else
            {
                Console.WriteLine("Названа недопустимая вершина");
                return;
            }
            Console.WriteLine(way);
        }
    }
}

