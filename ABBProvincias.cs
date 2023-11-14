using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyecto
{
    class ABBProvincias
    {
        public Nodo Raiz;

        public ABBProvincias()
        {
            Raiz = null;
        }

        public void Insertar(string provincia, int poblacion)
        {
            Raiz = InsertarRec(Raiz, provincia, poblacion);
        }

        private Nodo InsertarRec(Nodo nodo, string provincia, int poblacion)
        {
            if (nodo == null)
            {
                return new Nodo(provincia, poblacion);
            }

            if (poblacion < nodo.Poblacion)
            {
                nodo.Izquierda = InsertarRec(nodo.Izquierda, provincia, poblacion);
            }
            else
            {
                nodo.Derecha = InsertarRec(nodo.Derecha, provincia, poblacion);
            }

            return nodo;
        }
        private Nodo BuscarProvinciaRec(Nodo nodo, string nombre)
        {
            if (nodo == null)
            {
                // Si el nodo es nulo, la provincia no se encontró en el árbol
                return null;
            }

            if (string.Equals(nodo.Provincia, nombre, StringComparison.OrdinalIgnoreCase))
            {
                // Si encontramos la provincia, devolvemos el nodo actual
                return nodo;
            }

            Nodo izquierda = BuscarProvinciaRec(nodo.Izquierda, nombre);
            Nodo derecha = BuscarProvinciaRec(nodo.Derecha, nombre);

            // Devolvemos el nodo encontrado en el subárbol izquierdo o derecho (si es no nulo)
            return izquierda ?? derecha;
        }

        public Nodo BuscarProvincia(string nombre)
        {
            return BuscarProvinciaRec(Raiz, nombre);
        }


        public void ImprimirOrden(Nodo nodo)
        {
            ImprimirOrdenRec(nodo);
        }

        private void ImprimirOrdenRec(Nodo nodo)
        {
            if (nodo != null)
            {
                ImprimirOrdenRec(nodo.Izquierda);
                Console.WriteLine($"{nodo.Provincia}: {nodo.Poblacion} Habitantes");
                ImprimirOrdenRec(nodo.Derecha);
            }
        }
        public void ActualizarPoblacion(string nombre, int nuevaPoblacion)
        {
            Raiz = ActualizarPoblacionRec(Raiz, nombre, nuevaPoblacion);
        }

        private Nodo ActualizarPoblacionRec(Nodo nodo, string nombre, int nuevaPoblacion)
        {
            if (nodo == null)
            {
                // Si el nodo es nulo, la provincia no se encontró en el árbol
                return null;
            }

            int comparacion = string.Compare(nombre, nodo.Provincia, StringComparison.OrdinalIgnoreCase);

            if (comparacion == 0)
            {
                // Actualizar la población de la provincia encontrada
                nodo.Poblacion = nuevaPoblacion;
            }
            else if (comparacion < 0)
            {
                // Buscar en el subárbol izquierdo
                nodo.Izquierda = ActualizarPoblacionRec(nodo.Izquierda, nombre, nuevaPoblacion);
            }
            else
            {
                // Buscar en el subárbol derecho
                nodo.Derecha = ActualizarPoblacionRec(nodo.Derecha, nombre, nuevaPoblacion);
            }

            return nodo;
        }
        public void EliminarProvincia(string nombre)
        {
            Raiz = EliminarProvinciaRec(Raiz, nombre);
        }

        // Otros métodos de la clase

        // Método privado de eliminación recursiva
        private Nodo EliminarProvinciaRec(Nodo nodo, string nombre)
        {
            if (nodo == null)
            {
                // Si el nodo es nulo, la provincia no se encontró en el árbol
                return null;
            }

            int comparacion = string.Compare(nombre, nodo.Provincia, StringComparison.OrdinalIgnoreCase);

            if (comparacion < 0)
            {
                // Buscar en el subárbol izquierdo
                nodo.Izquierda = EliminarProvinciaRec(nodo.Izquierda, nombre);
            }
            else if (comparacion > 0)
            {
                // Buscar en el subárbol derecho
                nodo.Derecha = EliminarProvinciaRec(nodo.Derecha, nombre);
            }
            else
            {
                // Nodo con la provincia encontrada

                // Caso 1: Nodo sin hijo o con un solo hijo
                if (nodo.Izquierda == null)
                {
                    return nodo.Derecha;
                }
                else if (nodo.Derecha == null)
                {
                    return nodo.Izquierda;
                }

                // Caso 2: Nodo con dos hijos, encontrar el sucesor inorden (el nodo más pequeño en el subárbol derecho)
                nodo.Provincia = ObtenerProvinciaMinima(nodo.Derecha);

                // Eliminar el sucesor inorden
                nodo.Derecha = EliminarProvinciaRec(nodo.Derecha, nodo.Provincia);
            }

            return nodo;
        }

        private string ObtenerProvinciaMinima(Nodo nodo)
        {
            string provinciaMinima = nodo.Provincia;
            while (nodo.Izquierda != null)
            {
                provinciaMinima = nodo.Izquierda.Provincia;
                nodo = nodo.Izquierda;
            }
            return provinciaMinima;
        }

    }
}