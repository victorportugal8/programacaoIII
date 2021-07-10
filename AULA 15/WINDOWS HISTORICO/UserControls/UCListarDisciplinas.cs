/*
 * Created by SharpDevelop.
 * User: user
 * Date: 07/06/2021
 * Time: 21:44
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Historico.UserControls
{
	/// <summary>
	/// Description of UCListarDisciplinas.
	/// </summary>
	public partial class UCListarDisciplinas : UserControl
	{
		private IEnumerable<Disciplina> disciplinas;
		private string filtro;
		public string Filtro{
			get { return filtro;}
			set { filtro = string.IsNullOrEmpty(value)?value:value.ToLower();
				AtualizarTela();
			}
		}
		
		public IEnumerable<Disciplina> Disciplinas {
			get{
				return disciplinas;
			}
			set{
				disciplinas = value;
				AtualizarTela();
			}
		}
		
		public UCListarDisciplinas()
		{
			InitializeComponent();
		}
		
		private bool PassaNoFiltro(Disciplina d)
		{
			return string.IsNullOrEmpty(filtro) || d.Nome.ToLower().Contains(filtro) || d.Codigo.ToString().Contains(filtro);
		}
		
		public void AtualizarTela()
        {
        	lvwHistorico.Items.Clear();
        	int i=1;
        	if (disciplinas!=null)
	        	foreach(Disciplina d in disciplinas)
        			if (PassaNoFiltro(d))
	        		{
		        		ListViewItem item = new ListViewItem(i.ToString("000"));
		        		item.Tag = d;
		        		item.SubItems.Add(d.Nome);
		        		item.SubItems.Add(d.Creditos.ToString());
		        		item.SubItems.Add(d.Media().ToString("0.00"));
		        		lvwHistorico.Items.Add(item);
		        		i++;
	        		}
        }
		void Copiar(object sender, EventArgs e)
		{
			StringBuilder sb = new StringBuilder();
			foreach(ListViewItem item in lvwHistorico.Items)
			{
				sb.AppendFormat("{0},{1},{2},{3}\n", item.Text, item.SubItems[1].Text, item.SubItems[2].Text,item.SubItems[3].Text);
			}
			Clipboard.SetText(sb.ToString());
		}
		
		public Disciplina GetSelecionado()
		{
			if (lvwHistorico.SelectedItems.Count==1)
				return lvwHistorico.SelectedItems[0].Tag as Disciplina;
			else
				return null;
		}
	}
}
