using System;
public class URI1379{
    private static void ler(out int a, out int b){
        string[] linha = Console.ReadLine().Split(' ');
        a = int.Parse(linha[0]);
        b = int.Parse(linha[1]);
    }

    private static int medianaMinima(int x, int y){
        return 2 * x - y;
    }

    public static void Main(){
        int a, b, c, mediana;

        ler(out a, out b);

        while(a > 0 && b > 0){
            mediana = medianaMinima(a , b);
            Console.WriteLine("{0}", mediana);
            ler(out a, out b);
        }
    }
}