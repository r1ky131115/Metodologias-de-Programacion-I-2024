
using Metodologias_de_Programacion_I_2024.Interfaces.Adapter;

namespace Metodologias_de_Programacion_I_2024.Clases.Decorator
{
    public class NotaEnLetrasDecorator : Decorador
    {
        public NotaEnLetrasDecorator(IAlumno alumno) : base(alumno) { }

        public override string MostrarCalificacion()
        {
            string[] numerosEnLetras = { "CERO", "UNO", "DOS", "TRES", "CUATRO", "CINCO", "SEIS", "SIETE", "OCHO", "NUEVE", "DIEZ" };
            int nota = this.GetCalificacion();

            return $"{this.GetNombre()}   {nota}({numerosEnLetras[nota]})";
        }
    }

}
