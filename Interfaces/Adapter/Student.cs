namespace Metodologias_de_Programacion_I_2024.Interfaces.Adapter
{
    public interface Student
    {
        string getName();
        int yourAnswerIs(int question);
        void setScore(int score);
        string showResult();
        bool equals(Student student);
        bool lessThan(Student student);
        bool greaterThan(Student student);
    }
}
