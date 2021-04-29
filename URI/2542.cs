using System;
public class URI2542{
    public static void Main(){
        int a, cL, cM, cartaL, cartaM, i, j, l, m, n;
        string linha;
        string []v;

        while((linha = Console.ReadLine()) != null){
            n = int.Parse(linha);
            linha = Console.ReadLine();
            v = linha.Split(' ');
            m = int.Parse(v[0]);
            l = int.Parse(v[1]);
            int[,]L = new int[l, n];
            int[,]M = new int[m, n];

            for(i = 0; i < m; i++){
                linha = Console.ReadLine();
                v = linha.Split(' ');
                for(j = 0; j < n; j++){
                    M[i, j] = int.Parse(v[j]);
                }
            }

            for(i = 0; i < l; i++){
                linha = Console.ReadLine();
                v = linha.Split(' ');
                for(j = 0; j < n; j++){
                    L[i, j] = int.Parse(v[j]);
                }
            }

            v = Console.ReadLine().Split(' ');

            cM = int.Parse(v[0]) - 1;
            cL = int.Parse(v[1]) - 1;
            a = int.Parse(Console.ReadLine()) - 1;
            cartaL = L[cL, a];
            cartaM = M[cM, a];

            if(cartaM > cartaL){
                Console.WriteLine("Marcos");
            } else if(cartaL > cartaM){
                Console.WriteLine("Leonardo");
            } else if(cartaL == cartaM){
                Console.WriteLine("Empate");
            }
        }
    }
}