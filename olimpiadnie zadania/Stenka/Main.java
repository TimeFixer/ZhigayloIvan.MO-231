import java.io.File;
import java.io.FileNotFoundException;
import java.util.Scanner;
import java.io.FileWriter;
import java.io.IOException;

public class Main
{
    public static void main(String[] args) {
        int x = 0;
        int y = 0;
        int l = 0;
        int c1 = 0;
        int c2 = 0;
        int c3 = 0;
        int c4 = 0;
        int c5 = 0;
        int c6 = 0;
        int Q = 0;

        try {
            File baza = new File("input.txt"); 
            Scanner reader = new Scanner(baza);
            x = reader.nextInt();
            y = reader.nextInt();
            l = reader.nextInt();
            c1 = reader.nextInt();
            c2 = reader.nextInt();
            c3 = reader.nextInt();
            c4 = reader.nextInt();
            c5 = reader.nextInt();
            c6 = reader.nextInt();
            reader.close();
        } catch (FileNotFoundException e) {
            System.out.println("Ошибка");
            e.printStackTrace();
        }
        int S0 = (l-y)*(c2+c3)+(2*(x+y)-l)*(c4+c5)+ y *c1;
        int S1 = (l*(c2 + c6) + (2*(x+y)) * (c4 + c5));
        int S2 = (2*(x+y)-l+(l-y))*(c4+c5)+ y *c1 + (l-y)*(c2+c6);
        int S3 = l * (c2 + c3) + (2*(x+y)-l)*(c4+c5);
        int S4 = (2*(x+y)-l)*(c4+c5) + l*c1;
        int S5 = l *(c2 + c3) + (2*(x+y)-l) *(c4 + c5);
        int S6 = c1*y + (l-y)*c2 + (2*(x+y)-y)*c3 + (l -(2*(x+y)))*c6;
        int S7 = l * c2 + (2*(x+y)) *c3 + (l -(2*(x+y)))*c6;
        int S8 = l *(c2+c6) + (2*(x+y)) * (c4+c5);
        int S9 = (l-x)*(c2+c3)+(2*(x+y)-l)*(c4+c5)+ x *c1;
        int S10 = (l*(c2 + c6) + (2*(x+y)) * (c4 + c5));
        int S11 = (2*(x+y)-l+(l-x))*(c4+c5)+ x *c1 + (l-x)*(c2+c6);
        int S12 = l * (c2 + c3) + (2*(x+y)-l)*(c4+c5);
        int S13 = c1*x + (l-x)*c2 + (2*(x+y)-x)*c3 + (l -(2*(x+y)))*c6;
        int S14 = l * c2 + (2*(x+y)) *c3 + (l -(2*(x+y)))*c6;
        int S15 = l *(c2+c6) + (2*(x+y)) * (c4+c5);
        int S16 = c1 * x + (l-x)*(c2+c6) + (2*(x+y) - x) * (c4+c5);
        int S17 = c1 * y + (l-y)*(c2+c6) + (2*(x+y) - y) * (c4+c5);
        int S18 =l*(c2 + c6) + (2*(x+y)) * (c4 + c5);
        
if (l>=(2*(x+y)))
{    
        if (x>=y)
        {
            if (S14<=S15 & S14<=S16 & S14<=S13)
            {
                Q = S14;
            }
            if (S15<=S13 & S15<=S16 & S15<=S13)
            {
                Q = S15;
            }
            if (S16<=S13 & S16<=S15 & S16<=S13)
            {
                Q = S16;
            }
        }
        else {
            if (S6<=S7 & S6<=S8 & S6<=S17)
            {
                Q = S6;
            }
            if (S7<=S8 & S7<=S17 & S7<=S6)
            {
                Q = S7;
            }
            if (S8<=S7 & S8<=S17 & S8<=S6)
            {
               Q = S8;
            }
            if (S17<=S7 & S17<=S8 & S17<=S6)
            {
                    Q = S17;
            }
            
    }
}
else
{
    if (l>=y & l>=x)
    {
        if (y>=x)
        {

            if (S0<=S1 & S0<=S2 & S0<=S3)
            {
                Q = S0;
            }
            if (S1<=S2 & S1<=S3 & S1<=S0)
            {
                Q = S1;
            }
                
            if (S2<=S3 & S2<=S0 & S2<=S1)
            {
                Q = S2;
            }
            if (S3<=S1 & S3<=S0 & S3<=S2)
            {
                Q = S3;
            }
            
        }
                
        else
        {

            if (S9<=S10 & S9<=S11 & S9<S12)
            {
                Q = S9;
            }
            if (S10<=S11 & S10<=S12 & S10<=S9)
            {
                    Q = S10;
            }
            if (S11<=S10 & S11<=S12 & S11<=S9)
            {
                Q = S11;
            }
            if (S12<=S10 & S12<=S11 & S12<=S9)
            {
                Q = S12;
            }
                
            
        }
    }
    else
    {
        if (S4<=S5 & S4<=S18)
        {
            Q = S4;
        }
        if (S5<=S18 & S5<=S4)
        {
            Q = S5;
        }
        if (S18<=S5 & S18<=S4)
        {
            Q = S18;
        }
    }
}
        System.out.println(Q);
        try {
            FileWriter myWriter = new FileWriter("output.txt"); 
            myWriter.write(String.valueOf(Q));
            myWriter.close();
        } catch (IOException e) {
            System.out.println("Ошибка");
            e.printStackTrace();
        }
    
}
}
