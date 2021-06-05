using System;
using System.Collections.Generic;
using System.Text;

namespace HistoricoDisciplinas{
    public class DisciplinaTipo2 : DisciplinaTipo1{
        public override double Media(){
            return (nota1 + (2 * nota2)) / 3;
        }
    }
}