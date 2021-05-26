using System;

public class formaGeo{
    public virtual void ler(){}
    public virtual string nome(){
        return "Forma geometrica desconhecida";
    }
    public virtual double area(){
        return 0;
    }
}

class quadrado : formaGeo{
    private double l;
    
    public override void ler(){
        Console.WriteLine("Digite o valor do lado:\n");
        l = double.Parse(Console.ReadLine());
    }
    
    public override string nome(){
        return "Quadrado";
    }
    public override double area(){
        return l * l;
    }
}

class retangulo : formaGeo{
    private double a, b;
    
    public override void ler(){
        Console.WriteLine("Digite o valor da base:\n");
        b = double.Parse(Console.ReadLine());
        Console.WriteLine("Digite o valor da altura:\n");
        a = double.Parse(Console.ReadLine());
    }
    
    public override string nome(){
        return "Retangulo";
    }
    public override double area(){
        return b * a;
    }
}

class ciruclo : formaGeo{
    private double r;
    
    public override void ler(){
        Console.WriteLine("Digite o valor do raio:\n");
        r = double.Parse(Console.ReadLine());
    }
    
    public override string nome(){
        return "Ciruclo";
    }
    public override double area(){
        return 3.1415 * r * r;
    }
}

class elipse : formaGeo{
    private double r1, r2;

    public override void ler(){
        Console.WriteLine("Digite o valor do raio 1:\n");
        r1 = double.Parse(Console.ReadLine());
        Console.WriteLine("Digite o valor do raio 2:\n");
        r2 = double.Parse(Console.ReadLine());
    }

    public override string nome(){
        return "Elipse";
    }

    public override double area(){
        return 3.1415 * r1 * r2;
    }
}

public class formas{
    private formaGeo[] v;
    private int qtd;

    public formas(){
        qtd = 0;
        v = new formaGeo[100];
    }

    private formaGeo criarForma(){
        int tipo;

        do{
            Console.WriteLine("1: Quadrado\n2: Retangulo\n3: Circulo\n4: Elipse\nEntre com a sua escolha:\n");
            tipo = int.Parse(Console.ReadLine());
        } while(tipo < 1 || tipo > 4);

        switch(tipo){
            case 1:
                return new quadrado();
            case 2:
                return new retangulo();
            case 3:
                return new ciruclo();
            case 4:
                return new elipse();
            default:
                return null;
        }
    }

    public void ler(){
        Console.WriteLine("Entre com a quantidade de formas:\n");
        int n = int.Parse(Console.ReadLine());

        for(int i = 0; i < n; i++){
            v[i] = criarForma();
            v[i].ler();
        }

        qtd = n;
    }

    public void listar(){
        for(int i = 0; i < qtd; i++){
            Console.WriteLine("{0, -30} {1, 5:F2}", v[i].nome(), v[i].area());
        }
    }
}

public class programaFormasGeometricas{
    public static void Main(string []args){
        formas f = new formas();

        f.ler();
        f.listar();
    }
}