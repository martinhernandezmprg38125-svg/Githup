/*
 * Creado por SharpDevelop.
 * Usuario: CC2_PC24
 * Fecha: 27/10/2026
 * Hora: 07:28 a. m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
namespace Operaciones_basicas
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
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
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.txtN1 = new System.Windows.Forms.TextBox();
			this.txtN2 = new System.Windows.Forms.TextBox();
			this.btnSumar = new System.Windows.Forms.Button();
			this.btnRestar = new System.Windows.Forms.Button();
			this.btnMultiplica = new System.Windows.Forms.Button();
			this.bntDividir = new System.Windows.Forms.Button();
			this.btnModulo = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(2, 2);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(70, 23);
			this.label1.TabIndex = 0;
			this.label1.Text = "NUMERO 1:";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(2, 29);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(70, 23);
			this.label2.TabIndex = 1;
			this.label2.Text = "NUMERO 2:";
			// 
			// txtN1
			// 
			this.txtN1.Location = new System.Drawing.Point(79, 2);
			this.txtN1.Name = "txtN1";
			this.txtN1.Size = new System.Drawing.Size(100, 20);
			this.txtN1.TabIndex = 2;
			// 
			// txtN2
			// 
			this.txtN2.Location = new System.Drawing.Point(79, 29);
			this.txtN2.Name = "txtN2";
			this.txtN2.Size = new System.Drawing.Size(100, 20);
			this.txtN2.TabIndex = 3;
			// 
			// btnSumar
			// 
			this.btnSumar.Location = new System.Drawing.Point(2, 76);
			this.btnSumar.Name = "btnSumar";
			this.btnSumar.Size = new System.Drawing.Size(75, 23);
			this.btnSumar.TabIndex = 4;
			this.btnSumar.Text = "SUMAR";
			this.btnSumar.UseVisualStyleBackColor = true;
			this.btnSumar.Click += new System.EventHandler(this.BtnSumarClick);
			// 
			// btnRestar
			// 
			this.btnRestar.Location = new System.Drawing.Point(79, 75);
			this.btnRestar.Name = "btnRestar";
			this.btnRestar.Size = new System.Drawing.Size(75, 23);
			this.btnRestar.TabIndex = 5;
			this.btnRestar.Text = "RESTAR";
			this.btnRestar.UseVisualStyleBackColor = true;
			this.btnRestar.Click += new System.EventHandler(this.BtnRestarClick);
			// 
			// btnMultiplica
			// 
			this.btnMultiplica.Location = new System.Drawing.Point(158, 74);
			this.btnMultiplica.Name = "btnMultiplica";
			this.btnMultiplica.Size = new System.Drawing.Size(103, 23);
			this.btnMultiplica.TabIndex = 6;
			this.btnMultiplica.Text = "MULTIPLICACION";
			this.btnMultiplica.UseVisualStyleBackColor = true;
			this.btnMultiplica.Click += new System.EventHandler(this.BtnMultiplicaClick);
			// 
			// bntDividir
			// 
			this.bntDividir.Location = new System.Drawing.Point(79, 104);
			this.bntDividir.Name = "bntDividir";
			this.bntDividir.Size = new System.Drawing.Size(75, 23);
			this.bntDividir.TabIndex = 7;
			this.bntDividir.Text = "DIVICION";
			this.bntDividir.UseVisualStyleBackColor = true;
			this.bntDividir.Click += new System.EventHandler(this.Button4Click);
			// 
			// btnModulo
			// 
			this.btnModulo.Location = new System.Drawing.Point(161, 104);
			this.btnModulo.Name = "btnModulo";
			this.btnModulo.Size = new System.Drawing.Size(100, 23);
			this.btnModulo.TabIndex = 8;
			this.btnModulo.Text = "MODULO%";
			this.btnModulo.UseVisualStyleBackColor = true;
			this.btnModulo.Click += new System.EventHandler(this.BtnModuloClick);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(269, 261);
			this.Controls.Add(this.btnModulo);
			this.Controls.Add(this.bntDividir);
			this.Controls.Add(this.btnMultiplica);
			this.Controls.Add(this.btnRestar);
			this.Controls.Add(this.btnSumar);
			this.Controls.Add(this.txtN2);
			this.Controls.Add(this.txtN1);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "MainForm";
			this.Text = "Operaciones basicas";
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Button btnModulo;
		private System.Windows.Forms.Button bntDividir;
		private System.Windows.Forms.Button btnMultiplica;
		private System.Windows.Forms.Button btnRestar;
		private System.Windows.Forms.Button btnSumar;
		private System.Windows.Forms.TextBox txtN2;
		private System.Windows.Forms.TextBox txtN1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
	}
}
