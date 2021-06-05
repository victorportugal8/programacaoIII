using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace HistoricoDisciplinas.GUITosca{
    public partial class FrmAluno : Form{
        #region singleton(design pattern)
        private FrmAluno(){
            InitializeComponent();
        }

        private static FrmAluno _Instancia = null;

        public static bool Executar(Disciplina d){
            if(_Instancia == null){
                _Instancia = new FrmAluno();
            }
            _Instancia.AtualizarTela(d);

            if(_Instancia.ShowDialog() == DialogResult.OK){
                _Instancia.AtualizarObjeto(d);
                return true;
            } else{
                return false;
            }
        }
        #endregion

        private void AtualizarTela(Disciplina d){
            tbxCodigo.Text = d.Codigo.ToString();
            tbxNome.Text = d.Nome;
            tbxAno.Text = d.Ano.ToString();
            tbxSemestre.Text = d.Semestre.ToString();
            tbxCreditos.Text = d.Creditos.ToString();
            tbxNota1.Text = d.Nota1.ToString();
            tbxNota2.Text = d.Nota2.ToString();
        }

        private void AtualizarObjeto(Disciplina d){
            d.Codigo = int.Parse(tbxCodigo.Text);
            d.Nome = tbxNome.Text;
            d.Ano = int.Parse(tbxAno.Text);
            d.Semestre = int.Parse(tbxSemestre.Text);
            d.Creditos = int.Parse(tbxCreditos.Text);
            d.Nota1 = double.Parse(tbxNota1.Text);
            d.Nota2 = double.Parse(tbxNota2.Text);
        }
    }
}