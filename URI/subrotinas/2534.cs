using System;
public class URI2534{
    private static bool ler(out int n, out int q){
        string linha = Console.ReadLine();
        if(linha != null){
            string[] v = linha.Split(' ');
            n = int.Parse(v[0]);
            q = int.Parse(v[1]);
            return true;
        } else{
            n = q = 0;
            return false;
        }
    }

    private static void lerVetor(ref int[] notas){
        for(int i = 0; i < notas.Length; i++){
            notas[i] = int.Parse(Console.ReadLine());
        }
    }

    private static int lerInt(){
        int consulta = int.Parse(Console.ReadLine());
        return consulta;
    }
    public static void Main(){
        int n, q, pos;
        int[] notas;

        while(ler(out n, out q)){
            notas = new int[n];
            lerVetor(ref notas);
            Array.Sort(notas);
            Array.Reverse(notas);
            for(int i = 0; i < q; i++){
                pos = lerInt();
                Console.WriteLine("{0}", notas[pos - 1]);
            }
        }
    }
}