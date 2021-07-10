using System;

namespace Historico
{
	public class Disciplina
	{
		public int Codigo   { get; set; }
		public string Nome  { get; set; }
		public int Creditos { get; set; }
		public int Semestre { get; set; } 
		public int Ano      { get; set; }
        public double Nota1 { get; set; }
        public double Nota2 { get; set; }

        public double Media()
        {
            return (Nota1 + Nota2) / 2;
        }

        /*public int Codigo
		{ 
			get
			{
				return codigo;
			}
            set
            {
                codigo = value;
            }
		}
		public string Nome
		{ 
			get 
			{
				return nome;
			}
            set
            {
                nome = value;
            }
		}
		public int Creditos
		{ 
			get 
			{
				return creditos;
			}
            set
            {
                creditos = value;
            }
		}*/
	}
}
