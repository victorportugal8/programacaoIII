using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HistoricoDisciplinas.GUIConsole{
    public class GUIConsole{
        public int Menu(){
            int opc;

            do{
                Console.WriteLine("1: Inserir disciplina");
                Console.WriteLine("2: Remover disciplina");
                Console.WriteLine("3: Alterar disciplina");
                Console.WriteLine("4: Listar todas as disciplinas");
                Console.WriteLine("5: Sair");
                Console.Write("Entre com a sua opcao:\n");
                opc = int.Parse(Console.ReadLine());
            } while(opc < 1 || opc > 5);
            return opc;
        }

        public int LerCodigo(string titulo){
            Console.WriteLine("Codigo da disciplina para {0}:\n", titulo);
            return int.Parse(Console.ReadLine());
        }

        public void Listar(Historico h){
            Console.WriteLine("{0, -30}{1}{2}", "Nome", "Cred", "Media");
            foreach(Disciplina disc in h){
                Console.WriteLine("{0, -30} {1:00} {2:00.00}", disc.Nome, disc.Creditos, disc.Media());
            }
        }

        public void ler(Disciplina d){
            Console.Write("Digite o codigo da disciplina:\n");
            d.Codigo = int.Parse(Console.ReadLine());
            Console.Write("Digite o nome da disciplina:\n");
            d.Nome = Console.ReadLine();
            Console.Write("Digite a quantidade de creditos da disciplina:\n");
            d.Creditos = int.Parse(Console.ReadLine());
            Console.Write("Digite o semestre da disciplina:\n");
            d.Semestre = int.Parse(Console.ReadLine());
            Console.Write("Digite o ano da disciplina:\n");
            d.Ano = int.Parse(Console.ReadLine());
            Console.Write("Digite a primeira nota:\n");
            d.Nota1 = double.Parse(Console.ReadLine());
            Console.Write("Digite a segunda nota:\n");
            d.Nota2 = double.Parse(Console.ReadLine());
        }
    }
}