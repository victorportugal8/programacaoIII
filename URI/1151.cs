using System;
public class URI1151{
  public static void Main(){
    int x, y, a = 0, b = 1, c = 0;
    x = Convert.ToInt32(Console.ReadLine());
    
    for(y = 1; y < x; y++){
        if(y % 2 == 1){
            Console.Write("{0} ", c);
            c = a + b;
            a = c;
        } else if(y == 2){
            Console.Write("{0} ", c);
        } else if(y % 2 == 0){
            Console.Write("{0} ", c);
            c = a + b;
            b = c;
        }
    }
    
    Console.WriteLine("{0}", c);
  }
}