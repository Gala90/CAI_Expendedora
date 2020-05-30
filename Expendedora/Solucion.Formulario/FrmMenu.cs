using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Solucion.LibreriaNegocio;

namespace Solucion.Formulario
{
    public partial class FrmMenu : Form
    {
        private Expendedora exp;

        public FrmMenu()
        {
            exp = new Expendedora("Exp3000", 6, 0, false);
            InitializeComponent();
            
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            exp.Encendida = true;
            MessageBox.Show("Se ha encendido la maquina");
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("CO1 - Coca Cola Regular \nCO2 - Coca Cola Zero     \nSP1 - Sprite Regular" +
                               "\nSP2 - Sprite Zero  \nFA1 - Fanta Regular    \nFA2 - Fanta Zero");
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            FrmIngresar f = new FrmIngresar(this.exp);
            f.Owner = this;
            f.Show();
            this.Hide();
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            FrmExtraer f = new FrmExtraer(this.exp);
            f.Owner = this;
            f.Show();
            this.Hide();
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            FrmBalance f = new FrmBalance(this.exp);
            f.Owner = this;
            f.Show();
            this.Hide();

        }

        private void Button6_Click(object sender, EventArgs e)
        {
            FrmStock f = new FrmStock(this.exp);
            f.Owner = this;
            f.Show();
            this.Hide();
        }

        private void Button7_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
