using System;
public class URI1014{
    public static void Main(){
        int distanciaPercorrida;
        double combustivelGasto, consumoMedio;

        distanciaPercorrida = Convert.ToInt32(Console.ReadLine());
        combustivelGasto = Convert.ToDouble(Console.ReadLine());

        consumoMedio = distanciaPercorrida / combustivelGasto;

        Console.WriteLine("{0:F3} km/l", consumoMedio);
    }
}