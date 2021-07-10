using System;
public class TPoligono{
    int qtd, i;
    double[] verticeX = new double[100];
    double[] verticeY = new double[100];
    string linha;
    string[] v;
    double pmt;
    
    public void ler(){
        qtd = int.Parse(Console.ReadLine());
        
        for(int i = 0; i < qtd; i++){
            linha = Console.ReadLine();
            v = linha.Split(' ');
            verticeX[i] = double.Parse(v[0]);
            verticeY[i] = double.Parse(v[1]);
        }
    }

    public double perimetro(){
        for(int i = 0; i < qtd; i++){
            pmt = pmt + (Math.Sqrt(Math.Pow(verticeX[i + 1] - verticeX[i], 2) + Math.Pow(verticeY[i + 1] - verticeY[i], 2)));
        }

        pmt = pmt + (Math.Sqrt(Math.Pow(verticeX[qtd - 1] - verticeX[0], 2) + Math.Pow(verticeY[qtd - 1] - verticeY[0], 2)));        
        return pmt;
    }
}

public class Poligono{
    public static void Main(string []args){
        TPoligono p = new TPoligono();
        
        p.ler();
        
        Console.WriteLine("perimetro - {0:F2}", p.perimetro());
    }
}