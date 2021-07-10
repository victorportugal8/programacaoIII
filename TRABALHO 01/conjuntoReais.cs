using System;
public class TConjunto{
    private double[] v = new double[100];
    private int qtd = 0;
    
    public void inserir(double e){
        if(!pertence(e)){
            v[qtd] = e;
            qtd++;
        }
    }

    public void ler(){
        qtd = 0;
        int n = int.Parse(Console.ReadLine());
        string[] strValores = Console.ReadLine().Split(' ');

        for(int i = 0; i < n; i++){
            inserir(double.Parse(strValores[i]));
        }
    }

    public void mostrar(){
        for(int i = 0; i < qtd - 1; i++){
            Console.Write("{0} ", v[i]);
        }

        if(qtd > 0){
            Console.WriteLine("{0}", v[qtd - 1]);
        } else{
            Console.WriteLine();
        }
    }

    public void uniao(TConjunto a, TConjunto b){
        qtd = 0;

        for(int i = 0; i < a.qtd; i++){
            inserir(a.v[i]);
        }

        for(int i = 0; i < b.qtd; i++){
            inserir(b.v[i]);
        }
    }

    public void intersecao(TConjunto a, TConjunto b){
        qtd = 0;

        for(int i = 0; i < a.qtd; i++){
            if(b.pertence(a.v[i])){
                inserir(a.v[i]);
            }
        }
    }

    public void subtracao(TConjunto a, TConjunto b){
        qtd = 0;
        
        for(int i = 0; i < a.qtd; i++){
            if(!b.pertence(a.v[i])){
                inserir(a.v[i]);
            }
        }
    }
    
    public bool estaContido(TConjunto a){
        return a.contem(this);
    }

    public bool contem(TConjunto a){
        bool contemTodos = true;
        int i = 0;

        while(i < a.qtd && contemTodos){
            if(!pertence(a.v[i])){
                contemTodos = false;
            } else{
                i++;
            }
        }

        return contemTodos;
    }

    public bool pertence(double e){
        bool achou = false;
        int i = 0;

        while(i < qtd && !achou){
            if(v[i] == e){
                achou = true;
            } else{
                i++;
            }
        }

        return achou;
    }
}

public class ConjuntoReais{
    public static void Main(string []args){
        TConjunto a, b, c, d, e;
        int x;
        a = new TConjunto();
        b = new TConjunto();
        c = new TConjunto();
        d = new TConjunto();
        e = new TConjunto();
        
        a.ler();
        b.ler();

        c.uniao(a, b);
        Console.Write("a UNIAO b = ");
        c.mostrar();

        d.intersecao(a, b);
        Console.Write("a INTERSECAO b = ");
        d.mostrar();

        Console.WriteLine("d esta contido em a: {0}", d.estaContido(a) ? "sim" : "nao");
        Console.WriteLine("a contem d: {0}", a.contem(d) ? "sim" : "nao");
        Console.WriteLine("c esta contido em a: {0}", c.estaContido(a) ? "sim" : "nao");
        Console.WriteLine("c contem a: {0}", c.contem(a) ? "sim" : "nao");
        Console.WriteLine("c contem b: {0}", c.contem(b) ? "sim" : "nao");
        Console.WriteLine("a contem b: {0}", a.contem(b) ? "sim" : "nao");
        Console.WriteLine("a esta contido em b: {0}", a.estaContido(b) ? "sim" : "nao");
        Console.Write("a - b = ");

        e.subtracao(a, b);
        e.mostrar();

        string[] linha = Console.ReadLine().Split(' ');
        int i = 0;

        x = int.Parse(linha[i++]);

        while(x > 0){
            Console.WriteLine("{0} pertence ao conjunto A: {1}", x, a.pertence(x) ? "sim" : "nao");
            x = int.Parse(linha[i++]);
        }
    }
}