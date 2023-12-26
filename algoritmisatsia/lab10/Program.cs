using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication26
{
    class Programm{
        static void Main() {
    String name1 = "Цех 1", name2 = "Цех 2", name3 = "Объединенный заводческий цех города Кушкек";
Workshop[] workshops = new Workshop[15];workshops[0] = new Workshop(name1, 2010, 100);
workshops[1] = new Workshop(name2, 2011, 1100);workshops[2] = new Workshop(name3, 2010, 800);
workshops[3] = new Workshop(name1, 2012, 90);workshops[4] = new Workshop(name2, 2012, 1200);
workshops[5] = new Workshop(name3, 2012, 600);workshops[6] = new Workshop(name1, 2013, 200);
workshops[7] = new Workshop(name2, 2013, 300);workshops[8] = new Workshop(name3, 2013, 400);
workshops[9] = new Workshop(name1, 2015, 100);workshops[10] = new Workshop(name2, 2015, 350);
workshops[11] = new Workshop(name3, 2015, 700);workshops[12] = new Workshop(name1, 2017, 130);
workshops[13] = new Workshop(name2, 2017, 700);workshops[14] = new Workshop(name3, 2017, 900);
Console.WriteLine("Суммарный объем выпуска образования " + name1 + ": " + workshops[0].getSumOfProduction(name1, workshops));
Console.WriteLine("Суммарный объем выпуска образования " + name2 + ": " + workshops[0].getSumOfProduction(name2, workshops));Console.WriteLine("Суммарный объем выпуска образования " + name3 + ": " + workshops[0].getSumOfProduction(name3, workshops));
Console.WriteLine("Интенсивность производства по годам для образования " + workshops[0].getProductionByYear(name1, workshops));Console.WriteLine("Интенсивность производства по годам для образования " + workshops[0].getProductionByYear(name2, workshops));
Console.WriteLine("Интенсивность производства по годам для образования " + workshops[0].getProductionByYear(name3, workshops));
        }
    }
class Workshop
{    private String Name;
    private int Year;    private int ValueOfProduction;
    public Workshop(String Name, int Year, int ValueOfProduction)
    {        this.Name = Name;
        this.Year = Year;        this.ValueOfProduction = ValueOfProduction;
    }
    public String getName(Workshop workshop)    {
        return workshop.Name;    }
    public int getYear(Workshop workshop)
    {        return workshop.Year;
    }
    public int getValueOfProduction(Workshop workshop)    {
        return workshop.ValueOfProduction;    }
    public void setName(Workshop workshop, String name)
    {        workshop.Name = name;
    }    public void setYear(Workshop workshop, int year)
    {        workshop.Year = year;
    }    public void setValueOfProduction(Workshop workshop, int valueOfProduction)
    {        workshop.ValueOfProduction = valueOfProduction;
    }
    public int getSumOfProduction(String name, Workshop[] workshops)    {
        int sum = 0;        for(int i = 0; i < workshops.Length; i++)
        {            if (workshops[i].getName(workshops[i]) == name)
            {                sum = sum + workshops[i].getValueOfProduction(workshops[i]);
            }        }
        return sum;    }
    public String getProductionByYear(String name, Workshop[] workshops)
    {        String productionByYear = "" + name + ": \n";
        for (int i = 0; i < workshops.Length; i++)        {
            if (workshops[i].getName(workshops[i]) == name)            {
                productionByYear = productionByYear + workshops[i].getYear(workshops[i]) + ": " + workshops[i].getValueOfProduction(workshops[i]) + "\n";            }
        }        return productionByYear;
    }}}
    /*class Program
    {
        static void Main(string[] args)
        {
             Console.WriteLine("Введите количество цехов");
            int amount = Convert.ToInt32(Console.ReadLine());
            shop[] shops = new shop[amount];
            for (int i = 0; i < shops.Length; i++)
            {
                shops[i] = new shop();
            }

        }
        class shop
    {
        public string name;
        public int o;
        public int[] year; 
        public int[] ammount;

        public shop()
        {
            Console.WriteLine("Создание объекта цеха");
            Console.Write("Введите название цеха: ");
            name = Console.ReadLine();
            Console.Write("Введите кол-во лет выпуска: ");
            o = Convert.ToInt32(Console.ReadLine());
            year = new int[o];
            ammount = new int[o];
            Console.Write("Введите года и сколько цех выпустил: ");
            for (int i = 0; i < o; i++)
            {
                year[i] = Convert.ToInt32(Console.ReadLine());
                ammount[i] = Convert.ToInt32(Console.ReadLine());
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
    }
}
*/
