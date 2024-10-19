
using Metodologias_de_Programacion_I_2024.Interfaces.Adapter;

namespace Metodologias_de_Programacion_I_2024.Clases.Decorator
{
    public class RecuadroDecorator : Decorador
    {
        public RecuadroDecorator(IAlumno alumno) : base(alumno) { }

        public override string MostrarCalificacion()
        {
            string resultado = $"{this.GetNombre()} - {this.GetCalificacion()}";
            string recuadro = new string('*', resultado.Length + 4);
            return $"{recuadro}\n* {resultado} *\n{recuadro}";
        }
    }

}
