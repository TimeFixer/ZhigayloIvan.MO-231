// двумерный массив
// 1) определить кол-во строк в котором и минимальный и максимальный элемент - чётные;
// 2) выдать номера столбцов в котором все элементы положительные;
// 3) посчитать кол-во нулевых элементов во всём массиве;
// 4) определить имеется ли в массиве строка с нулевой ссумой;
// 5) определить кол-во пар строк состоящих из одинаковых элементов;
using System;
class HelloWorld {
  static void Main() {
            Console.WriteLine("Введите количество строк");
      int strok = Convert.ToInt32(Console.ReadLine());
      Console.WriteLine("Введите количество столбцов");
      int stolb = Convert.ToInt32(Console.ReadLine());
      
      int a1 = 0, a2 = 0, ans1 = 0, ans3 = 0, ans4=0, ans5 = 0, n = 0, f = 0;
      bool d = false;
      
      int [,] mass = new int [strok, stolb];
      
      Console.WriteLine("Введите элементы в массив");
      for (int i = 0; i < strok; i++)
        {
            for (int j = 0; j < stolb; j++)
            {
                mass[i, j] = Convert.ToInt32(Console.ReadLine());
            }
        }
        // первый
        for (int i = 0; i < strok; i++)
        {
            a1 = mass[i, 0];
            a2 = mass[i, 1];
            for (int j = 1; j < stolb; j++)
            {
                if (a1 < mass[i, j] & a1 % 2 == 0)
                {
                    a1 = mass[i, j];
                }
                if (a2 < mass[i, j] & a2 % 2 == 0)
                {
                    a2 = mass[i, j];
                }
            }
            if (a1 % 2 == 0 & a2 % 2 == 0)
            {
                ans1++;
            }
        }
        // второй
                for (int i = 0; i < strok; i++)
        {
            for (int j = 0; j < stolb; j++)
            {
                if(mass[i, j]>=0){
                    n++;
                }
            }
            if(n == stolb){
                Console.WriteLine((i+1)+" строка, где все элементы положительные");
            }
            n = 0;
        }
        // третий
        for (int i = 0; i < strok; i++){
            for (int j = 0; j < stolb; j++)
            {
                if (mass[i, j] == 0)
                {
                    ans3++;
                }
            }
        }
        // четвёртый
                 for (int i = 0; i < strok; i++)
        {
            for (int j = 0; j < stolb; j++)
            {
                ans4 += mass[i, j];
            }
        if(ans4 ==0){
            d = true;
        }
        ans4 = 0;
        }
        // пятый
        for (int i=0;i<strok;i++){
            for (int k=0;k<strok;k++){
                for (int j=0;j<stolb;j++){
                    if(i == k & (k+1) != strok){
                        k++;
                    }
                    if(mass[i, j] == mass[k, j]){
                        f++;
                    }
                    Console.WriteLine(f);
                }
            
            if(f == stolb){
                ans5++;
            }
            f = 0;
                
            }
 
        }
        
        
        
        ans5 = ans5/2;
        Console.WriteLine(ans1 + " строк в котором и минимальный и максимальный элемент - чётные");
        Console.WriteLine(ans3 + " нулевых элементов во всём массиве");
        if (d == true){
            Console.WriteLine("имеется строка с нулевой суммой");
        }
        else{
            Console.WriteLine("не имеется строка с нулевой суммой");
        }
        Console.WriteLine(ans5 + " пар строк состоящих из одинаковых элементов");
  }
}




