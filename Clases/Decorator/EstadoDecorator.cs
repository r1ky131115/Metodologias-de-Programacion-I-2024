using Metodologias_de_Programacion_I_2024.Interfaces.Adapter;

namespace Metodologias_de_Programacion_I_2024.Clases.Decorator
{
    public class EstadoDecorator : Decorador
    {
        public EstadoDecorator(IAlumno alumno) : base(alumno) {}

        public override string MostrarCalificacion()
        {
            int nota = this.GetCalificacion();
            string estado = nota >= 7 ? "PROMOCIÓN" : (nota >= 4 ? "APROBADO" : "DESAPROBADO");

            return $"{this.GetNombre()} {nota} ({estado})";
        }
    }
}
