namespace Metodologias_de_Programacion_I_2024.Interfaces.Adapter
{
    public interface IteratorOfStudent
    {
        void beginning();
        bool end();
        Student current();
        void next();
    }
}
