using System;
public class URI1165{
    public static void Main(){
        int n, x, i, j, p = 0;

        n = Convert.ToInt32(Console.ReadLine());

        for(i = 1; i <= n; i++){
            x = Convert.ToInt32(Console.ReadLine());
            for(j = 1, p = 0; j < x; j++){
                if(x % j == 0){
                    p += j;
                }
            }
            if(p == 1){
                Console.WriteLine("{0} eh primo", x);
            } else{
                Console.WriteLine("{0} nao eh primo", x);
            }
        }
    }
}