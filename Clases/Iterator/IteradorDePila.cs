﻿using Metodologias_de_Programacion_I_2024.Colecciones;
using Metodologias_de_Programacion_I_2024.Interfaces;
using Metodologias_de_Programacion_I_2024.Interfaces.Iterator;

namespace Metodologias_de_Programacion_I_2024.Clases.Iteradores
{
    public class IteradorDePila : Iterador
    {
        Pila pIterable;
        int elementoActual;

        public IteradorDePila(Coleccionable p)
        {
            pIterable = (Pila)p;
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
            return elementoActual >= pIterable.pila.Count;
        }

        public object actual()
        {
            return pIterable.pila[elementoActual];
        }
    }
}
