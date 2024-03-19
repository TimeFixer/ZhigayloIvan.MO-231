using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication38
{
    class Program
    {
        static void Main(string[] args)
        {
            Rebro[] rebra = new Rebro[11];
            rebra[0] = new Rebro("A", "B");
            rebra[1] = new Rebro("B", "C");
            rebra[2] = new Rebro("A", "C");
            rebra[3] = new Rebro("A", "E");
            rebra[4] = new Rebro("C", "E");
            rebra[5] = new Rebro("B", "E");
            rebra[6] = new Rebro("D", "G");
            rebra[7] = new Rebro("D", "H");
            rebra[8] = new Rebro("G", "H");
            rebra[9] = new Rebro("D", "F");
            rebra[10] = new Rebro("F", "H");
            Stack<string> check = new Stack<string>();
            int forest = 0;
            var tree = new Dictionary<string, int>();
            
            foreach (Rebro proverka in rebra)
            {
                if (!check.Contains(proverka.v1)) check.Push(proverka.v1);
                if (!check.Contains(proverka.v2)) check.Push(proverka.v2);
            }
            int BAZA = check.Count;
            while (tree.Count != BAZA)
            {
                int sus = 0;
                foreach (Rebro s in rebra)
                {
                    if (tree.ContainsKey(s.v1) && tree.ContainsKey(s.v2))
                    {
                        sus++;
                        continue;
                    }
                    if (check.Peek() == s.v1)
                    {
                        if (tree.ContainsKey(check.Peek()))
                        {
                            tree.Add(s.v2, forest);
                            if (check.Contains(s.v2)) check.Push(s.v2);
                        }
                        else
                        {
                            forest++;
                            tree.Add(s.v2, forest);
                            if (check.Contains(s.v2)) check.Push(s.v2);
                        }
                        
                        continue;
                    }
                    else if (check.Peek() == s.v2)
                    {
                        if (tree.ContainsKey(check.Peek())) 
                        {
                            tree.Add(s.v1, forest);
                            if (check.Contains(s.v1)) check.Push(s.v1);
                        }
                        else
                        {
                            forest++;
                            tree.Add(s.v1, forest);
                            if (check.Contains(s.v1)) check.Push(s.v1);
                        }
                        
                        continue;
                    }
                    sus++;
                }
                if (sus == rebra.Length)
                {
                    if (!tree.ContainsKey(check.Peek()))
                    {
                        foreach (Rebro s in rebra)
                        {
                            if (!tree.ContainsKey(s.v1))
                            {
                                forest++;
                                tree.Add(s.v1, forest);
                                break;
                            }
                            if (!tree.ContainsKey(s.v2))
                            {
                                forest++;
                                tree.Add(s.v2, forest);
                                break;
                            }
                        }
                    }
                    else check.Pop();
                }
               
            }


            foreach (KeyValuePair<string, int> kvp in tree)
            {
                Console.WriteLine("Вершина = {0}, Множество = {1}", kvp.Key, kvp.Value);
            }
        }
    }
}
public class Rebro
{
    public string v1;
    public string v2;
    public Rebro(string v1, string v2)
    {
        this.v1 = v1;
        this.v2 = v2;
    }
}
