using System;
using System.Collections.Generic;
using System.Text;

namespace HistoricoDisciplinas{
    public class DisciplinaTipo3 : Disciplina{
        private double notaMonografia, notaApresentacao, notaPratica;

        public override void Ler(){
            base.Ler();
            Console.Write("Digite a nota da monografia:\n");
            notaMonografia = double.Parse(Console.ReadLine());
            Console.Write("Digite a nota da apresentacao:\n");
            notaApresentacao = double.Parse(Console.ReadLine());
            Console.Write("Digite a nota pratica:\n");
            notaPratica = double.Parse(Console.ReadLine());
        }

        public override double Media(){
            return ((2 * notaMonografia) + (3 * notaApresentacao) + notaPratica) / 6;
        }

        public double NotaApresentacao{
            get{
                return notaApresentacao;
            }
        }
    }
}