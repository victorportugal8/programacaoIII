using System;

namespace Historico
{
	class Program
	{
	
 		[STAThread]		
		public static void Main(String []args)
		{
			Historico h = new Historico();
			Disciplina d;
            GUITosca.GUITosca gui = new GUITosca.GUITosca();
			int codigo;
			bool fim=false;
			while (!fim)
			{
				switch(gui.Menu())
				{
					case 1:
                        d = new Disciplina();
                        gui.Ler(d);
						h.Inserir(d);
						break;	
					case 2:codigo = gui.LerCodigo("Remover");
						h.Remover(codigo);
						break;
					case 3:
                        codigo = gui.LerCodigo("Alterar");
                        h.Remover(codigo);
                        d = new Disciplina();
                        gui.Ler(d);
                        h.Alterar(codigo, d);
						break;
					case 4: gui.Listar(h);			
						break;	
					case 5: fim=true;
						break;	
				}
			}			
		}
	}
}