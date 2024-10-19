namespace Metodologias_de_Programacion_I_2024.Interfaces.Adapter
{
    public interface Collection
    {
        IteratorOfStudent getIterator();
        void addStudent(Student student);
        void sort();
    }
}
