using System;
class Program{
	public static void Main(){
		int x;
		float a;
		double b;
		string nome;
		
		Console.WriteLine("entre com o nome:");
		nome = Console.ReadLine();

		Console.WriteLine("Entre com um numero real:");
		//a = float.Parse(Console.ReadLine());
		a = Convert.ToSingle(Console.ReadLine());

		Console.WriteLine("Entre com outro numero real:");
		//b = double.Parse(Console.ReadLine());
		b = Convert.ToDouble(Console.ReadLine());

		Console.WriteLine("Entre com um numero inteiro:");
		//x = int.Parse(Console.ReadLine());
		x = Convert.ToInt32(Console.ReadLine());

		Console.WriteLine("Nome={0}\nA={1}\nB={2}\nX={3}", nome, a,b,x); 				
	}
}