using System;
public class URI1046{
    public static void Main(){
        int horaInicio, horaFim, duracao;
        string[] valores = Console.ReadLine().Split(' ');

        horaInicio = int.Parse(valores[0]);
        horaFim = int.Parse(valores[1]);

        duracao = (horaFim - horaInicio);

        if(duracao < 0){
            duracao = 24 + (horaFim - horaInicio);
        }

        if(horaInicio == horaFim){
            Console.WriteLine("O JOGO DUROU 24 HORA(S)");
        } else{
            Console.WriteLine("O JOGO DUROU {0} HORA(S)", duracao);
        }
    }
}