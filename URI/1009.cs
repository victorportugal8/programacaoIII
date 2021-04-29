using System;
public class URI1009{
    public static void Main(){
        string[] nome = Console.ReadLine().Split(' ');
        double salario, vendasMes, bonus, salarioFinal;

        salario = Convert.ToDouble(Console.ReadLine());
        vendasMes = Convert.ToDouble(Console.ReadLine());

        bonus = vendasMes * 0.15;

        salarioFinal = salario + bonus;

        Console.WriteLine("TOTAL = R$ {0:F2}", salarioFinal);
    }
}