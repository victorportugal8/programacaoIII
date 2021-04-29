using System;
public class URI1078{
  public static void Main(){
    int n, x, i;
    n = Convert.ToInt32(Console.ReadLine());
    
    for(i = 1; i <= 10; i++){
        x = i * n;
        Console.WriteLine("{0} x {1} = {2}", i, n, x);
    }
  }
}