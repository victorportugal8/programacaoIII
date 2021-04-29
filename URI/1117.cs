using System;
public class URI1117{
  public static void Main(){
    double a, b, c = 0, d = 0;
    int i;
    
    i = 0;
    
    while(i >= 0){
        if(d == 2){
            break;
        }
        
        a = Convert.ToDouble(Console.ReadLine());
        
        if(a >= 0 && a <= 10){
            d++;
            c+=a;
        } else{
            Console.WriteLine("nota invalida");
        }
    }
    
    b = c / 2.00;
    Console.WriteLine("media = {0:F2}", b);
  }
}