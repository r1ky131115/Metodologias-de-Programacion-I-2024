using Metodologias_de_Programacion_I_2024.Interfaces.Strategy;

namespace Metodologias_de_Programacion_I_2024.Interfaces.Adapter
{
    public interface IAlumno : Comparable
    {
        void SetStrategy(IStrategyAlumno strategy);

        int GetCalificacion();

        int GetLegajo();

        string GetNombre();

        int GetDni();

        double GetPromerdio();

        void SetCalificacion(int calificacion);

        int ResponderPregunta(int pregunta);

        string MostrarCalificacion();

        void PrestarAtencion();

        void Distraerse();
    }
}
