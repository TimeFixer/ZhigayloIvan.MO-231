using System;
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
            List<string> set = new List<string>();
            int ans = 0;
            int min = 0;
            string v = null;
            string v0 = null;
            Rebro[] rebra = new Rebro[14];
            rebra[0] = new Rebro("A", "B", 2);
            rebra[1] = new Rebro("B", "C", 2);
            rebra[2] = new Rebro("A", "C", 2);
            rebra[3] = new Rebro("A", "E", 7);
            rebra[4] = new Rebro("C", "E", 5);
            rebra[5] = new Rebro("B", "E", 2);
            rebra[6] = new Rebro("B", "D", 9);
            rebra[7] = new Rebro("E", "G", 9);
            rebra[8] = new Rebro("D", "G", 2);
            rebra[9] = new Rebro("D", "H", 16);
            rebra[10] = new Rebro("G", "H", 17);
            rebra[11] = new Rebro("D", "F", 5);
            rebra[12] = new Rebro("F", "H", 17);
            rebra[13] = new Rebro("E", "D", 10);
            List<string> versini = new List<string>();
            versini.Add("A");
            while (versini.Count < 8)
            {
                min = 0;
                v = null;
                v0 = null;
                foreach (string a in versini)
                {
                    foreach (Rebro q in rebra)
                    {
                        if (a == q.v1 || a == q.v2)
                        {
                            if (versini.Contains(q.v1) && versini.Contains(q.v2)) continue;
                            else
                            {
                                if (min == 0 || min > q.weight)
                                {
                                    min = q.weight;
                                    v = q.v1;
                                    v0 = q.v2;

                                }
                            }
                        }
                        else continue;
                    }
                }
                ans += min;
                if (versini.Contains(v))
                {
                    versini.Add(v0);
                }
                else
                {
                    versini.Add(v);
                }
            }
            Console.WriteLine(ans);
        }
    }
    public class Rebro
    {
        public string v1;
        public string v2;
        public int weight;

        public Rebro(string v1, string v2, int weight)
        {
            this.v1 = v1;
            this.v2 = v2;
            this.weight = weight;
        }

    }
}
// 2 + 2 + 2 + 9 + 2 + 5 + 16 = 38