using System;
public class URI1019{
    public static void Main(){
        int h, m, s;

        s = Convert.ToInt32(Console.ReadLine());

        h = (s / 3600);
        s = s - (h * 3600);
        m = (s / 60);
        s = s - (m * 60);

        Console.WriteLine("{0}:{1}:{2}", h, m, s);
    }
}