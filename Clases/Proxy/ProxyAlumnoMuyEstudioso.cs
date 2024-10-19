
namespace Metodologias_de_Programacion_I_2024.Clases.Proxy
{
    public class ProxyAlumnoMuyEstudioso : Alumno
    {
        AlumnoMuyEstudioso alumnoMuyEstudioso;

        public ProxyAlumnoMuyEstudioso(string n, int d, int l, double p) : base(n, d, l, p) {}

        public override int ResponderPregunta(int pregunta)
        {
            if (alumnoMuyEstudioso == null) 
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Creando a traves del ProxyAlumnoMuyEstudioso el AlumnoMuyEstudioso...");
                Console.ResetColor();

                alumnoMuyEstudioso = new AlumnoMuyEstudioso(this.GetNombre(), this.GetDni(), this.GetLegajo(), this.GetPromerdio());
            }
            
            return alumnoMuyEstudioso.ResponderPregunta(pregunta);
        }
    }
}
