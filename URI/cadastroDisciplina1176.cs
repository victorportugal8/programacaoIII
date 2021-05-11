using System;
public class cadastroDisciplina{
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
	    ler(out x);
	    mostrar(x);
	}
}