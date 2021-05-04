using System;
public class URI1158{
    private static void ler(out int n){
        n = int.Parse(Console.ReadLine());
    }

    private static void ler(out int x, out int y){
        string[] linha = Console.ReadLine().Split(' ');
        x = int.Parse(linha[0]);
        y = int.Parse(linha[1]);
    }

    private static int somaImpares(int x, int y){
        int soma = 0;
        
        if(x % 2 == 0){
            x++;
        }

        for(int i = x; i < x + y * 2; i += 2){
            soma += i;
        }
        return soma;
    }
    public static void Main(){
        int i, n, x, y;
        
        ler(out n);

        for(i = 0; i < n; i++){
            ler(out x, out y);
            Console.WriteLine("{0}", somaImpares(x, y));
        }
    }
}