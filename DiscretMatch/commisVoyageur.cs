using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp56
{
    internal class Program
    {
        static int ans = 0;
        static int[,] MassLower(int[,] matrix, int x, int y)
        {
            int county = 0; int countx = 0;
            int[,] matrex = new int[matrix.GetLength(0) - 1, matrix.GetLength(0) - 1];
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                if (i == y) continue;
                for (int j = 0; j < matrix.GetLength(0); j++)
                {
                    if (j == x) continue;
                    if (countx == matrix.GetLength(0) - 1)
                    {
                        county++;
                        countx = 0;
                        matrex[county, countx] = matrix[i, j];
                        countx++;
                    }
                    else
                    {
                        matrex[county, countx] = matrix[i, j];
                        countx++;
                    }
                }
            }
            return matrex;
        }
        static int[,] MassMin(int[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                int min = int.MaxValue;
                for (int j = 0; j < matrix.GetLength(0); j++) { if (matrix[i, j] < min) min = matrix[i, j]; }
                for (int j = 0; j < matrix.GetLength(0); j++) matrix[i, j] -= min;
            }
            for (int j = 0; j < matrix.GetLength(0); j++)
            {
                int min = int.MaxValue;
                for (int i = 0; i < matrix.GetLength(0); i++) { if (matrix[i, j] < min) min = matrix[i, j]; }
                for (int i = 0; i < matrix.GetLength(0); i++) matrix[i, j] -= min;
            }
            return matrix;
        }
        static int[,] MassSearch(int[,] matrix)
        {
            int minint = int.MaxValue;
            int maxsum = int.MinValue; int X = 0; int Y = 0;
            for (int i = 0; i < matrix.GetLength(0); i++) for (int j = 0; j < matrix.GetLength(0); j++) if (matrix[i, j] < minint) minint = matrix[i, j];
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(0); j++)
                {
                    if (matrix[i, j] == minint)
                    {
                        int maxX = int.MinValue;
                        int maxY = int.MinValue;
                        for (int k = 0; k < matrix.GetLength(0); k++)
                        {
                            if (matrix[i, k] > maxX && matrix[i, k] < 1000) maxX = matrix[i, k];
                        }
                        for (int k = 0; k < matrix.GetLength(0); k++)
                        {
                            if (matrix[k, j] > maxY && matrix[k, j] < 1000) maxY = matrix[k, j];
                        }
                        if (maxsum < maxX + maxY)
                        {
                            maxsum = maxX + maxY; X = j; Y = i;
                        }
                    }
                }
            }
            if (ans == 0) ans += maxsum;
            else ans += minint;
            return MassLower(matrix, X, Y);
        }
        static void commisvoyageur(int[,] Matrix)
        {   
            if(Matrix.GetLength(0) == 0) { return; }
            var a = MassMin(Matrix);
            var b = MassSearch(a);
            commisvoyageur(b);
        }
            static void Main(string[] args)
        {
            int[,] arr =
            {
                {int.MaxValue,11,12,13, 10},
                {1 ,int.MaxValue,1 , 3, 10 },
                {2,1, int.MaxValue,1, 11 },
                {3,2,1, int.MaxValue, 12 },
                {3,2,1, 1, int.MaxValue },
            };
            commisvoyageur(arr);
            Console.WriteLine(ans);
        }
    }
}