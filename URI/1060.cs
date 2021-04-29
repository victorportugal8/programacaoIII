using System;
public class URI1060{
    public static void Main(){
        int i, positivos = 0;
        double n;

        for(i = 0; i < 6; i++){
            n = Convert.ToDouble(Console.ReadLine());
            if(n > 0){
                positivos++;
            }
        }

        Console.WriteLine("{0} valores positivos", positivos);
    }
}