// Используется линейная зависимость
// имеются города n штука, имеется растояние между городами, необходимо расположить одну заправку таким образом
// Чтобы суммарное расстояние от города до заправки было минимальным, при этом заправку нельзя расположить ближе чем на k км от города.
// подаём на вход 1 количество городов 2 расстояние между городами 3 значение k ограничение к которому ближе заправку поставить нельзя
// 
using System;
class HelloWorld {
  static void Main() {
      int Ans=0, Q=0, buffer = 0, Ne=0;
    Console.WriteLine("Введите количество городов");
    int n = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите растояние между городами");
    int[] mass = new int[(n-1)];
    for (int i = 0; i<(n-1); i++) {
        mass[i] = Convert.ToInt32(Console.ReadLine());
        Ans += mass[i];
        }    
    Ans = Ans / 2;
    Console.WriteLine("Введите значение k");
    int k = Convert.ToInt32(Console.ReadLine());
    for (int i = 0; i < (n-1); i++){
        if(mass[i]<2*k){
            Ne++;
        }
        Q += mass[i];
        if (Q<Ans ){
            buffer += mass[i];
        }
        if (Q>Ans){
            if (Q-buffer>2*k){
                if (Ans-buffer>=k && Q-Ans<=k){
                Console.WriteLine("Заправку нужно поставить на " + Ans);
                break;
            }
                else {
                    Ans = buffer + k;
                    Console.WriteLine("Заправку нужно поставить на " + Ans);
                    break;
                }
            } if(Q-((Q-buffer)/2)<=Ans){
                Ans = Q + k;
                Console.WriteLine("Заправку нужно поставить на " + Ans);
                break;
            } else if (Q-((Q-buffer)/2)>=Ans){
                Ans = buffer + k;
                Console.WriteLine("Заправку нужно поставить на " + Ans);
                    break;
            }

       }
        
    }
    if (Ne == (n-1)){
         Console.WriteLine("Заправку поставить нигде нельзя");
    }
  }
}