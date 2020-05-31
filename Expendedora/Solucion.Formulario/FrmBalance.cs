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

        private void Button2_Click(object sender, EventArgs e)
        {
            this.Owner.Show();
            this.Dispose();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (exp.Encendida)
            { 

                this.textBox1.Text = Convert.ToString(exp.Dinero);
                this.textBox2.Text = Convert.ToString(exp.Latas.Count);
            }
            else
            {
                MessageBox.Show("Encienda la maquina.");
            }

        }
    }
}
