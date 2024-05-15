using System;
using System.Collections.Generic;
namespace ConsoleApp52
{
    internal class Program
    {   
        static void Main(string[] args)
        {
            Queue<position> positions = new Queue<position>();
            List<position> List = new List<position>();
            int[,] matrix = {{ 999,  999,  999,  999,  999,  999,  999, 999},
                            {  999,    0,   -1,   -1,  999,   -1,   -2, 999},
                            {  999,   -1,   -1,   -1,  999,   -1,   -1, 999},
                            {  999,   -1,   -1,   -1,   -1,   -1,   -1, 999},
                            {  999,  999,  999,   -1,  999,   -1,   -1, 999},
                            {  999,   -1,   -1,   -1,  999,   -1,   -1, 999},
                            {  999,   -1,   -1,   -1,   -1,   -1,   -1, 999},
                            {  999,  999,  999,  999,  999,  999,  999, 999}};
            int volna = 1; int ans = 0;
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(0); j++)
                {
                    if (matrix[i, j] == 0)
                    {
                        positions.Enqueue(new position(i, j));
                        i = matrix.GetLength(0);
                        break;
                    }
                    else { continue; }
                }
            }
            while(positions.Count != 0) {
                while (positions.Count != 0)
                {
                    for (int i = positions.Peek().x - 1; i <= positions.Peek().x + 1; i++)
                    {
                        for (int j = positions.Peek().y - 1; j <= positions.Peek().y + 1; j++)
                        {
                            try
                            {
                                if (matrix[i, j] >= 0) continue;
                                if (matrix[i, j] < 0)
                                {
                                    if (matrix[i, j] == -1)
                                    {
                                        matrix[i, j] = volna;
                                        List.Add(new position(i, j));
                                    }
                                    else if (matrix[i, j] == -2)
                                    {
                                        matrix[i, j] = volna;
                                        List.Add(new position(i, j));
                                        ans = volna;
                                    }
                                }

                            }
                            catch (Exception e) { }
                        }
                    }
                    positions.Dequeue();
                }
                foreach (position p in List)
                {
                    positions.Enqueue(new position(p.x, p.y));
                }
                List.Clear();
                volna++;
            }
            Console.WriteLine(ans);
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(0); j++)
                {
                    if (j != matrix.GetLength(0) - 1) Console.Write(matrix[i, j] + " \t");
                    else Console.Write(matrix[i, j] + "\n");
                }
            }
        }
    }
    public class position
    {
        public int x;
        public int y;
        public position(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
    }
}