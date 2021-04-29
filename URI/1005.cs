using System;
public class URI1005{
 
    static void Main(){

        double a, b, x;
        
        a = Convert.ToDouble(Console.ReadLine());
        b = Convert.ToDouble(Console.ReadLine());
        
        x = (a * 3.5 + b * 7.5) / (3.5 + 7.5);
        
    	Console.WriteLine("MEDIA = {0:F5}", x);
    }
}