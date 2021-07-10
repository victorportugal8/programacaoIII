using System;
public class TVetInt{
    int N;
    int[] vetorOriginal = new int[100];

    public void ler(){
        N = int.Parse(Console.ReadLine());
        string linha;
        string[] valores;

        linha = Console.ReadLine();
        valores = linha.Split(' ');
        
        for(int i = 0; i < N; i++){
            vetorOriginal[i] = int.Parse(valores[i]);
        }
    }

    public void inverter(){
        int temp;
        
        temp = vetorOriginal[0];
        vetorOriginal[0] = vetorOriginal[N - 1];
        vetorOriginal[N - 1] = temp;

        for(int i = 1; i < (N / 2); i++){
            temp = vetorOriginal[i];
            vetorOriginal[i] = vetorOriginal[N - i - 1];
            vetorOriginal[N - i - 1] = temp;
        }
    }

    public void listar(){
        for(int i = 0; i < N; i++){
            if(i == N - 1){
                Console.Write("{0} ", vetorOriginal[i]);
                break;
            }
            Console.Write("{0} ", vetorOriginal[i]);
        }
        Console.WriteLine();
    }
}

public class VetoresInteiros{
    public static void Main(string []args){
        TVetInt v = new TVetInt();
        
        v.ler();
        v.inverter();
        v.listar();
    }
}