using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Solucion.LibreriaNegocio.Entidades.Exceptions;

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
            if (Latas.Count() < _capacidad)
            {
                this.Latas.Add(l);
            } else
            {
                throw new CapacidadInsuficienteException();
            }
        }

        
/*
        public Lata extraerLata(string cod, double dinero)
        {
            foreach (Lata l in Latas)
            {
                if (l.Codigo == cod)
                {
                    if (l.Precio == dinero)
                    {
                        Dinero = Dinero + dinero;
                        Latas.Remove(l);
                        return l;
                    }

                    if (l.Precio > dinero)
                    {
                        throw new DineroInsuficienteException();
                    }
                    else
                    {
                        throw new ImporteMayorExcepcion();
                    }

                }
                else
                {
                    throw new SinStockException();
                }
                
            }
        }

*/
        public string getBalance()
        {
            string balance = "Cantidad de latas: " + Latas.Count() + " Cantidad de dinero: " + Dinero;       
            return balance;

        }


        public int getCapacidadRestante()
        {
            int capRestante = _capacidad - Latas.Count();       
            return capRestante;

        }

        public void encenderMaquina ()
        {
            _encendida = true; 
        }


        public bool estaVacia()
        {
            return Latas.Count() == 0;
        }


    }
}
