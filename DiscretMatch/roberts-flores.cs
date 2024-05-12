using System;
using System.Collections.Generic;

class HelloWorld
{
    static int[,] graph = {
        {0, 1, 1, 1, 0, 0, 0},
        {1, 0, 1, 0, 1, 0, 1},
        {1, 1, 0, 1, 1, 1, 1},
        {1, 0, 1, 0, 1, 1, 1},
        {0, 1, 1, 1, 0, 1, 0},
        {0, 0, 1, 1, 1, 0, 1},
        {0, 1, 1, 1, 0, 1, 0},
    };

    static int V = graph.GetLength(0);
    static List<int> versh = new List<int>();

    public static void Main(string[] args)
    {
        RecursFind(0, 0);
    }

    static void RecursFind(int v, int count)
    {
        versh.Add(v);
        if (count == V - 1)
        {
            if (graph[v, 0] == 1)
            {
                Console.WriteLine("Гамильтонов цикл:");
                foreach (int ver in versh)
                {
                    Console.Write(ver+1 + " ");
                }
                return;
            }
        }
        else
        {
            for (int i = 0; i < V; i++)
            {
                if (graph[v, i] == 1 && !versh.Contains(i))
                {
                    RecursFind(i, count + 1);
                }
            }
        }
        versh.RemoveAt(versh.Count - 1);
    }
}