using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Solucion.LibreriaNegocio.Entidades.Exceptions;

namespace Solucion.LibreriaNegocio
{
    public class Lata
    {
        private string _codigo;
        private string _nombre;
        private string _sabor;
        private double _precio;
        private double _volumen;

        public string Codigo { get => _codigo; set => _codigo = value; }
        public string Nombre { get => _nombre; set => _nombre = value; }
        public string Sabor { get => _sabor; set => _sabor = value; }
        public double Precio { get => _precio; set => _precio = value; }
        public double Volumen { get => _volumen; set => _volumen = value; }


        public Lata(string cod, string nom, string sabor, double precio, double vol)
        {
            this._codigo = cod;
            this._nombre = nom;
            this._sabor = sabor;
            this._precio = precio;
            this._volumen = vol;

        }

        public double GetPrecioPorLitro()
        {
            return (1000 * Precio) / Volumen;
        }

        public override string ToString()
        {
            return Nombre;
        }

        public string Descripcion()
        {
            return Codigo + " - " + Nombre + " - " + Sabor + " $ " + Precio + " / " + " $/L " + GetPrecioPorLitro();
        }


    }

}