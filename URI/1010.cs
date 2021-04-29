using System;
public class URI1010{
    public static void Main(){
        int codigoP1, qtdP1, codigoP2, qtdP2;
        double valorUnitP1, valorUnitP2, total;
        string[] peca1 = Console.ReadLine().Split(' ');
        string[] peca2 = Console.ReadLine().Split(' ');

        codigoP1 = int.Parse(peca1[0]);
        qtdP1 = int.Parse(peca1[1]);
        valorUnitP1 = double.Parse(peca1[2]);

        codigoP2 = int.Parse(peca2[0]);
        qtdP2 = int.Parse(peca2[1]);
        valorUnitP2 = double.Parse(peca2[2]);

        total = (qtdP1 * valorUnitP1) + (qtdP2 * valorUnitP2);

        Console.WriteLine("VALOR A PAGAR: R$ {0:F2}", total);
    }
}