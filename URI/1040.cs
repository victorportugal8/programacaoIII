using System;
public class URI1040{
  public static void Main() {
    double a, b, c, d, last, m;
    string [] s = Console.ReadLine().Split(' ');
    
    a = Convert.ToDouble(s[0]);
    b = Convert.ToDouble(s[1]);
    c = Convert.ToDouble(s[2]);
    d = Convert.ToDouble(s[3]);
    
    m = Math.Round((a * 2 + b * 3 + c * 4 + d) / 10, 1);
    
    Console.WriteLine("Media: {0:F1}", m);
    
    if(m >= 7.0){
        Console.WriteLine("Aluno aprovado.");
    } else if(m >= 5.0){
        Console.WriteLine("Aluno em exame.");
        last = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Nota do exame: {0:F1}", last);
        
        if((last + m) / 2.0 > 5.0){
            Console.WriteLine("Aluno aprovado.");
        } else{
            Console.WriteLine("Aluno reprovado.");
        }
        Console.WriteLine("Media final: {0:F1}", (last + m) / 2.0);
    } else{
        Console.WriteLine("Aluno reprovado.");
    }
  }
}