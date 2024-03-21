using System;
using System.Collections;
using System.Collections.Generic;
namespace ConsoleApp37
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Hashtable ht = new Hashtable();
            Dictionary<string, int> slov = new Dictionary<string, int>();
            Queue<string> dataQueue = new Queue<string>();
            dataQueue.Enqueue("89000000 89222222 10.02.2024 5");
            dataQueue.Enqueue("89333333 89000000 18.02.2024 7");
            dataQueue.Enqueue("89222222 89444444 01.03.2024 9");
            dataQueue.Enqueue("89000000 89111111 21.03.2024 3");
            dataQueue.Enqueue("89000000 89555555 05.03.2024 2");
            dataQueue.Enqueue("89000000 89111111 05.03.2024 1");
            dataQueue.Enqueue("89000000 89111111 05.03.2024 1");
            dataQueue.Enqueue("89111111 89222222 11.03.2024 8");
            dataQueue.Enqueue("89111111 89222222 20.03.2024 12");
            List<string> list = new List<string>();

            while (dataQueue.Count > 0)
            {
                string data = dataQueue.Dequeue();
                string[] parts = data.Split(' ');
                string Date = parts[2];
                int min = Convert.ToInt32(parts[3]);
                if (slov.ContainsKey(Date))
                {
                    slov[Date] += min;
                }
                else
                {
                    slov[Date] = min;
                }
            }
            foreach (var slot in slov)
            {
                ht.Add(slot.Key, slot.Value);
            }
            Console.WriteLine("Информацию по какой дате хотите получить?");
            string ans = Console.ReadLine();
            int ans1 = 0;
            slov.TryGetValue(ans, out ans1);
            ICollection с = ht.Keys;
            foreach (string str in с)
            {
                if (ans == str)
                {
                    Console.WriteLine("(информация из хештаблицы) Всего за выбранную дату было использовано: " + ht[str] + " минут");
                }
            }
            Console.WriteLine("(информация из словаря) Всего за выбранную дату было использовано: " + ans1 + " минут");
        }
    }
}
