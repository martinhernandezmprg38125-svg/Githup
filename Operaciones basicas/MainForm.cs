/*
 * Creado por SharpDevelop.
 * Usuario: CC2_PC24
 * Fecha: 27/10/2026
 * Hora: 07:28 a. m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Operaciones_basicas
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void Button4Click(object sender, EventArgs e)
		{
			double divicion;
			divicion=double.Parse(txtN1.Text)/double.Parse(txtN2.Text);
			MessageBox.Show("El resultado de la divicion es: " + divicion.ToString());
		}
		
		void BtnSumarClick(object sender, EventArgs e)
		{
			double suma;
			suma=double.Parse(txtN1.Text)+double.Parse(txtN2.Text);
			MessageBox.Show("El resultado de la suma es: " + suma.ToString());
		}
		
		void BtnRestarClick(object sender, EventArgs e)
		{
			double resta;
			resta=double.Parse(txtN1.Text)-double.Parse(txtN2.Text);
			MessageBox.Show("El resultado de la resta es: " + resta.ToString());
		}
		
		void BtnMultiplicaClick(object sender, EventArgs e)
		{
			double multiplica;
			multiplica=double.Parse(txtN1.Text)*double.Parse(txtN2.Text);
			MessageBox.Show("El resultado de la multiplicacion es: " + multiplica.ToString());
		}
		
		void BtnModuloClick(object sender, EventArgs e)
		{
			double modulo;
			modulo=double.Parse(txtN1.Text)%double.Parse(txtN2.Text);
			MessageBox.Show("El resultado de el modulo es: " + modulo.ToString()+ "%");
		}
	}
}
