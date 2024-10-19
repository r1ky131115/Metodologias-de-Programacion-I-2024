using Metodologias_de_Programacion_I_2024.Clases.Iteradores;
using Metodologias_de_Programacion_I_2024.Interfaces;
using Metodologias_de_Programacion_I_2024.Interfaces.Iterator;

namespace Metodologias_de_Programacion_I_2024.Colecciones
{
    public class Cola : Coleccionable, Iterable
    {
        public List<Comparable> cola = new List<Comparable>();

        public void Agregar(Comparable comparable)
        {
            cola.Add(comparable);
        }

        public bool Contiene(Comparable comparable)
        {
            if (cola.Count == 0) throw new InvalidOperationException("La cola está vacía.");
            foreach (var i in cola)
            {
                if (i.SosIgual(comparable))
                {
                    return true;
                }
            }
            return false;
        }

        public Iterador CrearIterador()
        {
            return new IteradorDeCola(this);
        }

        public int Cuantos()
        {
            return cola.Count;
        }

        public Comparable Maximo()
        {
            if (cola.Count == 0) throw new InvalidOperationException("La cola está vacía.");
            Comparable max = cola[0];
            foreach (var i in cola)
            {
                if (max == null)
                {
                    max = i;
                }
                else
                {
                    if (max.SosMayor(i))
                    {
                        max = i;
                    }
                }
            }
            return max;
        }

        public Comparable Minimo()
        {
            if (cola.Count == 0) throw new InvalidOperationException("La cola está vacía.");
            Comparable min = cola[0];
            foreach (var i in cola)
            {
                if (min == null)
                {
                    min = i;
                }
                else
                {
                    if (min.SosMenor(i))
                    {
                        min = i;
                    }
                }
            }
            return min;
        }
    }
}
