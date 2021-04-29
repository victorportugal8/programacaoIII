using System;
public class URI1012{
    public static void Main(){
        double A, B, C, pi, triangulo, circulo, trapezio, quadrado, retangulo;
        string[] valores = Console.ReadLine().Split(' ');

        A = double.Parse(valores[0]);
        B = double.Parse(valores[1]);
        C = double.Parse(valores[2]);

        pi = 3.14159;

        triangulo = (A * C) / 2;
        circulo = pi * Math.Pow(C, 2);
        trapezio = (A + B) * C / 2;
        quadrado = B * B;
        retangulo = A * B;

        Console.WriteLine("TRIANGULO: {0:F3}", triangulo);
        Console.WriteLine("CIRCULO: {0:F3}", circulo);
        Console.WriteLine("TRAPEZIO: {0:F3}", trapezio);
        Console.WriteLine("QUADRADO: {0:F3}", quadrado);
        Console.WriteLine("RETANGULO: {0:F3}", retangulo);
    }
}