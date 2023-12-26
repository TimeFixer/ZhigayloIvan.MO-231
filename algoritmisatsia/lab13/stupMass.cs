class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Сколько строк в ступенчатом массиве?");
        int strok = Convert.ToInt32(Console.ReadLine());
        int[][] StupMass = new int[strok][];
        int[] mnojestvo = new int[strok];
        for (int i = 1; i <= strok; i++)
        {
            Console.WriteLine("Сколько элементов в " + i + " массиве?");
            mnojestvo[i - 1] = Convert.ToInt32(Console.ReadLine());
        }
        for (int i = 1; i <= strok; i++)
        {
            Console.WriteLine("Вводите элементы в " + i  + " массив");
            StupMass[i-1] = new int[mnojestvo[i-1]];
            for (int j = 0; j < mnojestvo[i-1]; j++) { StupMass[i-1][j] = Convert.ToInt32(Console.ReadLine()); }
        }
        Console.WriteLine("\nЭлементы которые входят в пересечение всех множеств:");
        for (int i = 0; i < StupMass[^1].Length; i++)
        {
            bool proverka = true;
            for (int j = 0; j < strok - 1; j++) { if (!StupMass[j].Contains(StupMass[^1][i])) { proverka = false; } }
            if (proverka == true) { Console.Write($"{StupMass[^1][i]} "); }
        }
        Console.WriteLine("\nЭлементы которые входят в объединение всех множеств:");
        for (int i = 0; i < strok; i++)
        {
            for (int j = 0; j < StupMass[i].Length; j++)
            {
                bool proverka = true;
                for (int k = i + 1; k < strok; k++)
                {
                    if (StupMass[k].Contains(StupMass[i][j])) { proverka = false; }
                }
                if (proverka == true) { Console.Write($"{StupMass[i][j]} "); }
            }
        }
        for (int i = 0; i < strok; i++)
        {
            Console.WriteLine("\nДополнение к каждому множеству " + i + " относительно объединения:");
            for (int j = 0; j < strok; j++)
            {
                if (j != i)
                {
                    for (int k = 0; k < StupMass[j].Length; k++)
                    {
                        if (!StupMass[i].Contains(StupMass[j][k])) { Console.Write($"{StupMass[j][k]} "); }
                    }
                }
            }
        }
    }
}