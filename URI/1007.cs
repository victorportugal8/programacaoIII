using System;
public class URI1007{
    static void Main(){
        int a, b, c, d, x;

        a = Convert.ToInt32(Console.ReadLine());
        b = Convert.ToInt32(Console.ReadLine());
        c = Convert.ToInt32(Console.ReadLine());
        d = Convert.ToInt32(Console.ReadLine());

        x = (a * b) - (c * d);

        Console.WriteLine("DIFERENCA = {0}", x);
    }
}