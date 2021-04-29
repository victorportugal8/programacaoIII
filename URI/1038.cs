using System;
public class URI1038{
    public static void Main(){
        int codigo, qtd;
        double preco;
        string[] pedido = Console.ReadLine().Split(' ');

        codigo = int.Parse(pedido[0]);
        qtd = int.Parse(pedido[1]);
        preco = 0;

        switch(codigo){
            case 1:
                preco = (4.00 * qtd);
                break;
            case 2:
                preco = (4.50 * qtd);
                break;
            case 3:
                preco = (5.00 * qtd);
                break;
            case 4:
                preco = (2.00 * qtd);
                break;
            case 5:
                preco = (1.50 * qtd);
                break;
        }

        Console.WriteLine("Total: R$ {0:F2}", preco);
    }
}