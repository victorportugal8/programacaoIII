using System;

public class URI1002{
	public static void Main(){
	    double n, r, area;
		
		r = Convert.ToDouble(Console.ReadLine());
		n = 3.14159;
		area = n * (r * r);
		
		Console.WriteLine("A={0:F4}", area);
	}
}