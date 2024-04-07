using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace ConsoleApp44
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool flag = false;
            while(flag == false)
            {
                Console.WriteLine("\nВыберите тип данных для работы:");
                Console.WriteLine("1. Целые числа");
                Console.WriteLine("2. Вещественные числа");
                Console.WriteLine("0. Выход\n");
                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.WriteLine("\nВведите два целых числа");
                        int choice1 = int.Parse(Console.ReadLine());
                        int choice2 = int.Parse(Console.ReadLine());
                        Console.WriteLine("Сложение " + Add(choice1, choice2));
                        Console.WriteLine("Вычитание " + Subtract(choice1, choice2));
                        Console.WriteLine("Умножение " + Multiply(choice1, choice2));
                        Divide(choice1, choice2);
                        break;
                    case 2:
                        Console.WriteLine("\nВведите два вещественных числа");
                        double Doublechoice1 = double.Parse(Console.ReadLine());
                        double Doublechoice2 = double.Parse(Console.ReadLine());
                        Console.WriteLine("Сложение " + AddDouble(Doublechoice1, Doublechoice2));
                        Console.WriteLine("Вычитание " + SubtractDouble(Doublechoice1, Doublechoice2));
                        Console.WriteLine("Умножение " + MultiplyDouble(Doublechoice1, Doublechoice2));
                        DivideDouble(Doublechoice1, Doublechoice2);
                        break;
                    case 0:
                        flag = true;
                        break;
                    default:
                        Console.WriteLine("\nНеверный выбор");
                        break;
                }
            }
        }
        static public int Add(int a, int b)
        {
            return a + b;
        }
        static public int Subtract(int a, int b)
        {
            return a - b;
        }
        static public int Multiply(int a, int b)
        {
            return a * b;
        }
        static public void Divide(int a, int b)
        {
            if (b == 0)
            {
                Console.WriteLine("Деление на ноль!");
            }
            else if (a % b != 0)
            {
                Console.WriteLine("Неполноценное деление, целая часть равна " + a / b);
            }
            else Console.WriteLine("Деление " + a / b);
            return;
        }
        static public double AddDouble(double a, double b)
        {
            return Math.Round(a + b, 8);
        }
        static public double SubtractDouble(double a, double b)
        {
            return Math.Round(a - b, 8);
        }
        static public double MultiplyDouble(double a, double b)
        {
            return Math.Round(a * b, 8);
        }
        static public void DivideDouble(double a, double b)
        {
            if (b == 0)
            {
                Console.WriteLine("Деление на ноль!");
                return;
            }
            Console.WriteLine("Деление " + Math.Round(a / b, 8));
        }
    }
}
