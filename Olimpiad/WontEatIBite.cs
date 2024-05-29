using System.IO;
using System.Linq;
using System;
class HelloWorld
{
    static void Read(out int a, out int b, StreamReader file)
    {
        string s = file.ReadLine();
        string[] str = s.Split(' ');
        a = int.Parse(str[0]);
        b = int.Parse(str[1]);
    }
    struct stvetv
    {
        public int number;
        public int K;
        public int L;
        public bool Apple;
        public int S;
        public bool processed; 
    }
    static void ParseFile(out int N, out int M, out int X, out int Z, out stvetv[] vetv)
    {
        StreamReader input_file = new StreamReader("input.txt");
        Read(out N, out M, input_file);
        vetv = new stvetv[N];
        for (int i = 0; i < N; i++)
        {
            vetv[i].number = i + 1;
            vetv[i].processed = false;
            Read(out vetv[i].K, out vetv[i].L, input_file);
            vetv[i].Apple = false;
        }
        for (int i = 0; i < M; i++)
        {
            int c, s;
            Read(out c, out s, input_file);
            vetv[c - 1].S = s;
            vetv[c - 1].Apple = true;
        }
        Read(out X, out Z, input_file);
        input_file.Close();
    }
    static bool GetNum(int Vetvindex, stvetv[] Vetvarr, ref int path, ref int longpath, int Z, int path_to_vertex)
    {
        bool finded = false;
        var VetvVersh = from p in Vetvarr
                                where p.K == Vetvindex
                                select p;
        foreach (var i in VetvVersh)
        {
            if (i.processed == false)
            {
                Vetvarr[i.number - 1].processed = true;
                if ((i.Apple) && (i.S >= Z))
                {
                    path += 2 * i.L;
                    if (longpath < path_to_vertex + i.L)
                        longpath = path_to_vertex + i.L;
                    finded = true;
                }
                else
                {
                    if(GetNum(i.number, Vetvarr, ref path, ref longpath, Z, path_to_vertex + i.L))
                        path += 2 * i.L;
                }
            }
        }
        if (Vetvindex > 0) 
        {
            if (Vetvarr[Vetvindex - 1].processed == false)
            {
                Vetvarr[Vetvindex - 1].processed = true;
                path += 2 * Vetvarr[Vetvindex - 1].L;
                GetNum(Vetvarr[Vetvindex - 1].K, Vetvarr, ref path, ref longpath, Z, path_to_vertex + Vetvarr[Vetvindex - 1].L);
            }
        }
        return finded;
    }
    static void Main(string[] args)
    {
        int N, M, X, Z;
        stvetv[] vetv;
        int path = 0;
        int longpath = 0;
        ParseFile(out N, out M, out X, out Z, out vetv);
        GetNum(X, vetv, ref path, ref longpath, Z, 0);
        path = path - longpath;
        StreamWriter output_file = new StreamWriter("output.txt");
        output_file.WriteLine(path);
        output_file.Close();
    }
}
        output_file.Close();
    }
}
