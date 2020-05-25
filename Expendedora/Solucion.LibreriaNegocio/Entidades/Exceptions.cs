using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solucion.LibreriaNegocio.Entidades
{
    public class Exceptions
    {
        public class CapacidadInsuficienteException : Exception
        {
            public CapacidadInsuficienteException() : base("No se pueden agregar mas latas")
            {

            }
        }
        public class DineroInsuficienteException : Exception
        {
            public DineroInsuficienteException() : base("Dinero insuficiente.")
            {

            }
        }
        public class SinStockException : Exception
        {
            public SinStockException() : base("Stock insuficiente.")
            {

            }
        }
        public class CodigoInvalidoException : Exception
        {
            public CodigoInvalidoException() : base("Codigo invalido.")
            {

            }
        }
        public class ImporteMayorExcepcion : Exception
        {
            public ImporteMayorExcepcion() : base("Ingrese importe exacto.")
            {

            }
        }            
    }
}
