using System;
#region DISCIPLINA
public class dadosDisciplina{
    public int codigoDisciplina, creditos, ano, semestre;
    public double nota1, nota2;
    public string nomeAluno, nomeProfessor;

    public double media(){
        return (nota1 + 2 * nota2) / 3;
    }

    public void ler(){
        Console.WriteLine("Digite o código da disciplina:");
        codigoDisciplina = int.Parse(Console.ReadLine());
        Console.WriteLine("Digite o nome do aluno:");
        nomeAluno = Console.ReadLine();
        Console.WriteLine("Digite o nome do professor:");
        nomeProfessor = Console.ReadLine();
        Console.WriteLine("Digite a quantidade de créditos da disciplina:");
        creditos = int.Parse(Console.ReadLine());
        Console.WriteLine("Digite o ano em que está cursando a disciplina:");
        ano = int.Parse(Console.ReadLine());
        Console.WriteLine("Digite o semestre em que está cursando a disciplina:");
        semestre = int.Parse(Console.ReadLine());
        Console.WriteLine("Digite a primeira nota da disciplina:");
        nota1 = double.Parse(Console.ReadLine());
        Console.WriteLine("Digite a segunda nota da disciplina:");
        nota2 = double.Parse(Console.ReadLine());
    }
}
#endregion

#region HISTORICO
public class historicoDisciplina{
    public dadosDisciplina []v;
    public int qtd;

    public void inicializar(){
        v = new dadosDisciplina[100];
        qtd = 0;
    }

    public void inserir(dadosDisciplina d){
        v[qtd] = d;
        qtd++;
    }

    public int obterIndice(int codigoDisciplina){
        bool achou = false;
        int i = 0;

        while(!achou && i < qtd){
            if(v[i].codigoDisciplina == codigoDisciplina){
                achou = true;
            } else{
                i++;
            }
        }
        return achou ? i : -1;
    }

    public void remover(int codigoDisciplina){
        int pos = obterIndice(codigoDisciplina);

        if(pos > -1){
            for(int i = pos + 1; i < qtd; i++){
                v[i - 1] = v[i];
            }
            qtd--;
        }
    }

    public void alterar(int codigoDisciplina, dadosDisciplina d){
        int pos = obterIndice(codigoDisciplina);

        if(pos > -1){
            v[pos] = d;
        }
    }

    public void listar(){
        Console.WriteLine("{0, 4} {1, -50} {2, 4} {3, 4}/{4, 1} {5, 5}", "Cod.", "Nome", "Cred", "Ano", "S", "Media");
        for(int i = 0; i < qtd; i++){
            Console.WriteLine("{0:0000} {1, -50} {2, 4:0} {3:0000}/{4, 1:0} {5:00.00}", v[i].codigoDisciplina, v[i].nomeAluno, v[i].creditos, v[i].ano, v[i].semestre, v[i].media());
        }
    }

    public void listar(int ano, int semestre){
        Console.WriteLine("{0, 4} {1, -50} {2, 4} {3, 4}/{4, 1} {5, 5}", "Cod.", "Nome", "Cred", "Ano", "S", "Media");
        for(int i = 0; i < qtd; i++){
            if(v[i].ano == ano && v[i].semestre == semestre){
                Console.WriteLine("{0:0000} {1, -50} {2, 4:0} {3:0000}/{4, 1:0} {5:00.00}", v[i].codigoDisciplina, v[i].nomeAluno, v[i].creditos, v[i].ano, v[i].semestre, v[i].media());
            }
        }
    }

    public void listar(string txt){
        Console.WriteLine("{0, 4} {1, -50} {2, 4} {3, 4}/{4, 1} {5, 5}", "Cod.", "Nome", "Cred", "Ano", "S", "Media");
        for(int i = 0; i < qtd; i++){
            if(v[i].nomeAluno.Contains(txt) || v[i].nomeProfessor.Contains(txt)){
                Console.WriteLine("{0:0000} {1, -50} {2, 4:0} {3:0000}/{4, 1:0} {5:00.00}", v[i].codigoDisciplina, v[i].nomeAluno, v[i].creditos, v[i].ano, v[i].semestre, v[i].media());
            }
        }
    }

    public double cr(){
        double soma = 0;
        int creditos = 0;

        for(int i = 0; i < qtd; i++){
            creditos += v[i].creditos;
            soma += v[i].media() * v[i].creditos;
        }
        return creditos != 0 ? soma / creditos : 0;
    }

    public void listarHistorico(){
        listar();
        Console.WriteLine("{0, -67} {1, 5:00.00}", "Coeficiente de Rendimento", cr());
    }
}
#endregion

#region MAIN
public class cadastroDisciplina{
    public static int menu(){
        int opcao;
        
        do{
            Console.WriteLine("1: Inserir nova disciplina");
            Console.WriteLine("2: Remover disciplina pelo código");
            Console.WriteLine("3: Alterar disciplina pelo código");
            Console.WriteLine("4: Listar todas as disciplinas");
            Console.WriteLine("5: Listar disciplinas de um ano/semestre");
            Console.WriteLine("6: Listar disciplinas pelo nome/professor");
            Console.WriteLine("7: Histórico");
            Console.WriteLine("8: Sair");
            Console.WriteLine("Entre com a sua opção:");
            opcao = int.Parse(Console.ReadLine());
        } while(opcao < 1 || opcao > 8);
        return opcao;
    }

    public static void Main(){
        dadosDisciplina d;
        historicoDisciplina h = new historicoDisciplina();
        int codigo;
        bool fim = false;

        h.inicializar();

        while(!fim){
            switch(menu()){
                case 1:
                    d = new dadosDisciplina();
                    d.ler();
                    h.inserir(d);
                    Console.WriteLine("Disciplina inserida com sucesso!");
                    break;
                case 2:
                    codigo = int.Parse(Console.ReadLine());
                    if(h.obterIndice(codigo) > -1){
                        h.remover(codigo);
                        Console.WriteLine("Disciplina removida com sucesso!");
                    } else{
                        Console.WriteLine("Disciplina não encontrada!");
                    }
                    break;
                case 3:
                    codigo = int.Parse(Console.ReadLine());
                    if(h.obterIndice(codigo) > -1){
                        d = new dadosDisciplina();
                        d.ler();
                        h.alterar(codigo, d);
                        Console.WriteLine("Disciplina alterada com sucesso!");
                    } else{
                        Console.WriteLine("Disciplina não encontrada!");
                    }
                    break;
                case 4:
                    h.listar();
                    Console.WriteLine("Digite 'Ok' para continuar:");
                    while(Console.ReadLine() != "Ok");
                    break;
                case 5:
                    h.listar(int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine()));
                    Console.WriteLine("Digite 'Ok' para continuar:");
                    while(Console.ReadLine() != "Ok");
                    break;
                case 6:
                    h.listar(Console.ReadLine());
                    Console.WriteLine("Digite 'Ok' para continuar:");
                    while(Console.ReadLine() != "Ok");
                    break;
                case 7:
                    h.listarHistorico();
                    Console.WriteLine("Digite 'Ok' para continuar:");
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
#endregion