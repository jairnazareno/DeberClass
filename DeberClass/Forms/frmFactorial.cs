using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DeberClass.Forms
{
    public partial class frmFactorial : Form
    {
        public frmFactorial()
        {
            InitializeComponent();
        }

       
        private void btnCalcular_Click_1(object sender, EventArgs e)
        {
            int calcular = int.Parse(txtNumero.Text);
            string cad = TIC.Utilidades.factoriales(calcular);
            this.txtRespuesta.Text = cad;
        }
    }
}
