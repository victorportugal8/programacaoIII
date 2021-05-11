using System;
public class controleDisciplinas{
    public static int menu(){
        int opc;

        do{
            Console.Clear();
            Console.WriteLine("1 - ler dados da disciplina");
            Console.WriteLine("2 - mostrar os dados da disciplina");
            Console.WriteLine("3 - sair");
            Console.WriteLine("Entre com a sua opcao:");
            opc = int.Parse(Console.ReadLine());
        } while(opc < 1 || opc > 3);
        Console.Clear();
        return opc;
    }

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

    public static void Main(){
        dadosDisciplina x = new dadosDisciplina();
        bool fim = false;

        while(!fim){
            switch(menu()){
                case 1:
                    ler(out x);
                    break;
                case 2:
                    mostrar(x);
                    while(Console.ReadLine() != "Ok");
                    break;
               case 3:
                    fim = true;
                    break;                            
            }
        }
        Console.WriteLine("Obrigado por utilizar o programa de cadastro, volte sempre!");
    }
}