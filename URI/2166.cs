using System;
public class URI2166{
    public static void Main(){
        int n, i;
        double resp;

        n = Convert.ToInt32(Console.ReadLine());
        resp = 0.0;

        for(i = 0; i < n; i++){
            resp += 2.0;
            resp = (1.0 / resp);
        }

        resp += 1.00;

        Console.WriteLine(resp.ToString("0.0000000000"));
    }
}