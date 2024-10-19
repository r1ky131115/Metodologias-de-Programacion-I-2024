namespace Metodologias_de_Programacion_I_2024.Clases
{
    public class AlumnoMuyEstudioso : Alumno
    {
        public AlumnoMuyEstudioso(string nombre, int dni, int legajo, double promedio)
            : base(nombre, dni, legajo, promedio)
        {
        }

        public override int ResponderPregunta(int pregunta)
        {
            return pregunta % 3;
        }
    }
}
