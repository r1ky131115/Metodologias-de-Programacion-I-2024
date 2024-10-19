using Metodologias_de_Programacion_I_2024.Interfaces;
using Metodologias_de_Programacion_I_2024.Interfaces.Command;

namespace Metodologias_de_Programacion_I_2024.Clases.Command
{
    public class OrdenReceptor : IOrdenEnAula2
    {
        private Aula _aula;

        public OrdenReceptor(Aula aula)
        {
            _aula = aula;
        }

        public void Ejecutar(Comparable comparable)
        {
            _aula.nuevoAlumno((Alumno)comparable);
        }
    }
}
