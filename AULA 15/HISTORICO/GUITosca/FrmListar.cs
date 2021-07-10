/*
 * Created by SharpDevelop.
 * User: user
 * Date: 07/06/2021
 * Time: 21:04
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Collections.Generic;

namespace Historico.GUITosca
{
	/// <summary>
	/// Description of FrmListar.
	/// </summary>
	public partial class FrmListar : Form
	{
		 #region singleton (design pattern)
        private FrmListar()
        {
            InitializeComponent();
        }

        private static FrmListar _Instancia = null;

        public static void Executar(IEnumerable<Disciplina> dados)
        {
            if (_Instancia == null)
                _Instancia = new FrmListar();
            _Instancia.AtualizarTela(dados);
            _Instancia.ShowDialog();
        }
        #endregion
        
        private void AtualizarTela(IEnumerable<Disciplina> dados)
        {
        	lvwHistorico.Items.Clear();
        	int i=1;
        	foreach(Disciplina d in dados)
        	{
        		ListViewItem item = new ListViewItem(i.ToString("000"));
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
	}
}
