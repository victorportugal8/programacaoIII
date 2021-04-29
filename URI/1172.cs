using System;
public class URI1172{
    public static void Main(){
        int i;
        int[] N;
        
        N = new int[10];

        for(i = 0; i < 10; i++){
            N[i] = int.Parse(Console.ReadLine());
        }

        for(i = 0; i < 10; i++){
            if(N[i] <= 0){
                N[i] = 1;
            }
        }

        for(i = 0; i < 10; i++){
            Console.WriteLine("X[{0}] = {1}", i, N[i]);
        }
    }
}