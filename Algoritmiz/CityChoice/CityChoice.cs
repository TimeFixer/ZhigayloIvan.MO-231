using System;
using System.Collections.Generic;
using System.IO;
namespace ConsoleApp46
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> list = new List<string>();
            Console.WriteLine("На какую букву должен начинаться город?");
            char charAns1 = Convert.ToChar(Console.ReadLine());
            Console.WriteLine("Города какой страны вам нужны?");
            string countryAns2 = Console.ReadLine();
            Console.WriteLine("Какой минимум жителей там должен быть?");
            int intAns1 = Convert.ToInt32(Console.ReadLine());
            StreamReader read = new StreamReader("input.txt");
            StreamWriter charans = new StreamWriter("output.txt");
            StreamWriter countryans = new StreamWriter("output0.txt");
            StreamWriter intans = new StreamWriter("output1.txt");
            string lineexm = read.ReadLine();
            while (lineexm != null)
            {
                list.Add(lineexm);
                lineexm = read.ReadLine();
            }
            read.Close();
            foreach (string line in list)
            {
                string[] parts = line.Split(' ');
                foreach (char part in parts[0])
                {
                    if (Convert.ToChar(part) == charAns1)
                    {
                        charans.WriteLine(parts[0] + " " + parts[1] + " " + parts[2]);
                    }
                    break;
                }
                if (parts[1] == countryAns2)
                {
                    countryans.WriteLine(parts[0] + " " + parts[1] + " " + parts[2]);
                }
                if (Convert.ToInt32(parts[2]) >= intAns1)
                {
                    intans.WriteLine(parts[0] + " " + parts[1] + " " + parts[2]);
                }
            }
            charans.Close(); countryans.Close(); intans.Close();
        }
    }
}