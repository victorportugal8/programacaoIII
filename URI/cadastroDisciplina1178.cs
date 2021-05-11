using System;
public class controleDisciplinas{
    public static int menu(){
        int opc;

        do{
            Console.Clear();
            Console.WriteLine("1 - inicializar");
            Console.WriteLine("2 - inserir nova disciplina");
            Console.WriteLine("3 - listar historico");
            Console.WriteLine("4 - sair");
            Console.WriteLine("Entre com a sua opcao:");
            opc = int.Parse(Console.ReadLine());
        } while(opc < 1 || opc > 4);
        Console.Clear();
        return opc;
    }

#region DISCIPLINA
    public struct dadosDisciplina{
        public int codigoDisciplina, semestre, ano, creditos;
        public string nomeAluno, nomeProfessor;
        public double nota1, nota2;
    }
    
    public static void ler(out dadosDisciplina d){
        d.codigoDisciplina = int.Parse(Console.ReadLine());
        d.nomeAluno = Console.ReadLine();
        d.nomeProfessor = Console.ReadLine();
        d.creditos = int.Parse(Console.ReadLine());
        d.ano = int.Parse(Console.ReadLine());
        d.semestre = int.Parse(Console.ReadLine());
        d.nota1 = double.Parse(Console.ReadLine());
        d.nota2 = double.Parse(Console.ReadLine());
    }
    
    public static double media(dadosDisciplina d){
        return (d.nota1 + 2 * d.nota2) / 3;
    }
    
    public static void mostrar(dadosDisciplina d){
        Console.WriteLine("Codigo    : {0:0000}", d.codigoDisciplina);
        Console.WriteLine("Nome      : {0}", d.nomeAluno);
        Console.WriteLine("Professor : {0}", d.nomeProfessor);
        Console.WriteLine("Creditos  : {0}", d.creditos);
        Console.WriteLine("Ano       : {0}", d.ano);
        Console.WriteLine("Semestre  : {0}", d.semestre);
        Console.WriteLine("Nota1     : {0:0.00}", d.nota1);
        Console.WriteLine("Nota2     : {0:0.00}", d.nota2);
        Console.WriteLine("Media     : {0:0.00}", media(d));
    }
#endregion

#region  HISTÓRICO
    public struct historicoDisciplina{
        public dadosDisciplina []v;
        public int qtd;
    }

    public static void inicializar(out historicoDisciplina h){
        h.v = new dadosDisciplina[100];
        h.qtd = 0;
    }

    public static void inserir(ref historicoDisciplina h, dadosDisciplina d){
        h.v[h.qtd] = d;
        h.qtd++;
    }

    public static void listar(historicoDisciplina h){
        Console.WriteLine("{0, 4} {1, -50} {2, 4} {3, 4}/{4, 1} {5, 5}", "Cod.", "Nome", "Cred", "Ano", "S", "Media");
        for(int i = 0; i < h.qtd; i++){
            Console.WriteLine("{0:0000} {1, -50} {2, 4:0} {3:0000}/{4, 1:0} {5:00.00}", h.v[i].codigoDisciplina, h.v[i].nomeAluno, h.v[i].creditos, h.v[i].ano, h.v[i].semestre, media(h.v[i]));
        }
    }
#endregion

    public static void Main(){
        dadosDisciplina d;
        historicoDisciplina h;
        bool fim = false;
        inicializar(out h);

        while(!fim){
            switch(menu()){
                case 1:
                    inicializar(out h);
                    Console.WriteLine("Historico inicializado com sucesso!");
                    break;
                case 2:
                    ler(out d);
                    inserir(ref h, d);
                    Console.WriteLine("Disciplina inserida com sucesso!");
                    break;
                case 3:
                    listar(h);
                    while(Console.ReadLine() != "Ok");
                    break;
               case 4:
                    fim = true;
                    break;                            
            }
        }
        Console.WriteLine("Obrigado por utilizar o programa de cadastro, volte sempre!");
    }
}