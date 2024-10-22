using Metodologias_de_Programacion_I_2024.Interfaces.Iterator;

namespace Metodologias_de_Programacion_I_2024.Interfaces
{
    public interface Coleccionable : Iterable
    {
        int Cuantos();
        Comparable Minimo();
        Comparable Maximo();
        void Agregar(Comparable comparable);
        bool Contiene(Comparable comparable);
    }
}
