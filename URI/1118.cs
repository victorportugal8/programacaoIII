using System;
public class URI1118{
    public static void Main(){
        double nota1, nota2 = 0, mediaSemestre, d, e, f, g = 0, h = 1, x = 1, y = 1, z = 1;

        for(h = 1; ;h = 1, x = 1, y = 1, z = 1){
            nota1 = Convert.ToDouble(Console.ReadLine());

            if(nota1 < 0 || nota1 > 10){
                Console.WriteLine("nota invalida");
                continue;
            }

            while(x == 1){
                nota2 = Convert.ToDouble(Console.ReadLine());

                if(nota2 < 0 || nota2 > 10){
                    Console.WriteLine("nota invalida");
                    continue;
                }
                x += 2;
            }

            mediaSemestre = (nota1 + nota2) / 2.0;
            Console.WriteLine("media = {0:F2}", mediaSemestre);
            Console.WriteLine("novo calculo (1-sim 2-nao)");

            while(y == 1){
                g = Convert.ToDouble(Console.ReadLine());

                if(g < 1 || g > 2){
                    Console.WriteLine("novo calculo (1-sim 2-nao)");
                    continue;
                }
                y += 2;
            }

            if(g == 2){
                break;
            }
        }
    }
}