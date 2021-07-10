using System;
using System.Drawing;
using System.Windows.Forms;

namespace Historico.GUITosca
{
	public partial class FrmCodigo : Form
	{
		#region singleton (design pattern)
        private FrmCodigo()
        {
            InitializeComponent();
        }

        private static FrmCodigo _Instancia = null;

        public static int Executar(string motivo)
        {
            if (_Instancia == null)
                _Instancia = new FrmCodigo();
            _Instancia.lblTitulo.Text = "Entre com o código para "+motivo;
            _Instancia.Text = motivo;
            if (_Instancia.ShowDialog() == DialogResult.OK)
            	return int.Parse(_Instancia.tbxCodigo.Text);
            else
                return -1;
        }
        #endregion
	}
}
