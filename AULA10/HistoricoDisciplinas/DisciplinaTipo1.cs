using System;
using System.Collections.Generic;
using System.Text;

namespace HistoricoDisciplinas{
    public class DisciplinaTipo1 : Disciplina{
        protected double nota1, nota2;

        public override void Ler(){
            base.Ler();
            Console.Write("Digite a primeira nota:\n");
            nota1 = double.Parse(Console.ReadLine());
            Console.Write("Digite a segunda nota:\n");
            nota2 = double.Parse(Console.ReadLine());
        }

        public override double Media(){
            return (nota1 + nota2) / 2;
        }
    }
}