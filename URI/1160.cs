using System;
public class URI1160{
    public static void Main(){
        int T, PA, PB, anos;
        double G1, G2, porcA, porcB;

        T = int.Parse(Console.ReadLine());

        for (int i = 0; i < T; i++){
            String[] vet = Console.ReadLine().Split(' ');

            PA = int.Parse(vet[0]);
            PB = int.Parse(vet[1]);
            G1 = double.Parse(vet[2]);
            G2 = double.Parse(vet[3]);
                        
            for(anos = 0; PA <= PB && anos <= 100; anos++){
                porcA = PA * G1 / 100;
                porcB = PB * G2 / 100;
                PA = (int)(PA + porcA);
                PB = (int)(PB + porcB);
            }
                    
            if (anos <= 100){
                Console.WriteLine("{0} anos.", anos);
            } else{
                Console.WriteLine("Mais de 1 seculo.");
            }

        }
    }
}