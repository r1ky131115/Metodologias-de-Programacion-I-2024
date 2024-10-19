using Metodologias_de_Programacion_I_2024.Clases.Strategy;
using Metodologias_de_Programacion_I_2024.Interfaces;
using Metodologias_de_Programacion_I_2024.Interfaces.Adapter;
using Metodologias_de_Programacion_I_2024.Interfaces.Observer;
using Metodologias_de_Programacion_I_2024.Interfaces.Strategy;

namespace Metodologias_de_Programacion_I_2024.Clases
{
    public class Alumno : Persona, IObservador, IAlumno
    {
        private int calificacion;
        private int legajo;
        private double promedio;
        private IStrategyAlumno strategyAlumno = new CompararPorPromedio();
        private string[] distracciones = {
            "Mirando el celular",
            "Dibujando en el margen de la carpeta",
            "Tirando aviones de papel"
        };

        public Alumno(string nombre, int dni, int legajo, double promedio) : base(nombre, dni)
        {
            this.legajo = legajo;
            this.promedio = promedio;
        }

        public void SetStrategy(IStrategyAlumno strategy)
        {
            strategyAlumno = strategy;
        }

        public int GetLegajo()
        {
            return legajo;
        }

        public double getPromedio()
        {
            return promedio;
        }

        public override bool SosIgual(Comparable comparable)
        {
            return strategyAlumno.SosIgual(this, comparable);
        }

        public override bool SosMenor(Comparable comparable)
        {
            return strategyAlumno.SosMenor(this, comparable);
        }

        public override bool SosMayor(Comparable comparable)
        {
            return strategyAlumno.SosMayor(this, comparable);
        }

        public override string ToString()
        {
            return $"Nombre: {this.GetNombre()} con Dni {this.GetDni()}, legajo {this.GetLegajo()} y un promedio de {this.getPromedio()}.";
        }

        public void PrestarAtencion()
        {
            Console.WriteLine($"{this.GetNombre()} está prestando atención.");
        }

        public void Distraerse()
        {
            Random random = new Random();            
            Console.WriteLine($"{this.GetNombre()} esta distraído con: {distracciones[random.Next(0,2)]}.");
        }

        public void Actualizar(IObservado observado)
        {
            if (observado is Profesor)
            {
                bool hablando = ((Profesor)observado).hablando;
                if (hablando)
                {
                    PrestarAtencion();
                }
                else
                {
                    Distraerse();
                }
            }
        }

        public int GetCalificacion()
        {
            return this.calificacion;
        }

        public double GetPromerdio()
        {
            return this.promedio;
        }

        public void SetCalificacion(int calificacion)
        {
            this.calificacion = calificacion;
        }

        public virtual int ResponderPregunta(int pregunta)
        {
            return new Random().Next(1, 3);
        }

        public virtual string MostrarCalificacion()
        {
            return this.GetNombre() + " - " + this.GetCalificacion();
        }
    }
}
