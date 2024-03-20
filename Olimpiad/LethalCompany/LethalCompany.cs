using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp33
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] boss;
            int Bossnumber = 0;
            string[] mass;
            List<emp> list = new List<emp>();
            string line = null;
            try
            {
                StreamReader sr = new StreamReader("input.txt");
                while (line != "END")
                {
                    bool cheker = true;
                    line = sr.ReadLine();
                    mass = line.Split(' ');
                    if (line == "END") break;
                    foreach (emp emp in list)
                    {
                        if (emp.ID == mass[0] && emp.name == "Unknown" && (mass.Length == 3))
                        {
                            emp.name = mass[1];
                            emp.fname = mass[2];
                            cheker = false;
                            break;
                        }
                        if (emp.ID == mass[0] && emp.name != "Unknown")
                        {
                            cheker = false;
                            break;
                        }
                    }
                    if (mass.Length != 3 && cheker) list.Add(new emp() { ID = mass[0], name = "Unknown", fname = "Person" });
                    else if (cheker) list.Add(new emp() { ID = mass[0], name = mass[1], fname = mass[2] });
                }
                boss = (sr.ReadLine()).Split(' ');
                if (int.TryParse(boss[0], out Bossnumber)) sr.Close();
                else foreach (emp emp in list)
                {
                    if (boss[0] == emp.name && boss[1] == emp.fname) Bossnumber = Convert.ToInt32(emp.ID);
                }
                sr.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
            foreach (emp emp in list)
            {   
                if(Convert.ToInt32(emp.ID)>Bossnumber)
                Console.WriteLine(emp.ID + " " + emp.name + " " + emp.fname);
            }
        }
    }
    class emp
    {
        public string ID;
        public string name;
        public string fname;

    }
}