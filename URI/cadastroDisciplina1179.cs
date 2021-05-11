using System;
public class controleDisciplinas{
    public static int menu(){
        int opc;

        do{
            Console.Clear();
            Console.WriteLine("1 - inserir nova disciplina");
            Console.WriteLine("2 - remover disciplina pelo codigo");
            Console.WriteLine("3 - alterar disciplina pelo codigo");
            Console.WriteLine("4 - listar todas as disciplinas");
            Console.WriteLine("5 - listar disciplina de um ano/semestre");
            Console.WriteLine("6 - listar disciplina pelo nome/professor");
            Console.WriteLine("7 - Historico");
            Console.WriteLine("8 - sair");
            Console.WriteLine("Entre com a sua opcao:");
            opc = int.Parse(Console.ReadLine());
        } while(opc < 1 || opc > 8);
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

    public static int obterIndice(historicoDisciplina h, int codigoDisciplina){
        bool achou = false;
        int i = 0;
        
        while(!achou && i < h.qtd){
            if(h.v[i].codigoDisciplina == codigoDisciplina){
                achou = true;
            } else{
                i++;
            }
        return achou? i : -1;
        }
    }

    public static void remover(ref historicoDisciplina h, int codigoDisciplina){
        int pos = obterIndice(h, codigoDisciplina);
        if(pos > -1){
            for(int i = pos + 1; i < h.qtd; i++){
                h.v[i - 1] = h.v[i];
            }
            h.qtd--;
        }
    }

    public static void alterar(ref historicoDisciplina h, int codigoDisciplina, dadosDisciplina d){
        int pos = obterIndice(h, codigoDisciplina);
        if(pos > -1){
            h.v[pos] = d;
        }
    }

    public static void listar(historicoDisciplina h){
        Console.WriteLine("{0, 4} {1, -50} {2, 4} {3, 4}/{4, 1} {5, 5}", "Cod.", "Nome", "Cred", "Ano", "S", "Media");
        for(int i = 0; i < h.qtd; i++){
            Console.WriteLine("{0:0000} {1, -50} {2, 4:0} {3:0000}/{4, 1:0} {5:00.00}", h.v[i].codigoDisciplina, h.v[i].nomeAluno, h.v[i].creditos, h.v[i].ano, h.v[i].semestre, media(h.v[i]));
        }
    }

    public static void listar(historicoDisciplina h, int ano, int semestre){
        Console.WriteLine("{0, 4} {1, -50} {2, 4} {3, 4}/{4, 1} {5, 5}", "Cod.", "Nome", "Cred", "Ano", "S", "Media");
        for(int i = 0; i < h.qtd; i++){
            if(h.v[i].ano == ano && h.v[i].semestre == semestre){
                Console.WriteLine("{0:0000} {1, -50} {2, 4:0} {3:0000}/{4, 1:0} {5:00.00}", h.v[i].codigoDisciplina, h.v[i].nomeAluno, h.v[i].creditos, h.v[i].ano, h.v[i].semestre, media(h.v[i]));
            }
        }
    }

    public static void listar(historicoDisciplina h, string txt){
        Console.WriteLine("{0, 4} {1, -50} {2, 4} {3, 4}/{4, 1} {5, 5}", "Cod.", "Nome", "Cred", "Ano", "S", "Media");
        for(int i = 0; i < h.qtd; i++){
            if(h.v[i].nomeAluno.Contains(txt) || h.v[i].nomeProfessor.Contains(txt)){
                Console.WriteLine("{0:0000} {1, -50} {2, 4:0} {3:0000}/{4, 1:0} {5:00.00}", h.v[i].codigoDisciplina, h.v[i].nomeAluno, h.v[i].creditos, h.v[i].ano, h.v[i].semestre, media(h.v[i]));
            }
        }
    }

    public static double cr(historicoDisciplina h){
        double soma = 0;
        int creditos = 0;

        for(int i = 0; i < h.qtd; i++){
            creditos += h.v[i].creditos;
            soma += media(h.v[i]) * h.v[i].creditos;
        }
        return creditos != 0 ? soma / creditos : 0;
    }

    public static void listarHistorico(historicoDisciplina h){
        listar(h);
        Console.WriteLine("{0, -67} {1, 5:00.00}", "Coeficiente de Rendimento", cr(h));
    }
#endregion

    public static void Main(){
        dadosDisciplina d;
        historicoDisciplina h;
        int cod;
        bool fim = false;
        inicializar(out h);

        while(!fim){
            switch(menu()){
                case 1:
                    ler(out d);
                    inserir(ref h, d);
                    Console.WriteLine("Disciplina inserida com sucesso!");
                    break;
                case 2:
                    cod = int.Parse(Console.ReadLine());
                    if(obterIndice(h, cod) > -1){
                        remover(ref h, cod);
                        Console.WriteLine("Disciplina removida com sucesso!");
                    } else{
                        Console.WriteLine("Disciplina nao encontrada!");
                    }
                    break;
                case 3:
                    cod = int.Parse(Console.ReadLine());
                    if(obterIndice(h, cod) > -1){
                        ler(out d);
                        alterar(ref h, cod, d);
                        Console.WriteLine("Disciplina alterada com sucesso!");
                    } else{
                        Console.WriteLine("Disciplina nao encontrada!");
                    }
                    break;
                case 4:
                    listar(h);
                    while(Console.ReadLine() != "Ok");
                    break;
                case 5:
                    listar(h, int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine()));
                    while(Console.ReadLine() != "Ok");
                    break;
                case 6:
                    listar(h, Console.ReadLine());
                    while(Console.ReadLine() != "Ok");
                    break;
                case 7:
                    listarHistorico(h);
                    while(Console.ReadLine() != "Ok");
                    break;
               case 8:
                    fim = true;
                    break;                            
            }
        }
        Console.WriteLine("Obrigado por utilizar o programa de cadastro, volte sempre!");
    }
}