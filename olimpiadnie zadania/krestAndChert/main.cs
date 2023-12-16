using System;    
using static System.Math;
class test{
  static void Main() {
    int ans = 0;
    int maxN = Convert.ToInt32(Console.ReadLine());
    while (maxN != 0){
            for (int Z = 2; Z < Z+1; Z++){
                if (maxN % (Math.Pow(2, Z) - 1) == 0){
                    ans++;
                }
                if (Math.Pow(2, Z) > maxN){
                    break;
                    
                }
            }
            ans++;
            maxN--;
        }
    Console.WriteLine(ans);
  }
}
