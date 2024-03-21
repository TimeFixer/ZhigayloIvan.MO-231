using System;
using System.Collections;
using System.Collections.Generic;
class Program
{
    static void Main()
    {
        Hashtable ht = new Hashtable();
        Dictionary<string, string> slov = new Dictionary<string, string>();
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
            int min = 0;
            string value;
            string data = dataQueue.Dequeue();
            string[] parts = data.Split(' ');
            string phoneNumber = parts[0];
            string phoneCall = parts[1];
            int minutes = int.Parse(parts[3]);
            if (slov.ContainsKey(phoneNumber))
            {   
                slov.TryGetValue(phoneNumber, out value);
                string[] f = value.Split(' ');
                slov.Remove(phoneNumber);
                min = minutes + Convert.ToInt32(f[1]);
                string forthevalue1 = f[0] + '.' + phoneCall + ' ' + min;
                slov.Add(phoneNumber, forthevalue1);
            }
            else
            {
                string forthevalue = phoneCall + " " + minutes;
                slov.Add(phoneNumber, forthevalue);
            }
      }
      int buffer = 0;
      string bufferNum = null;
      string key = null;
        bool check = true;
        string toSave = null;
        while (check == true)
        {
            foreach (var slot in slov)
            {
                buffer = 0;
                if (slot.Value.Contains("."))
                {
                    int checkThere = 1;
                    bufferNum = null;
                    string[] parts0 = slot.Value.Split(' ');
                    string[] parts1 = parts0[0].Split('.');
                    key = slot.Key;
                    Array.Sort(parts1);
                    for (int i = 1; i < parts1.Length; i++)
                    {
                        if (parts1[i] == parts1[i - 1])
                        {
                            checkThere++;
                        }
                        if ((parts1[i] != parts1[i - 1] && checkThere > buffer) || buffer == 0)
                        {
                            bufferNum = parts1[i-1];
                            buffer = checkThere;
                            toSave = bufferNum + " " + parts0[1];
                        }
                    }
                    break;
                }
                else continue;
            }
            if (buffer != 0)
            {
                slov.Remove(key);
                slov.Add(key, toSave);
                continue;
            }
            check = false;
        }
        foreach (var slot in slov)
        {
            ht.Add(slot.Key, slot.Value);
        }
        Console.WriteLine("Информацию по какому номеру хотите получить?");
        string ans = Console.ReadLine();
        string ans1 = null;
        slov.TryGetValue(ans, out ans1);
        ICollection с = ht.Keys;
        foreach (string str in с)
        {
            if (ans == str)
            {
                string sus = Convert.ToString(ht[str]);
                string[] partex1 = sus.Split(' ');
                Console.WriteLine("(информация из хештаблицы) Звонил чаще по номеру: " + partex1[0] + " и говорил вообщем в минутах за всё время: " + partex1[1]);
            }
        }
        string[] partsex = ans1.Split(' ');
        Console.WriteLine("(информация из словаря) Звонил чаще по номеру: " + partsex[0] + " и говорил вообщем в минутах за всё время: " + partsex[1]);
    }
}