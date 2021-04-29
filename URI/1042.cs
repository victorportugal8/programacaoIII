using System;
public class URI1040{
    public static void Main(){ 
        int a, b, c;
        string[] s = Console.ReadLine().Split(' ');

        a = int.Parse(s[0]);
        b = int.Parse(s[1]);
        c = int.Parse(s[2]);

        if (a < b && a < c && b < c){
            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);
        } else if (a < b && a < c && b > c){
            Console.WriteLine(a);
            Console.WriteLine(c);
            Console.WriteLine(b);
        } else if ( a > b && b < c && a < c){
            Console.WriteLine(b);
            Console.WriteLine(a);
            Console.WriteLine(c);
        } else if (a > b && b < c && a > c){
            Console.WriteLine(b);
            Console.WriteLine(c);
            Console.WriteLine(a);
        } else if (a < b && b > c && a > c){
            Console.WriteLine(c);
            Console.WriteLine(a);
            Console.WriteLine(b);
        } else if (a > b && b > c && a > c){
            Console.WriteLine(c);
            Console.WriteLine(b);
            Console.WriteLine(a);
        }

        Console.WriteLine("");
        Console.WriteLine(a);
        Console.WriteLine(b);
        Console.WriteLine(c);
    }
}