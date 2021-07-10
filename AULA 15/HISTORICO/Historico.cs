using System;
using System.Collections;
using System.Collections.Generic;

namespace Historico
{
	public class Historico : IEnumerable<Disciplina>
	{
		private ICollection<Disciplina> vet;
		
		public Historico()
		{
			vet = new List<Disciplina>();
		}
		public void Inserir(Disciplina d)
		{
			vet.Add(d);
		}	
		private Disciplina ObterDisciplina(int codigo)
		{
            foreach (Disciplina disc in vet)
                if (disc.Codigo == codigo)
                    return disc;
            return null;
            /*IEnumerator<Disciplina> it = vet.GetEnumerator();
			bool achou = false;
			while (it.MoveNext() && !achou)
				if (it.Current.Codigo == codigo)
					achou = true;
			return achou? it.Current : null;				
            */
        }
		public void Remover(int codigo)
		{
			Disciplina alvo = ObterDisciplina(codigo);
			if (alvo!=null)
                vet.Remove(alvo);
		}
		public void Alterar(int codigo, Disciplina d)
		{
            Disciplina alvo = ObterDisciplina(codigo);
            if (alvo != null)
            {
                vet.Add(d);
                vet.Remove(alvo);
            }
		}

        public IEnumerator<Disciplina> GetEnumerator()
        {
            return vet.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return vet.GetEnumerator();
        }
    }
}
