using System;
public class URI1113{
    private static bool tentaLer(out int x, out int y){
        string linha;
        string[] v;
        linha = Console.ReadLine();
        if(linha != null){
            v = linha.Split(' ');
            x = int.Parse(v[0]);
            y = int.Parse(v[1]);
            
            return true;
        } else{
            x = y = 0;
            return false;
        }
    }

    private static void cresc_descr(int x, int y){
        if(x > y){
            Console.WriteLine("Decrescente");
        } else{
            Console.WriteLine("Crescente");
        }
    }

    public static void Main(){
        int x, y;

        while(tentaLer(out x, out y) && x != y){
            cresc_descr(x, y);
        }
    }
}