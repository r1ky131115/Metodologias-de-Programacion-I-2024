using Metodologias_de_Programacion_I_2024.Colecciones;
using Metodologias_de_Programacion_I_2024.Interfaces;
using Metodologias_de_Programacion_I_2024.Interfaces.Iterator;

namespace Metodologias_de_Programacion_I_2024.Clases.Iteradores
{
    public class IteradorDeDiccionario : Iterador
    {
        int elementoActual;

        Diccionario dIterable;

        public IteradorDeDiccionario(Coleccionable d)
        {
            dIterable = (Diccionario)d;
            primero();
        }

        public void primero()
        {
            elementoActual = 0;
        }

        public void siguiente()
        {
            elementoActual++;
        }

        public bool fin()
        {
            return elementoActual >= dIterable.elementos.Count;
        }

        public object actual()
        {
            return dIterable.elementos[elementoActual].Clave.ToString();
        }
    }
}
