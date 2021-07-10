using System;
using System.Windows.Forms;

namespace Historico{
	class Program{
	
 		[STAThread]		
		public static void Main(String []args){
	        Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FrmPrincipal());
		}
	}
}