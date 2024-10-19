using Metodologias_de_Programacion_I_2024.Colecciones;
using Metodologias_de_Programacion_I_2024.Interfaces;
using Metodologias_de_Programacion_I_2024.Interfaces.Iterator;

namespace Metodologias_de_Programacion_I_2024.Clases.Iteradores
{
    public class IteradorDeCola : Iterador
    {
        int elementoActual;
        Cola cIteable;

        public IteradorDeCola(Coleccionable c)
        {
            cIteable = (Cola)c;
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
            return elementoActual >= cIteable.cola.Count;
        }

        public object actual()
        {
            return cIteable.cola[elementoActual];
        }
    }
}
