using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication15
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите количество элементов массива");
            int amount = Convert.ToInt32(Console.ReadLine());
            Person[] persons = new Person[amount];
            for (int i = 0; i < persons.Length; i++)
            {
                persons[i] = new Person();
            }

            Console.WriteLine("Введите дату рождения по которой хотите проверить людей");
            int ageExmp = Convert.ToInt32(Console.ReadLine());
            foreach (Person person in persons){
                if (ageExmp == person.birth_date)
                {
                    person.Print();
                }
                else { Console.WriteLine("Не найдено людей"); }
            }
            Console.WriteLine("Введите ФИО по которой хотите проверить людей");
            String nameExmp = Console.ReadLine();
            foreach (Person person in persons)
            {
                if (nameExmp == person.name)
                {
                    person.Print();
                }
                else { Console.WriteLine("Не найдено людей"); }
            }
            Console.WriteLine("Введите Образование по которой хотите проверить людей");
            String educ = Console.ReadLine();
            foreach (Person person in persons)
            {
                if (educ == person.education)
                {
                    person.Print();
                }
                else { Console.WriteLine("Не найдено людей"); }
            }
        }
    }

    class Person
    {
        public int birth_date;
        public string name;
        public string education;
        public string addres;
        public Person()
        {
            Console.WriteLine("Создание объекта Person");
            Console.Write("Введите ФИО: ");
            name = Console.ReadLine();
            Console.Write("Введите дату рождения: ");
            birth_date = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите образование: ");
            education = Console.ReadLine();
            Console.Write("Введите аддрес: ");
            addres = Console.ReadLine();
        }
        public void Print()
        {
            Console.WriteLine("имя "+ this.name + " образование " + this.education + " год рождения " + this.birth_date + " аддрес " + this.addres);
        }
    }
}
