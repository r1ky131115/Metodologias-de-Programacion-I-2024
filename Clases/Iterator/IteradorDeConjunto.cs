using Metodologias_de_Programacion_I_2024.Colecciones;
using Metodologias_de_Programacion_I_2024.Interfaces;
using Metodologias_de_Programacion_I_2024.Interfaces.Iterator;

namespace Metodologias_de_Programacion_I_2024.Iteradores
{
    public class IteradorDeConjunto : Iterador
    {
        int elementoActual;

        Conjunto cjIterable;

        public IteradorDeConjunto(Coleccionable p)
        {
            cjIterable = (Conjunto)p;
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
            return elementoActual >= cjIterable.Cuantos();
        }

        public object actual()
        {
            var array = cjIterable.coleccion.ToArray();
            return array[elementoActual];
        }
    }
}
