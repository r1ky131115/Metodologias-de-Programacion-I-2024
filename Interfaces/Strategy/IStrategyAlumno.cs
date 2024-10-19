namespace Metodologias_de_Programacion_I_2024.Interfaces.Strategy
{
    public interface IStrategyAlumno
    {
        bool SosMayor(Comparable a, Comparable b);
        bool SosMenor(Comparable a, Comparable b);
        bool SosIgual(Comparable a, Comparable b);
    }
}
