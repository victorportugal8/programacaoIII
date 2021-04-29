using System;
public class URI1036{
    public static void Main(){
        double A, B, C, raiz;
        string[] valores = Console.ReadLine().Split(' ');

        A = double.Parse(valores[0]);
        B = double.Parse(valores[1]);
        C = double.Parse(valores[2]);

        if((B * B) - 4 * A * C < 0 || A == 0){
            Console.WriteLine("Impossivel calcular");
        } else{
            raiz = Math.Sqrt((B * B) - 4 * A * C);
            Console.WriteLine("R1 = {0:F5}\nR2 = {1:F5}", ((-B + raiz) / (2 * A)), ((-B - raiz) / (2 * A)));
        }
    }
}