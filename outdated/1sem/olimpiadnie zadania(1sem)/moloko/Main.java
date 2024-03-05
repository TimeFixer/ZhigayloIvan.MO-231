import java.io.File;
import java.io.FileNotFoundException;
import java.util.Scanner;
import java.io.FileWriter;
import java.io.IOException;

public class Main
{
    public static void main(String[] args) { 
        int n = 0;
        int x1 = 0;
        int y1 = 0;
        int z1 = 0;
        int x2 = 0;
        int y2 = 0;
        int z2 = 0;
        float c1 = 0;
        float c2 = 0;
        float answer = 0;
        int Q = 0;
       
        try {
            File baza = new File("input.txt"); 
            Scanner reader = new Scanner(baza);
            n = reader.nextInt();
        for (int i = 0; i<n; i++){
            
            //try {
            //File baza = new File("input.txt"); 
            //Scanner reader = new Scanner(baza);
            x1 = reader.nextInt();
            y1 = reader.nextInt();
            z1 = reader.nextInt();
            x2 = reader.nextInt();
            y2 = reader.nextInt();
            z2 = reader.nextInt();
            c1 = reader.nextFloat();
            c2 = reader.nextFloat();
        float V1 = x1 * y1 * z1 ;
        float V2 = x2 * y2 * z2 ;
        float S1 = 2 * (x1 * y1 + x1 * z1 + y1 * z1);
        float S2 = 2 * (x2 * y2 + x2 * z2 + y2 * z2);
        float M = Math.abs((S2 * c1 / S1 - c2) / (S2 * V1 / S1 - V2)) * 1000;
        if (answer > M || answer == 0) {
        answer = M;
        Q = i+1;
        }
        }
        reader.close(); 
        } catch (FileNotFoundException e) {
            System.out.println("Ошибка");
            e.printStackTrace();
        }
        String result = String.format("%.2f",answer);
        System.out.println(Q);
        System.out.println(result);
        try {
            FileWriter myWriter = new FileWriter("output.txt"); 
            myWriter.write(String.valueOf(Q)+ " ");
            myWriter.write(String.valueOf(result));
            myWriter.close();
        } catch (IOException e) {
            System.out.println("Ошибка");
            e.printStackTrace();
        }
    }}
