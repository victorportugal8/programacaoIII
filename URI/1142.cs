using System;
public class URI1142{
  public static void Main(){
    int n, a, b, c = 1, d = 4;
    
    n = Convert.ToInt32(Console.ReadLine());
    
    for(a = 1; a <= n; a++){
        for(b = c; b <= d; b++){
            if(b % 4 == 0){
                Console.WriteLine("PUM");
            } else{
                Console.Write("{0} ", b);
            }
        }
        
        c+=4; d+=4;
    }
  }
}