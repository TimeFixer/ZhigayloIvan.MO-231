using System;
using System.Collections.Generic;
using System.IO;
class Program
{
    static void Main(string[] args)
    {
        string spell = null;
            List<string> List = new List<string>();
            foreach (var line in File.ReadLines("input.txt")) List.Add(line);
            Dictionary<int, string> results = new Dictionary<int, string>();
            for (int j = 0; j < List.Count; j++)
            {
                string str = List[j];
                string[] parts = str.Split(' ');
                string iteration = parts[0];
                string result = null;
                for (int k = 1; k < parts.Length; k++)
                {
                    if (int.TryParse(parts[k], out int num)) result += results[num];
                    else result += parts[k];
                }
                switch (iteration)
                {
                    case "MIX":
                        result = "MX" + result + "XM";
                        break;
                    case "WATER":
                        result = "WT" + result + "TW";
                        break;
                    case "DUST":
                        result = "DT" + result + "TD";
                        break;
                    case "FIRE":
                        result = "FR" + result + "RF";
                        break;
                }
                results.Add(j + 1, result);
                spell = result;
            }
            StreamWriter output = new StreamWriter("output.txt");
            output.Write(spell); output.Close();
    }
}