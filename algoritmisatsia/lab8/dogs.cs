using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication20
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите сколько будет собак");
            int amount = Convert.ToInt32(Console.ReadLine());
            dog[] dogs = new dog[amount];
            for (int i = 0; i < amount; i++)
            {
                dogs[i] = new dog();
            }

            Console.WriteLine("Какую породу собак вы хотите получить");
            string breed_exp = Console.ReadLine();
            for (int i = 0; i < amount; i++)
            {
                dogs[i].BreedCompare(breed_exp);
            }

            Console.WriteLine("Какого возроста собак вы хотите получить");
            int age_exp = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < amount; i++)
            {
                dogs[i].AgeCompare(age_exp);
            }

            Console.WriteLine("Какой цвет вы хотие поменять");
            string old_color_exp = Console.ReadLine();
            Console.WriteLine("На какой цвет вы хотие поменять");
            string new_color_exp = Console.ReadLine();
            for (int i = 0; i < amount; i++)
            {
                dogs[i].ColorChange(old_color_exp, new_color_exp);
            }
        }
    }
    class dog
    {
        private string breed;
        private string color;
        private int age;
        private string name;
        private string ident;
        private int weight;

        public dog()
        {
            Console.WriteLine("порода");
            breed = Console.ReadLine();
            Console.WriteLine("окрас");
            color = Console.ReadLine();
            Console.WriteLine("год рождения");
            age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("кличка");
            name = Console.ReadLine();
            Console.WriteLine("пол");
            ident = Console.ReadLine();
            Console.WriteLine("вес");
            weight = Convert.ToInt32(Console.ReadLine());
        }

        public void BreedCompare(String exp){
            if (exp == this.breed)
            {
                Console.WriteLine("У собаки " + this.name + " порода: " + this.breed);
            }
        }

        public void AgeCompare(int exp)
        {
            if (exp == this.age)
            {
                Console.WriteLine("У собаки " + this.name + " возраст: " + this.age);
            }
        }

        public void ColorChange(String exp_old, String exp_new)
        {
            if (exp_old == this.color)
            {
                this.color = exp_new;
                Console.WriteLine("У собаки " + this.name + " поменялся окрас с " + exp_old + " на " + exp_new);
            }
        }
    }
}
