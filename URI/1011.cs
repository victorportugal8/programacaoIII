using System;
public class URI1011{
    public static void Main(){
        double pi, raio, volume;
        
        raio = Convert.ToDouble(Console.ReadLine());

        pi = 3.14159;

        volume = (4.0 / 3) * pi * Math.Pow(raio, 3);

        Console.WriteLine("VOLUME = {0:F3}", volume);
    }
}