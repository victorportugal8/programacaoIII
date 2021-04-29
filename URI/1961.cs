using System;
public class URI1961{
    public static void Main(){
        int i, altura, n;
        string linha;
        bool win = true;
        string[] aux;

        linha = Console.ReadLine();
        aux = linha.Split(' ');

        altura = int.Parse(aux[0]);
        n = int.Parse(aux[1]);

        linha = Console.ReadLine();
        aux = linha.Split(' ');

        for(i = 0; i < n - 1 && win; i++){
            if(Math.Abs(int.Parse(aux[i]) - int.Parse(aux[i + 1])) > altura){
                win = false;
            }
        }

        if(win){
            Console.WriteLine("YOU WIN");
        } else{
            Console.WriteLine("GAME OVER");
        }
    }
}