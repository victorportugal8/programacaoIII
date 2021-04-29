using System;
public class URI1043{
    public static void Main(){
        double A, B, C, areaTrapezio, perimetroTriangulo;
        string[] valores = Console.ReadLine().Split(' ');

        A = double.Parse(valores[0]);
        B = double.Parse(valores[1]);
        C = double.Parse(valores[2]);

        if(A < (B + C) && B < (A + C) && C < (A + B)){
            perimetroTriangulo = A + B + C;
            Console.WriteLine("Perimetro = {0:F1}", perimetroTriangulo);
        } else{
            areaTrapezio = ((A + B) * C / 2);
            Console.WriteLine("Area = {0:F1}", areaTrapezio);
        }
    }
}