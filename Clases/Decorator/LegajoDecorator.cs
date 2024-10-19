
using Metodologias_de_Programacion_I_2024.Interfaces.Adapter;

namespace Metodologias_de_Programacion_I_2024.Clases.Decorator
{
    public class LegajoDecorator : Decorador
    {
        public LegajoDecorator(IAlumno alumno) : base (alumno) {}

        public override string MostrarCalificacion()
        {
            return $"{this.GetNombre()} ({this.GetLegajo()}/{this.GetCalificacion()})    {this.GetCalificacion()}";
        }
    }

}
