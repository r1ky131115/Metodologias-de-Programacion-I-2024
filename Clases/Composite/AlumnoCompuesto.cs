using Metodologias_de_Programacion_I_2024.Interfaces;
using Metodologias_de_Programacion_I_2024.Interfaces.Adapter;
using Metodologias_de_Programacion_I_2024.Interfaces.Strategy;

namespace Metodologias_de_Programacion_I_2024.Clases.Composite
{
    public class AlumnoCompuesto : IAlumno
    {
        private List<IAlumno> alumnos = new List<IAlumno>();
        private string nombreAleatorio;
        private int dniAleatorio;
        private int legajoAleatorio;
        private double promedioAleatorio;

        public AlumnoCompuesto(){}

        public AlumnoCompuesto(string nombreAleatorio, int dniAleatorio, int legajoAleatorio, double promedioAleatorio)
        {
            this.nombreAleatorio = nombreAleatorio;
            this.dniAleatorio = dniAleatorio;
            this.legajoAleatorio = legajoAleatorio;
            this.promedioAleatorio = promedioAleatorio;
        }

        public void AgregarAlumno(IAlumno alumno)
        {
            alumnos.Add(alumno);
        }

        public void EliminarAlumno(IAlumno alumno)
        {
            alumnos.Remove(alumno);
        }

        public string GetNombre()
        {
            return string.Join(", ", alumnos.Select(a => a.GetNombre()));
        }

        public int ResponderPregunta(int pregunta)
        {
            var respuestas = new Dictionary<int, int>();
            foreach (var alumno in alumnos)
            {
                int respuesta = alumno.ResponderPregunta(pregunta);
                if (respuestas.ContainsKey(respuesta))
                {
                    respuestas[respuesta]++;
                }
                else
                {
                    respuestas[respuesta] = 1;
                }
            }
            var maxVotos = respuestas.Values.Max();
            var respuestasMasVotadas = respuestas.Where(r => r.Value == maxVotos).Select(r => r.Key).ToList();
            return respuestasMasVotadas[new Random().Next(respuestasMasVotadas.Count)];
        }

        public void SetCalificacion(int calificacion)
        {
            foreach (var alumno in alumnos)
            {
                alumno.SetCalificacion(calificacion);
            }
        }

        public string MostrarCalificacion()
        {
            return alumnos.FirstOrDefault()?.MostrarCalificacion() ?? "0";
        }

        public bool SosIgual(Comparable comparable)
        {
            return alumnos.Any(a => a.SosIgual(comparable));
        }

        public bool SosMenor(Comparable comparable)
        {
            return alumnos.All(a => a.SosMenor(comparable));
        }

        public bool SosMayor(Comparable comparable)
        {
            return alumnos.All(a => a.SosMayor(comparable));
        }

        public void SetStrategy(IStrategyAlumno strategy)
        {
            foreach (var alumno in alumnos)
            {
                alumno.SetStrategy(strategy);
            }
        }

        public int GetCalificacion()
        {
            return (int)alumnos.Average(a => a.GetCalificacion());
        }

        public int GetLegajo()
        {
            return alumnos.FirstOrDefault()?.GetLegajo() ?? -1; // -1 si no hay alumnos
        }

        public int GetDni()
        {
            return alumnos.FirstOrDefault()?.GetDni() ?? -1; // -1 si no hay alumnos
        }

        public double GetPromerdio()
        {
            return alumnos.Average(a => a.GetPromerdio());
        }

        public void PrestarAtencion()
        {
            foreach (var alumno in alumnos)
            {
                alumno.PrestarAtencion();
            }
        }

        public void Distraerse()
        {
            foreach (var alumno in alumnos)
            {
                alumno.Distraerse();
            }
        }
    }
}
