using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Historico.GUITosca
{
    public class GUITosca
    {
        public int Menu()
        {
            return FrmMenu.Executar();
        }

        public int LerCodigo(string titulo)
        {
            return FrmCodigo.Executar(titulo);
        }

        public void Listar(Historico h)
        {
        	FrmListar.Executar(h);
        }

        public void Ler(Disciplina d)
        {
            FrmAluno.Executar(d);
        }
    }
}
