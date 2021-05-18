using System;
public class Tupla{
    private int X, Y;
    public bool Ler(){
        string linha = Console.ReadLine();
        string []v = linha.Split(' ');
        X = Convert.ToInt32(v[0]);
        Y = Convert.ToInt32(v[1]);
        return X!=Y;
    }
    public void Cresc_Descr(){
        if (X > Y){
            Console.WriteLine("Decrescente");
        } else if (X < Y){
            Console.WriteLine("Crescente");
        }
    }
}

public class URI1113POO{
    public static void Main(string []args){
        Tupla a = new Tupla();
        
        while (a.Ler()){
            a.Cresc_Descr();
        }
    }	
}