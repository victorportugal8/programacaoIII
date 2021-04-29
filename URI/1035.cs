using System;
public class URI1035{
    public static void Main(){
        int A, B, C, D;
        String[] vet = Console.ReadLine().Split(' ');
        
        A = int.Parse(vet[0]);
        B = int.Parse(vet[1]);
        C = int.Parse(vet[2]);
        D = int.Parse(vet[3]);
        
        if(B > C && D > A && (C + D) > (A + B) && C > 0 && D > 0 && A > 00){
            Console.WriteLine("Valores aceitos");
        } else{
            Console.WriteLine("Valores nao aceitos");
        }
    }
}