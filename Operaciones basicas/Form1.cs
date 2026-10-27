/*
 * Creado por SharpDevelop.
 * Usuario: CC2_PC24
 * Fecha: 27/10/2026
 * Hora: 07:54 a. m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Operaciones_basicas
{
	/// <summary>
	/// Description of Form1.
	/// </summary>
	public partial class Form1 : Form
	{
		public Form1()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void BtnCalcularClick(object sender, EventArgs e)
		{
			double a = Convert.ToDouble(txtA.Text);
            double b = Convert.ToDouble(txtB.Text);
            double c = Convert.ToDouble(txtC.Text);
            double discriminante = Math.Pow(b, 2) - (4 * a * c);
            if (discriminante >= 0)
            {
                double x1 = (-b + Math.Sqrt(discriminante)) / (2 * a);
                double x2 = (-b - Math.Sqrt(discriminante)) / (2 * a);
                MessageBox.Show("X1 = " + x1.ToString() + "  |  X2 = " + x2.ToString());
            }
            else
            {
                MessageBox.Show("No hay solucion");
                txtA.Text = "";
                txtB.Text = "";
                txtC.Text = "";
            }
		}
		
		void Button1Click(object sender, EventArgs e)
		{
			MainForm y = new MainForm();
			y.Show();
			this.Hide();
		}
	}
}
