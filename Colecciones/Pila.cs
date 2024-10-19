using Metodologias_de_Programacion_I_2024.Clases.Iteradores;
using Metodologias_de_Programacion_I_2024.Interfaces;
using Metodologias_de_Programacion_I_2024.Interfaces.Iterator;

namespace Metodologias_de_Programacion_I_2024.Colecciones
{
    public class Pila : Coleccionable, Iterable
    {
        public List<Comparable> pila = new List<Comparable>();

        public void Agregar(Comparable comparable)
        {
            pila.Add(comparable);
        }

        public bool Contiene(Comparable comparable)
        {
            foreach (var i in pila)
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
            return new IteradorDePila(this);
        }

        public int Cuantos()
        {
            return pila.Count;
        }

        public Comparable Maximo()
        {
            if (pila.Count == 0) throw new InvalidOperationException("La pila está vacía.");
            Comparable max = pila[0];
            foreach (var i in pila)
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
            if (pila.Count == 0) throw new InvalidOperationException("La pila está vacía.");
            Comparable min = pila[0];
            foreach (var i in pila)
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
