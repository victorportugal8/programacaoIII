using System;
public class TMatriz{
    int i, j, n, m;
    string linhaOriginal;
    string[] v;
    char[,] matrizOriginal;
    char[,] matrizTransposta;
    
    public void ler(){
        linhaOriginal = Console.ReadLine();
        v = linhaOriginal.Split(' ');
        n = int.Parse(v[0]);
        m = int.Parse(v[1]);

        matrizOriginal = new char[n, m];

        for(i = 0; i < n; i++){
            linhaOriginal = Console.ReadLine();
            for(j = 0; j < m; j++){
                matrizOriginal[i, j] = linhaOriginal[j];
            }
        }
    }

    public void transposta(){
        matrizTransposta = new char[m, n];
        for(i = 0; i < m; i++){
            for(j = 0; j < n; j++){
                matrizTransposta[i, j] = matrizOriginal[j , i];
            }
        }
    }

    public void mostrar(){
        for(i = 0; i < m; i++){
            for(j = 0; j < n; j++){
                Console.Write("{0}", matrizTransposta[i, j]);
            }
            Console.WriteLine();
        }
    }

}
public class matrizTransposta{
    public static void Main(string []args){
        TMatriz a = new TMatriz();
        
        a.ler();
        a.transposta();
        a.mostrar();
    }
}