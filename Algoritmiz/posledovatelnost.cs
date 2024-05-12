using System;
using System.IO;
class HelloWorld {
  static void Main() {
     int anscount = 0;
    StreamReader a = new StreamReader("input.txt");
    string iteration = a.ReadLine();
    string ans = iteration;
    bool flag = true;
        while (iteration != null){
            int count = 0; int buffIter = 0;
            foreach(char abr in iteration){
                if(abr =='a') count++;
                else{
                    if (buffIter < count) {
                    buffIter = count;
                    count = 0;
                    }
                }
            }
            if (buffIter < anscount || flag == true){
                ans = iteration;
                anscount = buffIter;
                flag = false;
                }
            iteration = a.ReadLine();
        }
        Console.WriteLine(ans);
  }
}