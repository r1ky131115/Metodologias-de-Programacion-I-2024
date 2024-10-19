using Metodologias_de_Programacion_I_2024.Interfaces;
using Metodologias_de_Programacion_I_2024.Interfaces.Observer;

namespace Metodologias_de_Programacion_I_2024.Clases
{
    public class Profesor : Persona, IObservado
    {
        public List<IObservador> listaObservadores;
        public int antigueadad { get; set; }
        public bool hablando { get; set; } = false;

        public Profesor(string n, int d, int antiguedad) : base(n, d)
        {
            this.antigueadad = antiguedad;
            listaObservadores = new List<IObservador>();
        }

        public void hablarALaClase()
        {
            hablando = true;
            Console.WriteLine("Hablando de algún tema.");
            Notificar();
        }

        public void escribirEnElPizarron()
        {
            hablando = false;
            Console.WriteLine("Escribiendo en el pizarrón.");
            Notificar();
        }

        public override bool SosIgual(Comparable comparable)
        {
            return this.antigueadad == ((Profesor)comparable).antigueadad;
        }

        public override bool SosMenor(Comparable comparable)
        {
            return this.antigueadad < ((Profesor)comparable).antigueadad;
        }

        public override bool SosMayor(Comparable comparable)
        {
            return this.antigueadad > ((Profesor)comparable).antigueadad;
        }

        public override string ToString()
        {
            return $"Profesor: {this.GetNombre()} con Dni {this.GetDni()} y antiguedad de {this.antigueadad} años.";
        }

        public void AgregarObservador(IObservador observador)
        {
            listaObservadores.Add(observador);
        }

        public void QuitarObservador(IObservador observador)
        {
            listaObservadores.Remove(observador);
        }

        public void Notificar()
        {
            foreach (var observador in listaObservadores)
            {
                observador.Actualizar(this);
            }
        }
    }
}
