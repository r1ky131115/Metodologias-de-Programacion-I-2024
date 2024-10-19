using Metodologias_de_Programacion_I_2024.Interfaces;
using Metodologias_de_Programacion_I_2024.Interfaces.Iterator;
using Metodologias_de_Programacion_I_2024.Iteradores;

namespace Metodologias_de_Programacion_I_2024.Colecciones
{
    public class Conjunto : Coleccionable, Iterable
    {
        public HashSet<Comparable> coleccion = new HashSet<Comparable>();

        int paginaActual;

        public void agregar(Comparable elemento)
        {
            if (coleccion.Count() > 0)
            {
                if (!coleccion.Contains(elemento))
                {
                    coleccion.Add(elemento);
                }
            }
            else
            {
                coleccion.Add(elemento);
            }
        }
        public bool pertenece(Comparable comparable)
        {
            return coleccion.Contains(comparable);
        }


        public void Agregar(Comparable elemento)
        {
            agregar(elemento);
        }

        public bool Contiene(Comparable comparable)
        {
            return coleccion.Contains(comparable);
        }

        public int Cuantos()
        {
            return coleccion.Count();
        }

        public Comparable Maximo()
        {
            if (coleccion.Count == 0) throw new InvalidOperationException("El Conjunto está vacío.");
            return coleccion.Max();
        }

        public Comparable Minimo()
        {
            if (coleccion.Count == 0) throw new InvalidOperationException("El Conjunto está vacío.");
            return coleccion.Min();
        }

        public Iterador CrearIterador()
        {
            return new IteradorDeConjunto(this);
        }
    }
}
