using System;
using System.Drawing;
using System.Windows.Forms;
using Historico.GUITosca;
using Historico.UserControls;

namespace Historico{
	/// <summary>
	/// Description of FrmPrincipal.
	/// </summary>
	public partial class FrmPrincipal : Form{
		private Historico h;
		public FrmPrincipal(){
			InitializeComponent();
			h = new Historico();
			ucListarDisciplinas1.Disciplinas = h;
		}
		
		void acao(object sender, EventArgs e){
			if (sender == btnInserir){	
				Disciplina d = new Disciplina();
				if (FrmAluno.Executar(d)){
					h.Inserir(d);
					ucListarDisciplinas1.AtualizarTela();
				}
			} else if (sender == btnRemover){
				if (ucListarDisciplinas1.GetSelecionado() == null)
					MessageBox.Show("Uma disciplina deve estar selecionada para poder remover");
				else{
					Disciplina d = ucListarDisciplinas1.GetSelecionado();
					if (MessageBox.Show("Tem certeza que deseja remover a disciplina: "+d.Nome+" ?", "Remover",
					                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes){
                    	h.Remover(ucListarDisciplinas1.GetSelecionado().Codigo);
                    	ucListarDisciplinas1.AtualizarTela();
					}
                }
			} else if (sender == btnAlterar){
				if (ucListarDisciplinas1.GetSelecionado() == null)
					MessageBox.Show("Uma disciplina deve estar selecionada para poder alterar");
				else{
					Disciplina d = ucListarDisciplinas1.GetSelecionado();
					int cod = d.Codigo;
					if (FrmAluno.Executar(d)){
						h.Alterar(cod,d);
						ucListarDisciplinas1.AtualizarTela();
					}
				}
			}else if (sender == btnFiltrar || sender==tbxFiltro){
				ucListarDisciplinas1.Filtro = tbxFiltro.Text;
				ucListarDisciplinas1.AtualizarTela();
			}
			else if (sender == btnSair)
				Application.Exit();
		}
	}
}