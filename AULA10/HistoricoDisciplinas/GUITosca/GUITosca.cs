using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HistoricoDisciplinas.GUITosca{
    public class GUITosca{
        public int Menu(){
            return FrmMenu.Executar();
        }

        public int LerCodigo(string titulo){
            Console.WriteLine("Codigo da disciplina para {0}:\n", titulo);
            return int.Parse(Console.ReadLine());
        }

        public void Listar(Historico h){
            Console.WriteLine("{0, -30}{1}{2}", "Nome", "Cred", "Media");
            foreach (Disciplina disc in h){
                Console.WriteLine("{0, -30} {1:00} {2:00.00}", disc.Nome, disc.Creditos, disc.Media());
            }
        }

        public void Ler(Disciplina d){
            FrmAluno.Executar(d);
        }
    }
}