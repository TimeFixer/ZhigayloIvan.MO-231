using System;
using System.Collections.Generic;
using System.IO;
class HelloWorld
{
    static List<List<int>> Rotate(List<List<int>> matrix)
    {
        List<List<int>> result = new List<List<int>>();
        for (int i = 0; i < matrix[0].Count; i++)
        {
            List<int> res = new List<int>();
            for (int j = matrix.Count - 1; j >= 0; j--)
            {
                res.Add(matrix[j][i]);
            }
            result.Add(res);
        }
        return result;
    }
    static void Main()
    {
        StreamReader input = new StreamReader("input.txt");
        StreamWriter output = new StreamWriter("output.txt");

        string[] nm = input.ReadLine().Split();
        int n = int.Parse(nm[0]);
        int m = int.Parse(nm[1]);

        string[] xyz = input.ReadLine().Split();
        int x = int.Parse(xyz[0]);
        int y = int.Parse(xyz[1]);
        int z = int.Parse(xyz[2]);

        for (int i = 0; i < m; i++)
        {
            string[] axis = input.ReadLine().Split();
            string a = axis[0];
            int k = int.Parse(axis[1]);
            int s = int.Parse(axis[2]);

            if (a == "X" && x == k)
            {
                List<List<int>> mas = new List<List<int>>();
                for (int j = 0; j < n; j++)
                {
                    mas.Add(new List<int>());
                    for (int l = 0; l < n; l++)
                    {
                        mas[j].Add(0);
                    }
                }
                mas[y - 1][z - 1] = 1;
                if (s == 1) mas = Rotate(mas);
                else mas = Rotate(Rotate(Rotate(mas)));
                for (int j = 0; j < n; j++)
                {
                    for (int l = 0; l < n; l++)
                    {
                        if (mas[j][l] == 1)
                        {
                            y = j + 1;
                            z = l + 1;
                        }
                    }
                }
            }
            if (a == "Y" && y == k)
            {
                List<List<int>> mas = new List<List<int>>();
                for (int j = 0; j < n; j++)
                {
                    mas.Add(new List<int>());
                    for (int l = 0; l < n; l++)
                    {
                        mas[j].Add(0);
                    }
                }
                mas[x - 1][z - 1] = 1;
                if (s == 1) mas = Rotate(mas);
                else mas = Rotate(Rotate(Rotate(mas)));
                for (int j = 0; j < n; j++)
                {
                    for (int l = 0; l < n; l++)
                    {
                        if (mas[j][l] == 1)
                        {
                            x = j + 1;
                            z = l + 1;
                        }
                    }
                }
            }
            if (a == "Z" && z == k)
            {
                List<List<int>> mas = new List<List<int>>();
                for (int j = 0; j < n; j++)
                {
                    mas.Add(new List<int>());
                    for (int l = 0; l < n; l++) mas[j].Add(0);
                }
                mas[x - 1][y - 1] = 1;
                if (s == 1) mas = Rotate(mas);
                else mas = Rotate(Rotate(Rotate(mas)));
                for (int j = 0; j < n; j++)
                {
                    for (int l = 0; l < n; l++)
                    {
                        if (mas[j][l] == 1)
                        {
                            x = j + 1;
                            y = l + 1;
                        }
                    }
                }
            }
        }
        output.Write($"{x} {y} {z}");
        output.Close();
    }
}