using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Historico.GUIConsole
{
    public class GUIConsole
    {
        public int Menu()
        {
            int opc;
            do
            {
                Console.WriteLine("1 - Inserir");
                Console.WriteLine("2 - Remover");
                Console.WriteLine("3 - Alterar");
                Console.WriteLine("4 - Listar");
                Console.WriteLine("5 - Sair");
                Console.Write("Entre com a sua opcao:");
                opc = int.Parse(Console.ReadLine());
            } while (opc < 1 || opc > 5);
            return opc;
        }

        public int LerCodigo(string titulo)
        {
            Console.WriteLine("Codigo da disciplina para {0}:", titulo);
            return int.Parse(Console.ReadLine());
        }

        public void Listar(Historico h)
        {
            Console.WriteLine("{0,-30}{1}{2}", "Nome", "Cred", "Media");
            foreach (Disciplina disc in h)
                Console.WriteLine("{0,-30} {1:00} {2:00.00}", disc.Nome, disc.Creditos, disc.Media());
        }

        public void Ler(Disciplina d)
        {
            Console.Write("Codigo: ");
            d.Codigo = int.Parse(Console.ReadLine());
            Console.Write("Nome: ");
            d.Nome = Console.ReadLine();
            Console.Write("Creditos: ");
            d.Creditos = int.Parse(Console.ReadLine());
            Console.Write("Semestre: ");
            d.Semestre = int.Parse(Console.ReadLine());
            Console.Write("Ano: ");
            d.Ano = int.Parse(Console.ReadLine());
            Console.Write("Nota1: ");
            d.Nota1 = double.Parse(Console.ReadLine());
            Console.Write("Nota2: ");
            d.Nota2 = double.Parse(Console.ReadLine());

        }
    }
}
