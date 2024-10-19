using Metodologias_de_Programacion_I_2024.Clases.Iteradores;
using Metodologias_de_Programacion_I_2024.Interfaces;
using Metodologias_de_Programacion_I_2024.Interfaces.Iterator;

namespace Metodologias_de_Programacion_I_2024.Colecciones
{
    public class Diccionario : Coleccionable, Iterable
    {
        public List<ClaveValor> elementos;

        public Diccionario()
        {
            elementos = new List<ClaveValor>();
        }

        public void agregar(Comparable clave, object valor)
        {
            ClaveValor existente = elementos.Find(cv => cv.Clave.SosIgual(clave));

            if (existente != null)
            {
                existente.Valor = valor;
            }
            else
            {
                elementos.Add(new ClaveValor(clave, valor));
            }
        }

        public object valorDe(Comparable clave)
        {
            ClaveValor existente = elementos.Find(cv => cv.Clave.SosIgual(clave));
            return existente != null ? existente.Valor : null;
        }

        public void Agregar(Comparable comparable)
        {
            agregar(comparable, -1);
        }

        public bool Contiene(Comparable comparable)
        {
            if (elementos.Count == 0) throw new InvalidOperationException("El diccioario está vacío.");

            for (int i = 0; i <= elementos.Count; i++)
            {
                if (comparable.SosIgual(elementos[i].Clave))
                {
                    return true;
                }
            }

            return false;
        }

        public int Cuantos()
        {
            return elementos.Count;
        }

        public Comparable Maximo()
        {
            if (elementos.Count == 0) throw new InvalidOperationException("El diccioario está vacío.");
            Comparable maximo = (Comparable)elementos[0].Valor;

            foreach (Comparable comparable in elementos)
            {
                if (!comparable.SosMayor(maximo))
                {
                    maximo = comparable;
                }
            }
            return maximo;
        }

        public Comparable Minimo()
        {
            if (elementos.Count == 0) throw new InvalidOperationException("El diccioario está vacío.");
            Comparable minimo = (Comparable)elementos[0].Valor;

            foreach (Comparable comparable in elementos)
            {
                if (!comparable.SosMenor(minimo))
                {
                    minimo = comparable;
                }
            }
            return minimo;
        }

        public override string ToString()
        {
            return string.Join(", ", elementos.Select(e => $"{e.Clave}: {e.Valor}"));
        }

        public Iterador CrearIterador()
        {
            return new IteradorDeDiccionario(this);
        }
    }


    public class ClaveValor
    {
        public Comparable Clave { get; }
        public object Valor { get; set; }

        public ClaveValor(Comparable clave, object valor)
        {
            this.Clave = clave;
            this.Valor = valor;
        }
    }
}
