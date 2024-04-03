using System;
using System.Collections.Generic;
namespace ConsoleApp41
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Rebro[] rebra = new Rebro[12];
            rebra[0] = new Rebro("1", "2", 4);
            rebra[1] = new Rebro("1", "5", 3);
            rebra[2] = new Rebro("1", "6", 5);
            rebra[3] = new Rebro("2", "5", -4);
            rebra[4] = new Rebro("2", "6", 4);
            rebra[5] = new Rebro("3", "2", -1);
            rebra[6] = new Rebro("3", "4", 3);
            rebra[7] = new Rebro("3", "6", 3);
            rebra[8] = new Rebro("4", "7", 2);
            rebra[9] = new Rebro("5", "3", 6);
            rebra[10] = new Rebro("6", "4", 3);
            rebra[11] = new Rebro("7", "3", -2);
            Dictionary<string, string> Ans = new Dictionary<string, string>();
            List<string> vers = new List<string>();
            Ans.Add(rebra[0].v1, "0 1");
            vers.Add(rebra[0].v1);
            int flag = 0;
            bool breakflag = false;
            while (flag != 8)
            {
                string buffer = null;
                int Vbuffer = 0;
                foreach (Rebro s in rebra)
                {
                    if (vers.Contains(s.v1) && !Ans.ContainsKey(s.v2))
                    {
                        Ans.TryGetValue(s.v1, out string exmp);
                        string[] parts = exmp.Split(new char[] { ' ' });
                        Ans.Add(s.v2, Convert.ToString(s.weight + Convert.ToInt32(parts[0])) + " " + parts[1] + "--->" + s.v2);
                        if ((buffer == null || Vbuffer > (s.weight + Convert.ToInt32(parts[0]))) && !vers.Contains(s.v2))
                        {
                            buffer = s.v2;
                            Vbuffer = s.weight + Convert.ToInt32(parts[0]);
                        }
                    }
                    else if (vers.Contains(s.v1) && Ans.ContainsKey(s.v2))
                    {
                        Ans.TryGetValue(s.v2, out string exmp2);
                        string[] parts2 = exmp2.Split(new char[] { ' ' });
                        Ans.TryGetValue(s.v1, out string exmp1);
                        string[] parts1 = exmp1.Split(new char[] { ' ' });
                        if (!vers.Contains(s.v2) && (buffer == null || Vbuffer > (s.weight + Convert.ToInt32(parts1[0]))))
                        {
                            buffer = s.v2;
                            Vbuffer = s.weight + Convert.ToInt32(parts1[0]);
                        }
                        if (Convert.ToInt32(parts2[0]) > (s.weight + Convert.ToInt32(parts1[0])))
                        {
                            Ans[s.v2] = Convert.ToString(s.weight + Convert.ToInt32(parts1[0])) + " " + parts1[1] + "--->" + s.v2;
                            if (flag == 7) breakflag = true;
                        }
                    }
                }
                if (buffer != null)vers.Add(buffer);
                if (breakflag)
                {
                    Console.WriteLine("Образуется отрицательный цикл");
                    return;
                }
                flag++;
            }
            foreach (KeyValuePair<string, String> kvp in Ans)
            {
                string[] anspart = kvp.Value.Split(new char[] { ' ' });
                Console.WriteLine("Вершина = {0}, Кратчайший путь = {1}, Путь до вершины: {2}", kvp.Key, anspart[0], anspart[1]);
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
}