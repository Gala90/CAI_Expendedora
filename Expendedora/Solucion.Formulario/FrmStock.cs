﻿using Solucion.LibreriaNegocio;
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
    public partial class FrmStock : Form
    {
        private Expendedora exp;

        public FrmStock(Expendedora e)
        {
            exp = e;
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            listView1.Clear();
            if (exp.Encendida)
            {
                if (!exp.estaVacia())
                {
                    foreach (Lata l in exp.Latas)
                    {

                        listView1.Items.Add(l.Descripcion());
                    }
                } else
                {
                    MessageBox.Show("La maquina esta vacia");
                }

            }
            else
            {
                MessageBox.Show("Encienda la maquina.");
            }


        }

        private void Button2_Click(object sender, EventArgs e)
        {
            this.Owner.Show();
            this.Dispose();
        }

        private void ListView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
