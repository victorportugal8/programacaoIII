using System;
public enum tipoForma{desconhecido, quadrado, retangulo, circulo};

public class formaGeo{
    private double a, b, l, r;
    private tipoForma tipo;
    
    public formaGeo(tipoForma tp){
        tipo = tp;
    }

    public void ler(){
        switch(tipo){
            case tipoForma.quadrado:
                Console.WriteLine("Digite o valor do lado: ");
                l = double.Parse(Console.ReadLine());
                break;
            case tipoForma.retangulo:
                Console.WriteLine("Digite o valor da base: ");
                b = double.Parse(Console.ReadLine());
                Console.WriteLine("Digite o valor da altura: ");
                a = double.Parse(Console.ReadLine());
                break;
            case tipoForma.circulo:
                Console.WriteLine("Digite o valor do raio: ");
                r = double.Parse(Console.ReadLine());
                break;
        }
    }

    public string nome(){
        switch(tipo){
            case tipoForma.quadrado:
                return "Quadrado";
            case tipoForma.retangulo:
                return "Retangulo";
            case tipoForma.circulo:
                return "Circulo";
            default:
                return "Forma geometrica desconhecida";
        }
    }

    public double area(){
        switch(tipo){
            case tipoForma.quadrado:
                return l * l;
            case tipoForma.retangulo:
                return b * a;
            case tipoForma.circulo:
                return 3.1415 * r * r;
            default:
                return 0;
        }
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
        int tipoFormaGeo;

        do{
            Console.WriteLine("1: Quadrado\n2: Retangulo\n3: Circulo\nEntre com a sua escolha:\n");
            tipoFormaGeo = int.Parse(Console.ReadLine());
        } while(tipoFormaGeo < 1 || tipoFormaGeo > 3);

        return new formaGeo((tipoForma)tipoFormaGeo);
    }

    public void ler(){
        Console.WriteLine("Entre com a quantidade de formas:\n");

        int n = int.Parse(Console.ReadLine());

        for(int i = 0; i < n; i++){
            v[i] = new formaGeo(criarForma());
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

public class programaFormaGeometrica{
    public static void Main(string []args){
        formas f = new formas();

        f.ler();
        f.listar();
    }
}