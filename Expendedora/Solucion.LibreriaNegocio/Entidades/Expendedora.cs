using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solucion.LibreriaNegocio
{
    public class Expendedora
    {
        private List<Lata> _latas;
        private string _proveedor;
        private int _capacidad;
        private double _dinero;
        private bool _encendida;


        public List<Lata> Latas { get => _latas; set => _latas = value; }

        public string Proveedor { get => _proveedor; set => _proveedor = value; }

        public int Capacidad { get => _capacidad; set => _capacidad = value; }

        public double Dinero { get => _dinero; set => _dinero = value; }

        public bool Encendida { get => _encendida; set => _encendida = value; }


        public Expendedora(string prov, int capacidad, double dinero, bool encendida)
        {
            _latas = new List<Lata>();
            this._proveedor = prov;
            this._capacidad = capacidad;
            this._dinero = dinero;
            this._encendida = encendida;
        }

        public void agregarLata(Lata l)
        {
            //Validaciones para agregar Lata aca
            this.Latas.Add(l);
        }

        

        public Lata extraerLata(string cod, double dinero)
        {
            foreach (Lata l in Latas)
            {
                if ((l.Codigo == cod) && (l.Precio == dinero))
                   return l;
        
            }
        }

        /*
        public string getBalance()
        {

        }

        public int getCapacidadRestante()
        {

        }
        */
        public void encenderMaquina ()
        {
            _encendida = true; 
        }
        /*
        public bool estaVacia()
        {

        }

    */
    }
}
