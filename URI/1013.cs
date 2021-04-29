using System;
public class URI1013{
    public static void Main(){
        int a, b, c;
        double maiorAB, maior;
        string[] valores = Console.ReadLine().Split(' ');

        a = int.Parse(valores[0]);
        b = int.Parse(valores[1]);
        c = int.Parse(valores[2]);

        maiorAB = (a + b + Math.Abs(a - b)) / 2;
        maior = (maiorAB + c + Math.Abs(maiorAB - c)) / 2;

        Console.WriteLine("{0} eh o maior", maior);
    }
}