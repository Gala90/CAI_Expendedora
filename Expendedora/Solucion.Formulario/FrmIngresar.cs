using Solucion.LibreriaNegocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Solucion.Formulario
{
    public partial class FrmIngresar : Form
    {
        private Expendedora exp;

        public FrmIngresar(Expendedora e)
        {
            exp = e;

            InitializeComponent();
        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
