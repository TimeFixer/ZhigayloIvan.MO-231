using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp48
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StreamReader firstFile = new StreamReader("first.txt");
            StreamReader secondFile = new StreamReader("second.txt");
            StreamWriter thirdFile = new StreamWriter("third.txt");
            {
                string line1 = firstFile.ReadLine();
                string line2 = secondFile.ReadLine();
                while (line1 != null && line2 != null)
                {
                    int value1 = Convert.ToInt32(line1);
                    int value2 = Convert.ToInt32(line2);
                    if (value1 <= value2)
                    {
                        thirdFile.WriteLine(value1);
                        line1 = firstFile.ReadLine();
                    }
                    else
                    {
                        thirdFile.WriteLine(value2);
                        line2 = secondFile.ReadLine();
                    }
                }
                while (line1 != null)
                {
                    thirdFile.WriteLine(line1);
                    line1 = firstFile.ReadLine();
                }

                while (line2 != null)
                {
                    thirdFile.WriteLine(line2);
                    line2 = secondFile.ReadLine();
                }
            }
            firstFile.Close(); secondFile.Close(); thirdFile.Close();
        }
    }
}