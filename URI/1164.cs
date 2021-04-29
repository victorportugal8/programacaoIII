using System;
public class URI1164{
  public static void Main(){
    int n, x, a, b, c, d = 0;
    
    n = Convert.ToInt32(Console.ReadLine());
    
    for(a = 1; a <= n; a++){
        x = Convert.ToInt32(Console.ReadLine());
        c = x / 2; d = 0;
        
        for(b = 1; b <= c; b++){
            if(x % b == 0){
                d+=b;
            }
        }
        
        if(d == x){
            Console.WriteLine("{0} eh perfeito", x);
        } else{
            Console.WriteLine("{0} nao eh perfeito", x);
        }
    }
  }
}