using System;
public class URI1017{
    public static void Main(){
        int horas, vMedia, distancia;
        double combustivel, consumoMedio;

        horas = Convert.ToInt32(Console.ReadLine());
        vMedia = Convert.ToInt32(Console.ReadLine());

        distancia = (horas * vMedia);
        consumoMedio = 12.0;

        combustivel = (distancia / consumoMedio);

        Console.WriteLine("{0:F3}", combustivel);
    }
}