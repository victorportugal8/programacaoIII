/*
 * Created by SharpDevelop.
 * User: user
 * Date: 07/06/2021
 * Time: 21:44
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Historico.UserControls
{
	partial class UCListarDisciplinas
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.ListView lvwHistorico;
		private System.Windows.Forms.ColumnHeader columnHeader2;
		private System.Windows.Forms.ColumnHeader columnHeader3;
		private System.Windows.Forms.ColumnHeader columnHeader4;
		private System.Windows.Forms.ColumnHeader columnHeader5;
		
		/// <summary>
		/// Disposes resources used by the control.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
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
		private void InitializeComponent()
		{
			this.lvwHistorico = new System.Windows.Forms.ListView();
			this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader4 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader5 = new System.Windows.Forms.ColumnHeader();
			this.SuspendLayout();
			// 
			// lvwHistorico
			// 
			this.lvwHistorico.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
			this.columnHeader2,
			this.columnHeader3,
			this.columnHeader4,
			this.columnHeader5});
			this.lvwHistorico.Dock = System.Windows.Forms.DockStyle.Fill;
			this.lvwHistorico.FullRowSelect = true;
			this.lvwHistorico.GridLines = true;
			this.lvwHistorico.HideSelection = false;
			this.lvwHistorico.Location = new System.Drawing.Point(0, 0);
			this.lvwHistorico.Name = "lvwHistorico";
			this.lvwHistorico.Size = new System.Drawing.Size(849, 556);
			this.lvwHistorico.TabIndex = 3;
			this.lvwHistorico.UseCompatibleStateImageBehavior = false;
			this.lvwHistorico.View = System.Windows.Forms.View.Details;
			// 
			// columnHeader2
			// 
			this.columnHeader2.Text = "#";
			this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// columnHeader3
			// 
			this.columnHeader3.Text = "Nome";
			this.columnHeader3.Width = 300;
			// 
			// columnHeader4
			// 
			this.columnHeader4.Text = "Créditos";
			this.columnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.columnHeader4.Width = 90;
			// 
			// columnHeader5
			// 
			this.columnHeader5.Text = "Média";
			this.columnHeader5.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.columnHeader5.Width = 80;
			// 
			// UCListarDisciplinas
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.lvwHistorico);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
			this.Name = "UCListarDisciplinas";
			this.Size = new System.Drawing.Size(849, 556);
			this.ResumeLayout(false);

		}
	}
}
