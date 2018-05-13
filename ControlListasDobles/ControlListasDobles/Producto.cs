using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlListasDobles
{
    class Producto
    {
        /* Propiedas para la lista Doblemente Enlazada */
        // Referencia al elemento anterior de la lista.
        public Producto Anterior;

        // Referencia al elemento siguiente de la lista.
        public Producto Siguiente;
        /* ------------------------------------------- */

        public int Codigo { get; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }

        private int _cantidad;
        public int Cantidad
        {
            get { return _cantidad; }
            set { if (value >= 0) _cantidad = value; }
        }

        private int _costo;
        public int Costo
        {
            get { return _costo; }
            set { if (value >= 0) _costo = value; }
        }

        public Producto(int codigo, string nombre, string descripcion, int cantidad, int costo)
        {
            Codigo = codigo;
            Nombre = nombre;
            Descripcion = descripcion;
            _cantidad = cantidad;
            _costo = costo;
        }

        public override string ToString()
        {
            return "Codigo: " + Codigo + System.Environment.NewLine +
                   "Nombre: " + Nombre + System.Environment.NewLine +
                   "Descripcion: " + Descripcion + System.Environment.NewLine +
                   "Cantidad: " + Cantidad + System.Environment.NewLine +
                   "Costo: $" + Costo + System.Environment.NewLine;
        }
    }
}
