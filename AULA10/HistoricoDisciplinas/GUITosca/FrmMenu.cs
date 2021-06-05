using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace HistoricoDisciplinas.GUITosca{
    public partial class FrmMenu : Form{
        private int opc;

        #region  singleton(design pattern)
        private FrmMenu(){
            InitializeComponent();
        }

        private static FrmMenu _Instancia = null;

        public static int Executar(){
            if(_Instancia == null){
                _Instancia = new FrmMenu();
            }
            _Instancia.ShowDialog();
            return _Instancia.opc;
        }
        #endregion

        private void Acao(object sender, EventArgs e){
            if(sender == btnInserir){
                opc = 1;
            } else if(sender == btnRemover){
                opc = 2;
            } else if(sender == btnAlterar){
                opc = 3;
            } else if(sender == btnListar){
                opc = 4;
            } else if(sender == btnSair){
                opc = 5;
            }
            Close();
        }
    }
}