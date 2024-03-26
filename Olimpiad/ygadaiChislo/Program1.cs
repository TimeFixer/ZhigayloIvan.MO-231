using System;
using System.IO;
namespace ConsoleApp39
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int kof = 1;
            int free = 0;
            StreamReader reader = new StreamReader("input.txt");
            int n = Convert.ToInt32(reader.ReadLine());
            while (n != 0) 
            {
                string[] line = reader.ReadLine().Split(' ');
                switch (line[0])
                {
                    case "*":
                    kof *= Convert.ToInt32(line[1]);
                    free *= Convert.ToInt32(line[1]);
                        break;
                    case "/":
                    kof /= Convert.ToInt32(line[1]);
                    free /= Convert.ToInt32(line[1]);
                        break;
                    case "+":
                        if (line[1] == "x") kof++;
                        else free += Convert.ToInt32(line[1]);
                        break;
                    case "-":
                        if (line[1] == "x") kof--;
                        else free -= Convert.ToInt32(line[1]);
                        break;
                }
                n--;
            }
            int ans = Convert.ToInt32(reader.ReadLine());
            Console.WriteLine((ans-free)/kof);
        }
    }
}