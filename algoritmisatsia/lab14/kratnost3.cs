using System;

internal class Program
{
    static void Main(string[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine());
        int min1, min2, answer, n1, n2, razn, ost, m1, m2;
        min1 = min2 = 10000;
        answer = 0;
        for (int i = 0; i < n; i++)
        {
            n1 = Convert.ToInt32(Console.ReadLine());
            n2 = Convert.ToInt32(Console.ReadLine());
            answer += Math.Max(n1, n2);
            razn = Math.Abs(n1 - n2);
            ost = razn % 3;
            if (ost > 0)
            {
                m1 = min1; m2 = min2;

                m1 = Math.Min(m1, Math.Min((razn + min1) % 3 == 1 ? razn + min1 : 1000, (razn + min2) % 3 == 1 ? razn + min2 : 1000));
                m2 = Math.Min(m2, Math.Min((razn + min1) % 3 == 2 ? razn + min1 : 1000, (razn + min2) % 3 == 2 ? razn + min2 : 1000));

                if (ost == 1) 
                { 
                    m1 = Math.Min(m1, razn); 
                }
                else { m2 = Math.Min(m2, razn); }
                min1 = m1; min2 = m2;
            }
        }
        if (answer % 3 == 0) 
        { 
            Console.WriteLine(answer); 
        }
        else if ((answer % 3 == 1) && (Math.Abs(answer - min1) % 3 == 0) && (answer - min1) > 0) 
        { 
            Console.WriteLine(answer - min1); 
        }
        else if ((answer % 3 == 2) && (Math.Abs(answer - min2) % 3 == 0) && (answer - min2) > 0) 
        { 
            Console.WriteLine(answer - min2); 
        }
        else 
        {
            Console.WriteLine("Не существует"); 
        }
    }
}