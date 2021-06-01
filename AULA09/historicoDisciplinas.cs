using System;
public abstract class Disciplina{
    private int codigo, creditos, ano, semestre;
    private string nome;

    public virtual void Ler(){
        Console.Write("Digite o codigo da disciplina:\n");
        codigo = int.Parse(Console.ReadLine());
        Console.Write("Digite o nome da disciplina:\n");
        nome = Console.ReadLine();
        Console.Write("Digite o semestre:\n");
        semestre = int.Parse(Console.ReadLine());
        Console.Write("Digite o ano:\n");
        ano = int.Parse(Console.ReadLine());
    }

    public abstract double Media();

    public int Codigo{
        get{
            return codigo;
        }
    }

    public int Credtios{
        get{
            return creditos;
        }
    }

    public string Nome{
        get{
            return nome;
        }
    }
}

public class DisciplinaTipo1 : Disciplina{
    protected double nota1, nota2;

    public override void Ler(){
        base.Ler();
        Console.Write("Digite a primeira nota:\n");
        nota1 = double.Parse(Console.ReadLine());
        Console.Write("Digite a segunda nota:\n");
        nota2 = double.Parse(Console.ReadLine());
    }

    public override double Media(){
        return (nota1 + nota2) / 2;
    }
}

public class DisciplinaTipo2 : DisciplinaTipo1{
    public override double Media(){
        return (nota1 + (2 * nota2)) / 3;
    }
}

public class DisciplinaTipo3 : Disciplina{
    private double notaMonografia, notaApresentacao, notaPratica;

    public override void Ler(){
        base.Ler();
        Console.Write("Digite a nota da monografia:\n");
        notaMonografia = double.Parse(Console.ReadLine());
        Console.Write("Digite a nota da apresentacao:\n");
        notaApresentacao = double.Parse(Console.ReadLine());
        Console.Write("Digite a nota pratica:\n");
        notaPratica = double.Parse(Console.ReadLine());
    }

    public override double Media(){
        return ((2 * notaMonografia) + (3 * notaApresentacao) + notaPratica) / 6;
    }

    public double NotaApresentacao{
        get{
            return notaApresentacao;
        }
    }
}

public class Historico{
    private Disciplina []vet;
    private int qtd;

    public Historico(){
        vet = new Disciplina[100];
        qtd = 0;
    }

    public void Inserir(Disciplina d){
        vet[qtd] = d;
        qtd++;
    }

    private int ObterIndice(int codigo){
        int i = 0;
        bool achou = false;

        while(i < qtd && !achou){
            if(vet[i].Codigo == codigo){
                achou = true;
            } else{
                i++;
            }
        }
        return achou ? i : -1;
    }

    public void Remover(int codigo){
        int pos = ObterIndice(codigo);

        if(pos > -1){
            for(int i = pos + 1; i < qtd; i++){
                vet[i - 1] = vet[i];
            }
            qtd++;
        }
    }

    public void Alterar(int codigo, Disciplina d){
        int pos = ObterIndice(codigo);

        if(pos > -1){
            vet[pos] = d;
        }
    }

    public void Listar(){
        Console.WriteLine("{0, -30} {1} {2}", "Nome", "Cred", "Media");
        
        for(int i = 0; i < qtd; i++){
            Console.WriteLine("{0, -30} {1:00} {2:00.00}", vet[i].Nome, vet[i].Credtios, vet[i].Media());
        }
    }

    public void ListarTipo2(){
        Console.WriteLine("{0, -30} {1} {2}", "Nome", "Cred", "Media");

        for(int i = 0; i < qtd; i++){
            if(vet[i] is DisciplinaTipo2){
                Console.WriteLine("{0, -30} {1:00} {2:00.00}", vet[i].Nome, vet[i].Credtios, vet[i].Media());    
            }
        }
    }

    public void ListarTipo3(){
        Console.WriteLine("{0, -30} {1} {2}", "Nome", "Cred", "Media");

        for(int i = 0; i < qtd; i++){
            if(vet[i] is DisciplinaTipo3 && (vet[i] as DisciplinaTipo3).NotaApresentacao > 7){
                Console.WriteLine("{0, -30} {1:00} {2:00.00}", vet[i].Nome, vet[i].Credtios, vet[i].Media());
            }
        }
    }
}

public class HistoricoDisciplinas{
    private static int Menu(){
        int opc;

        do{
            Console.WriteLine("1: Inserir disciplina");  
            Console.WriteLine("2: Remover disciplina");
            Console.WriteLine("3: Alterar disciplina");
            Console.WriteLine("4: Listar todas disciplinas");
            Console.WriteLine("5: Listar todas disciplinas tipo 2");
            Console.WriteLine("6: Listar todas disciplinas tipo 3");
            Console.WriteLine("7: Sair");
            Console.Write("Entre com a sua opcao:\n");
            opc = int.Parse(Console.ReadLine());
        } while(opc < 1 || opc > 7);

        return opc;
    }

    private static Disciplina CriarDisciplina(){
        int tipo;

        do{
            Console.WriteLine("1: Disciplina tipo 1");
            Console.WriteLine("2: Disciplina tipo 2");
            Console.WriteLine("3: Disciplina tipo 3");
            Console.Write("Entre com o tipo da disciplina");
            tipo = int.Parse(Console.ReadLine());
        } while(tipo < 1 || tipo > 3);

        switch(tipo){
            case 1:
                return new DisciplinaTipo1();
            case 2:
                return new DisciplinaTipo2();
            case 3:
                return new DisciplinaTipo3();
            default:
                return null;
        }
    }

    public static void Main(String []args){
        Historico h = new Historico();
        Disciplina d;
        int codigo;
        bool fim = false;

        while(!fim){
            switch(Menu()){
                case 1:
                    d = CriarDisciplina();
                    d.Ler();
                    h.Inserir(d);
                    break;
                case 2:
                    Console.WriteLine("Digite o codigo da disciplina para remocao:\n");
                    codigo = int.Parse(Console.ReadLine());
                    h.Remover(codigo);
                    break;
                case 3:
                    Console.WriteLine("Digite o codigo da disciplina para alteracao:\n");
                    codigo = int.Parse(Console.ReadLine());
                    d = CriarDisciplina();
                    d.Ler();
                    h.Alterar(codigo, d);
                    break;
                case 4:
                    h.Listar();
                    Console.ReadKey();
                    break;
                case 5:
                    h.ListarTipo2();
                    Console.ReadKey();
                    break;
                case 6:
                    h.ListarTipo3();
                    Console.ReadKey();
                    break;
                case 7:
                    fim = true;
                    break;
            }
        }
    }
}