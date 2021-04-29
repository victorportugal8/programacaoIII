using System;
public class URI1153{
    public static void Main(){
        int N, a, m = 1;

        N = int.Parse(Console.ReadLine());

        for(a = N; a >= 1; a--){
            m *= a;
        }
        Console.WriteLine("{0}", m);
    }
}