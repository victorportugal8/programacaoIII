namespace Historico{
	partial class FrmPrincipal{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.ToolStrip toolStrip1;
		private System.Windows.Forms.ToolStripButton btnInserir;
		private System.Windows.Forms.ToolStripButton btnRemover;
		private System.Windows.Forms.ToolStripButton btnAlterar;
		private System.Windows.Forms.ToolStripTextBox tbxFiltro;
		private System.Windows.Forms.ToolStripButton btnFiltrar;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
		private System.Windows.Forms.ToolStripButton btnSair;
		private UserControls.UCListarDisciplinas ucListarDisciplinas1;
		private System.Windows.Forms.ImageList imageList1;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing){
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent(){
            this.components = new System.ComponentModel.Container();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnInserir = new System.Windows.Forms.ToolStripButton();
            this.btnRemover = new System.Windows.Forms.ToolStripButton();
            this.btnAlterar = new System.Windows.Forms.ToolStripButton();
            this.tbxFiltro = new System.Windows.Forms.ToolStripTextBox();
            this.btnFiltrar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnSair = new System.Windows.Forms.ToolStripButton();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.ucListarDisciplinas1 = new UserControls.UCListarDisciplinas();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(48, 48);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnInserir,
            this.btnRemover,
            this.btnAlterar,
            this.tbxFiltro,
            this.btnFiltrar,
            this.toolStripSeparator1,
            this.btnSair});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(730, 70);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnInserir
            // 
            this.btnInserir.Image = global::Historico.Properties.Resources.inserir;
            this.btnInserir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnInserir.Name = "btnInserir";
            this.btnInserir.Size = new System.Drawing.Size(52, 67);
            this.btnInserir.Text = "Inserir";
            this.btnInserir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnInserir.ToolTipText = "Inserir uma nova disciplina";
            this.btnInserir.Click += new System.EventHandler(this.acao);
            // 
            // btnRemover
            // 
            this.btnRemover.Image = global::Historico.Properties.Resources.lixeira;
            this.btnRemover.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnRemover.Name = "btnRemover";
            this.btnRemover.Size = new System.Drawing.Size(58, 67);
            this.btnRemover.Text = "Remover";
            this.btnRemover.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnRemover.ToolTipText = "Remover a Disciplina Selecionada";
            this.btnRemover.Click += new System.EventHandler(this.acao);
            // 
            // btnAlterar
            // 
            this.btnAlterar.Image = global::Historico.Properties.Resources.upload;
            this.btnAlterar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(52, 67);
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnAlterar.ToolTipText = "Alterar os dados da disciplina selecionada";
            this.btnAlterar.Click += new System.EventHandler(this.acao);
            // 
            // tbxFiltro
            // 
            this.tbxFiltro.Name = "tbxFiltro";
            this.tbxFiltro.Size = new System.Drawing.Size(300, 70);
            this.tbxFiltro.TextChanged += new System.EventHandler(this.acao);
            // 
            // btnFiltrar
            // 
            this.btnFiltrar.Image = global::Historico.Properties.Resources.pesquisar;
            this.btnFiltrar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnFiltrar.Name = "btnFiltrar";
            this.btnFiltrar.Size = new System.Drawing.Size(52, 67);
            this.btnFiltrar.Text = "Filtrar";
            this.btnFiltrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnFiltrar.ToolTipText = "Filtrar as disciplinas do historico";
            this.btnFiltrar.Click += new System.EventHandler(this.acao);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 70);
            // 
            // btnSair
            // 
            this.btnSair.Image = global::Historico.Properties.Resources.voltar;
            this.btnSair.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(52, 67);
            this.btnSair.Text = "Sair";
            this.btnSair.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnSair.ToolTipText = "Encerrar o programa";
            this.btnSair.Click += new System.EventHandler(this.acao);
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // ucListarDisciplinas1
            // 
            this.ucListarDisciplinas1.Disciplinas = null;
            this.ucListarDisciplinas1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucListarDisciplinas1.Filtro = null;
            this.ucListarDisciplinas1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ucListarDisciplinas1.Location = new System.Drawing.Point(0, 70);
            this.ucListarDisciplinas1.Margin = new System.Windows.Forms.Padding(6);
            this.ucListarDisciplinas1.Name = "ucListarDisciplinas1";
            this.ucListarDisciplinas1.Size = new System.Drawing.Size(730, 422);
            this.ucListarDisciplinas1.TabIndex = 1;
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(730, 492);
            this.Controls.Add(this.ucListarDisciplinas1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "FrmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmPrincipal";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

		}
	}
}