using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyecto
{
    class Nodo
    {
        public string Provincia;
        public int Poblacion;
        public Nodo Izquierda, Derecha;

        public Nodo(string provincia, int poblacion)
        {
            Provincia = provincia;
            Poblacion = poblacion;
            Izquierda = Derecha = null;
        }
        public Nodo ObtenerNodoMinimo()
        {
            Nodo nodoActual = this;
            while (nodoActual.Izquierda != null)
            {
                nodoActual = nodoActual.Izquierda;
            }
            return nodoActual;
        }
    }
}
