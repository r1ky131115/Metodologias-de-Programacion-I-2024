using Metodologias_de_Programacion_I_2024.Clases.Adapter;
using Metodologias_de_Programacion_I_2024.Interfaces.Adapter;

namespace Metodologias_de_Programacion_I_2024.Clases
{
    public class Aula
    {
        Teacher teacher = null;
        public void Comenzar()
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("\n\nComenzando la clase...");
            Console.ResetColor();

            if (teacher == null)
            {
                teacher = new Teacher();
            }
        }

        public void nuevoAlumno(Alumno alumno)
        {
            if (teacher != null)
            {
                Student student = new AlumnoToStudent(alumno);
                teacher.goToClass(student);
            }
        }

        public void ClaseLista()
        {
            if (teacher != null)
            {
                teacher.teachingAClass();
            }
            else
            {
                Console.WriteLine("No hay maestro asignado. Comience la clase primero.");
            }
        }
    }
}
