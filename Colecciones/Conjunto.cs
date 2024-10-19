using Metodologias_de_Programacion_I_2024.Clases.Command;
using Metodologias_de_Programacion_I_2024.Interfaces;
using Metodologias_de_Programacion_I_2024.Interfaces.Command;
using Metodologias_de_Programacion_I_2024.Interfaces.Iterator;
using Metodologias_de_Programacion_I_2024.Iteradores;

namespace Metodologias_de_Programacion_I_2024.Colecciones
{
    public class Conjunto : Coleccionable, Iterable, IOrdenable
    {
        IOrdenEnAula1 ordenInicio;
        IOrdenEnAula1 ordenAulaLlena;
        IOrdenEnAula2 ordenReceptor;

        public HashSet<Comparable> coleccion = new HashSet<Comparable>();

        int paginaActual;

        public void agregar(Comparable elemento)
        {
            if (coleccion.Count == 0)
            {
                setOrdenInicio(ordenInicio);
            }

            setOrdenLlegaAlumno(ordenReceptor, elemento);
            coleccion.Add(elemento);

            if (coleccion.Count == 40)
            {
                setOrdenAulaLlena(ordenAulaLlena);
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

        public void setOrdenInicio(IOrdenEnAula1 ordenEnAula1)
        {
            ordenInicio = ordenEnAula1;
            ordenInicio?.Ejecutar();
        }

        public void setOrdenLlegaAlumno(IOrdenEnAula2 ordenEnAula2, Comparable comparable)
        {
            ordenReceptor = ordenEnAula2;
            ordenReceptor?.Ejecutar(comparable);
        }

        public void setOrdenAulaLlena(IOrdenEnAula1 ordenEnAula1)
        {
            ordenAulaLlena = ordenEnAula1;
            ordenAulaLlena?.Ejecutar();
        }
    }
}
