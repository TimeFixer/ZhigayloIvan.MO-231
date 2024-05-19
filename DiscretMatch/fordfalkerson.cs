using System;
using System.Collections.Generic;

class Edges
{
    public int versh;
    public int potok;
    public int weight;

    public Edges(int versh, int weight)
    {
        this.versh = versh;
        this.potok = 0;
        this.weight = weight;
    }

    public int GetValidCapacity()
    {
        return this.weight - this.potok;
    }
}
class Program
{
    static List<List<int>> graph = new List<List<int>>();
    static List<Edges> edges = new List<Edges>();
    static int[] alreadyUsed = new int[5];
    static int t = 1;
    static int start, finish;

    static void Main(string[] args)
    {
        List<int[]> ToGraph = new List<int[]>
        {
            new int[] {0, 1, 20}, new int[] {0, 2, 30}, new int[] {0, 3, 10},
            new int[] {1, 2, 40}, new int[] {1, 4, 30}, new int[] {2, 3, 10},
            new int[] {2, 4, 20}, new int[] {3, 4, 20}
        };
        start = 0;
        finish = 4;
        int ans = 0;
        for (int i = 0; i < 5; i++) graph.Add(new List<int>());
        foreach (var a in ToGraph) NewEdge(a[0], a[1], a[2]);
        while (FordFulkerson(start, int.MaxValue) > 0) t++;
        foreach (var a in graph[start]) ans += edges[a].potok;
        Console.WriteLine(ans);
    }
    static void NewEdge(int versh, int versh0, int weight)
    {
        graph[versh].Add(edges.Count);
        edges.Add(new Edges(versh0, weight));
        graph[versh0].Add(edges.Count);
        edges.Add(new Edges(versh, 0));
    }
    static int FordFulkerson(int versh, int minCapacity)
    {
        if (versh == finish) return minCapacity;
        alreadyUsed[versh] = t;

        foreach (var i in graph[versh])
        {
            if (edges[i].GetValidCapacity() == 0 || alreadyUsed[edges[i].versh] == t) continue;
            int x = FordFulkerson(edges[i].versh, Math.Min(minCapacity, edges[i].GetValidCapacity()));
            if (x > 0)
            {
                edges[i].potok += x;
                edges[i ^ 1].potok -= x;
                return x;
            }
        }
        return 0;
    }
}