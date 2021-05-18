using System;
public class Media{
    public int peso1, peso2, peso3;
    public double nota1, nota2, nota3, mediaF;

    public void setPesos(int a, int b, int c){
        peso1 = a;
        peso2 = b;
        peso3 = c;
    }

    public void setValores(double a, double b, double c){
        nota1 = a;
        nota2 = b;
        nota3 = c;
    }

    public double media(){
        mediaF = Math.Round((nota1 * peso1 + nota2 * peso2 + nota3 * peso3) / (peso1 + peso2 + peso3), 1);
        return mediaF;
    }
}
public class URI1079POO{
    public static void Main(string []args){
        int N, i;
        Media m = new Media();
        N = Convert.ToInt32(Console.ReadLine());
        m.setPesos(2, 3, 5);
        for(i=0;i<N;i++){
            string Linha = Console.ReadLine();
            string []partes = Linha.Split(' ');
            double v1 = Convert.ToDouble(partes[0]);
            double v2 = Convert.ToDouble(partes[1]);
            double v3 = Convert.ToDouble(partes[2]);
            m.setValores(v1, v2, v3);
            Console.WriteLine("{0:F1}", m.media()); 
        }
    }
}