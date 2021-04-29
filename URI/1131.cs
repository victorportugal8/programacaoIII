using System;
public class URI1131{
  public static void Main(){
    int x, inter, grem, empt, gi, gg, resp, cont;
    
    cont = inter = grem = empt = 0;
    
    do{
        string[] s = Console.ReadLine().Split(' ');
        cont++;
        gi = int.Parse(s[0]);
        gg = int.Parse(s[1]);
        
        if(gi == gg){
            empt++;
        } else if(gi < gg){
            grem++;
        } else if(gi > gg){
            inter++;
        }
        
        Console.WriteLine("Novo grenal (1-sim 2-nao)");
        resp = Convert.ToInt32(Console.ReadLine());
    } while (resp == 1);
    
    Console.WriteLine("{0} grenais", cont);
    Console.WriteLine("Inter:{0}", inter);
    Console.WriteLine("Gremio:{0}", grem);
    Console.WriteLine("Empates:{0}", empt);
    
    if(inter > grem){
        Console.WriteLine("Inter venceu mais");
    } else if(inter < grem){
        Console.WriteLine("Gremio venceu mais");
    } else if(inter == grem){
        Console.WriteLine("Nao houve vencedor");
    }
  }
}