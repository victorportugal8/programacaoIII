using System;
public class URI1113{
  public static void Main(){
    int a, b, i;
    i = 0;
    while(i < 10000){
        string[] s = Console.ReadLine().Split(' ');
        a = int.Parse(s[0]);
        b = int.Parse(s[1]);
        
        if(a == b){
            break;
        } else{
            if(a < b){
                Console.WriteLine("Crescente");
            } else{
                Console.WriteLine("Decrescente");
            }
        }
    }
  }
}