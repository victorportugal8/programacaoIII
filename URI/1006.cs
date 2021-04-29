using System;
public class URI1006{
    static void Main(){
        double a, b, c, x;

        a = Convert.ToDouble(Console.ReadLine());
        b = Convert.ToDouble(Console.ReadLine());
        c = Convert.ToDouble(Console.ReadLine());

        x = (a * 2 + b * 3 + c * 5) / (2 + 3 + 5);

        Console.WriteLine("MEDIA = {0:F1}", x);
    }
}