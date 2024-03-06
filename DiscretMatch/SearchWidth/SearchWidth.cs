﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
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
            var tree = new Dictionary<string, int>();
            List<string> versini = new List<string>();
            List<string> check = new List<string>();
            int forest = 0;
            foreach (Rebro proverka in rebra)
            {
                if (!check.Contains(proverka.v1)) check.Add(proverka.v1);
                if (!check.Contains(proverka.v2)) check.Add(proverka.v2);
            }
            while (tree.Count != check.Count)
            {   
                while (versini.Count != 0)
                {
                    foreach (string q in versini)
                    {

                        foreach (Rebro s in rebra)
                        {
                            if (tree.ContainsKey(s.v1) && tree.ContainsKey(s.v2)) continue;
                            if (q == s.v1)
                            {
                                tree.Add(s.v2, forest);
                                versini.Add(s.v2);
                            }
                            else if (q == s.v2)
                            {
                                tree.Add(s.v1, forest);
                                versini.Add(s.v1);
                            }
                        }
                        versini.Remove(q);
                        break;
                    }
                }
                foreach (Rebro s in rebra)
                {
                    if (!tree.ContainsKey(s.v1) && !tree.ContainsKey(s.v2))
                    {
                        forest++;
                        versini.Add(s.v1);
                        versini.Add(s.v2);
                        tree.Add(s.v2, forest);
                        tree.Add(s.v1, forest);
                        break;
                    }
                }
            }

            foreach (KeyValuePair<string, int> kvp in tree)
            {
                Console.WriteLine("Вершина = {0}, Множество = {1}", kvp.Key, kvp.Value);
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
}