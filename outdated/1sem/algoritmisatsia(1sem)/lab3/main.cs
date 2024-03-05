using System;
class HelloWorld {
  static void Main() {
    Console.WriteLine("Введите количество элементов");
    int n=Convert.ToInt32(Console.ReadLine());
    int pred=0, ANS2=0, ANS3=0, Q=0, buffer1=0, buffer2=0, chet1=0,chet2=0;
    Console.WriteLine("Перечислите элементы");
    for ( int i = 1; i<=n; i++){
        int A = Convert.ToInt32(Console.ReadLine());
        // убывание
        if((pred-A) == Q){
            ANS3++;
        }
        
        if(pred != 0 & Q ==0){
            Q = pred-A;
        }
        // кратность
        if (A%i == 0){
            ANS2++;
        }
        //различные элементы
        if (A != pred & pred!=0){
                chet1++;
            }
            else{
                if (buffer1 == 0){
                    buffer1 = chet1;
                }
                else{
                    if (chet1 > buffer1){
                        buffer1 = chet1;
                    }
                }
                chet1 = 0;
            }
        //одинаковые элементы
        if (A == pred){
                chet2++;
            }
            else{
                if (buffer2 == 0){
                    buffer2 = chet2;
                }
                else{
                    if (chet2 < buffer2){
                        buffer2 = chet2;
                    }
                }
                chet2 = 0;
            }
        
        pred = A; 
    }
    if (chet2 < buffer2 & chet2 != 0){
        chet2++;
        Console.WriteLine("наименьшая длина подпоследовательности, состоящей из одинаковых элементов равна " + chet2);
    }
    else{
        buffer2++;
        Console.WriteLine("наименьшая длина подпоследовательности, состоящей из одинаковых элементов равна " + buffer2);
    }
    if (chet1 > buffer1){
        chet1++;
        Console.WriteLine("максимальная длина подпоследовательности состоящей из различных элементов равна " + chet1);
    }
    else{
        buffer1++;
        Console.WriteLine("максимальная длина подпоследовательности состоящей из различных элементов равна " + buffer1);
    }






    if(ANS2 == n){
       Console.WriteLine("все элементы последовательности кратны номеру под которым они считываются"); 
    }
    else{
        Console.WriteLine("не все элементы последовательности кратны номеру под которым они считываются");
    }
    if(ANS3 == (n-2) & Q>0){
        Console.WriteLine("заданная последовательность образует равномерно убывающую последовательность элементов");
    }
    else{
        Console.WriteLine("заданная последовательность не образует равномерно убывающую последовательность элементов");
    }
  }
}







