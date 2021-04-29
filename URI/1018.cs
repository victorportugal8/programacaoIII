using System;
public class URI1018{
    public static void Main(){
        int x;

        x = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("{0}", x);
        Console.WriteLine("{0} nota(s) de R$ 100,00", (x / 100));
        x %= 100;
        Console.WriteLine("{0} nota(s) de R$ 50,00", (x / 50));
        x %= 50;
        Console.WriteLine("{0} nota(s) de R$ 20,00", (x / 20));
        x %= 20;
        Console.WriteLine("{0} nota(s) de R$ 10,00", (x / 10));
        x %= 10;
        Console.WriteLine("{0} nota(s) de R$ 5,00", (x / 5));
        x %= 5;
        Console.WriteLine("{0} nota(s) de R$ 2,00", (x / 2));
        x %= 2;
        Console.WriteLine("{0} nota(s) de R$ 1,00", (x / 1));
        x %= 1;
    }
}