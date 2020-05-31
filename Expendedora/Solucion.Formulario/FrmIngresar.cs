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

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private string Marca()
        {
            string codigo = comboBox1.Text;
            string marca = null;
            switch (codigo)
            {
                case "CO1":                    
                    marca = "Coca Cola";
                    break;
                case "CO2":
                    marca = "Coca Cola";
                    break;
                case "SP1":
                    marca = "Sprite";
                    break;
                case "SP2":
                    marca = "Sprite";
                    break;
                case "FA1":
                    marca = "Fanta";
                    break;
                case "FA2":
                    marca = "Fanta";
                    break;
            }
            return marca;
        }

        private string Sabor()
        {
            string codigo = comboBox1.Text;
            string sabor = null;
            switch (codigo)
            {
                case "CO1":
                    sabor = "Regular";
                    break;
                case "CO2":
                    sabor = "Zero";
                    break;
                case "SP1":
                    sabor = "Regular";
                    break;
                case "SP2":
                    sabor = "Zero";
                    break;
                case "FA1":
                    sabor = "Regular";
                    break;
                case "FA2":
                    sabor = "Zero";
                    break;
            }
            return sabor;
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            this.Owner.Show();
            this.Dispose();
        }

        private void Button1_Click(object sender, EventArgs e)
        { 
            try
            {
                if (exp.Encendida)
                {

                    Lata l = new Lata(comboBox1.Text, Marca(), Sabor(),
                                            Convert.ToDouble(textBox1.Text),
                                            Convert.ToDouble(textBox2.Text));


                    exp.agregarLata(l);
                    MessageBox.Show("La lata de " + Marca() + " " + Sabor() + " ha sido agregada.");
                    comboBox1.SelectedIndex = -1;
                    textBox1.Clear();
                    textBox2.Clear();
                }
                else
                {
                    MessageBox.Show("Encienda la maquina");
                    comboBox1.SelectedIndex = -1;
                    textBox1.Clear();
                    textBox2.Clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                comboBox1.SelectedIndex = -1;
                textBox1.Clear();
                textBox2.Clear();
            }
            
        }
    }
}
