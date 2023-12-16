using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication18
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите количество книг");
            int amount = Convert.ToInt32(Console.ReadLine());
            KNIGGA[] bible = new KNIGGA[amount];
            for (int i = 0; i < bible.Length; i++)
            {
                bible[i] = new KNIGGA();
            }

            Console.WriteLine("Проверка на дату выдачи. Введите месяц");
            string monthExmp = Console.ReadLine();
            foreach (KNIGGA KNIGGA in bible)
            {
                for (int j = 0; j < KNIGGA.o; j++)
                {
                    if (monthExmp == KNIGGA.publish[j])
                    {
                        KNIGGA.Print();
                        break;
                    }
                }

            }
            Console.WriteLine("Проверка на год издания. Введите год позже которого должны быть выпущены книги");
            int godExmp = Convert.ToInt32(Console.ReadLine());
            foreach (KNIGGA KNIGGA in bible)
            {
                if (godExmp < KNIGGA.birth_book)
                {
                    KNIGGA.Print();
                }
            }
            Console.WriteLine("Проверка на автора. Введите ФИО автора");
            string autorExmp = Console.ReadLine();
            foreach (KNIGGA KNIGGA in bible)
            {
                if (autorExmp == KNIGGA.name_autor)
                {
                    KNIGGA.Print();
                }
            }

        }
    }
    class KNIGGA
    {
        public int birth_book;
        public string name_autor;
        public string name_book;
        public int o;
        public string[] publish;

        public KNIGGA()
        {
            Console.WriteLine("Создание объекта KNIGGA");
            Console.Write("Введите год издания: ");
            birth_book = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите ФИО автора: ");
            name_autor = Console.ReadLine();
            Console.Write("Введите название книги: ");
            name_book = Console.ReadLine();
            Console.Write("Введите количество месяцев: ");
            o = Convert.ToInt32(Console.ReadLine());
            publish = new string[o];
            Console.Write("Введите месяца: ");
            for (int i = 0; i < o; i++)
            {
                publish[i] = Console.ReadLine();
            }
        }


        public void Print()
        {
            Console.Write("Книга: " + this.name_book + ". ФИО автора: " + this.name_autor + ". Год издания: " + this.birth_book + ". Даты выдачи книги: " );
            for (int i = 0; i < this.o; i++)
            {
                if (i == this.o - 1)
                {
                    Console.WriteLine(this.publish[i] + " ");
                }
                else
                {
                    Console.Write(this.publish[i] + " ");
                }
            }
        }
    }
}
