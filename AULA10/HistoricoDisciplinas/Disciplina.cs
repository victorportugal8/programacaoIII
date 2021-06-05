using System;
using System.Collections.Generic;
using System.Text;

namespace HistoricoDisciplinas{
    public abstract class Disciplina{
        private int codigo, creditos, semestre, ano;
        private string nome;

        public virtual void Ler(){
            Console.Write("Digite o codigo da disciplina:\n");
            codigo = int.Parse(Console.ReadLine());
            Console.Write("Digite o nome da disciplina:\n");
            nome = Console.ReadLine();
            Console.Write("Digite a quantidade de creditos da disciplina:\n");
            creditos = int.Parse(Console.ReadLine());
            Console.Write("Digite o semestre da disciplina:\n");
            semestre = int.Parse(Console.ReadLine());
            Console.Write("Digite o ano da disciplina:\n");
            ano = int.Parse(Console.ReadLine());
        }

        public abstract double Media();

        public int Codigo{
            get{
                return codigo;
            }
        }

        public string Nome{
            get{
                return nome;
            }
        }

        public int Creditos{
            get{
                return creditos;
            }
        }
    }
}