using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinTestOperaciones
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnEjecutar_Click(object sender, EventArgs e)
        {
            Funciones.Operaciones op = new Funciones.Operaciones();
            this.txtNombre.Text = op.Saludo("Eduardo");

            double[] x = new double[] { 10, 11, 22, 33 };
            this.txtSuma.Text = op.Suma(x).ToString();
        }
    }
}
