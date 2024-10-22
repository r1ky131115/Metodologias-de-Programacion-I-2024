using Metodologias_de_Programacion_I_2024.Interfaces;
using Metodologias_de_Programacion_I_2024.Interfaces.Iterator;

namespace Metodologias_de_Programacion_I_2024.Colecciones
{
    public class ColeccionMultiple : Coleccionable
    {
        public Pila Pila { get; set; }
        public Cola Cola { get; set; }

        public ColeccionMultiple(Pila p, Cola c)
        {
            this.Pila = p;
            this.Cola = c;
        }

        public int Cuantos()
        {
            return Pila.Cuantos() + Cola.Cuantos();
        }

        public Comparable Minimo()
        {
            Comparable minPila = Pila.Minimo();
            Comparable minCola = Cola.Minimo();

            Comparable minGeneral = null;

            if (minPila != null && minCola != null)
            {
                if (minPila.SosMenor(minCola))
                {
                    minGeneral = minPila;
                }
                else
                {
                    minGeneral = minCola;
                }
            }

            return minGeneral;
        }

        public Comparable Maximo()
        {
            Comparable minPila = Pila.Minimo();
            Comparable minCola = Cola.Minimo();

            Comparable maxGeneral = null;

            if (minPila != null && minCola != null)
            {
                if (minPila.SosMenor(minCola))
                {
                    maxGeneral = minPila;
                }
                else
                {
                    maxGeneral = minCola;
                }
            }

            return maxGeneral;
        }

        public void Agregar(Comparable comparable)
        {
            Pila.Agregar(comparable);
            Cola.Agregar(comparable);
        }

        public bool Contiene(Comparable comparable)
        {
            return Pila.Contiene(comparable) || Cola.Contiene(comparable);
        }

        public Iterador CrearIterador()
        {
            throw new NotImplementedException();
        }
    }
}
