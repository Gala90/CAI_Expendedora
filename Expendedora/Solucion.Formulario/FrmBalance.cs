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
    public partial class FrmBalance : Form
    {
        private Expendedora exp;

        public FrmBalance(Expendedora e)
        {
            exp = e;
            InitializeComponent();
        }


    }
}
