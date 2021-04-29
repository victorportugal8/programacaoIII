using System;
public class URI1157{
    private static void ler(out int n){
        n = Convert.ToInt32(Console.ReadLine());
    }
    
    private static void listarDivisores(int n){
        for(int i = 1; i <= n; i++){
            if(n % i == 0){
                Console.Write("{0}\n", i);
            }
        }
    }
    
    public static void Main(){
        int n;

        ler(out n);

        listarDivisores(n);     
    }
}