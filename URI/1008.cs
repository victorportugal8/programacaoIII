using System;

public class URI1008{
	public static void Main(){
		int nFuncionario, horaTrabalhada;
		double salarioHora, salario;
		
		nFuncionario = Convert.ToInt32(Console.ReadLine());
		horaTrabalhada = Convert.ToInt32(Console.ReadLine());
		salarioHora = Convert.ToDouble(Console.ReadLine());
		
		salario = horaTrabalhada * salarioHora;
		
		Console.WriteLine("NUMBER = {0} ", nFuncionario);
		Console.WriteLine("SALARY = R$ {0:F2} ", salario);
	}
}