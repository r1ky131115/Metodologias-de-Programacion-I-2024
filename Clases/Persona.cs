using Metodologias_de_Programacion_I_2024.Interfaces;

namespace Metodologias_de_Programacion_I_2024.Clases
{
    public class Persona : Comparable
    {
        private string Nombre;
        private int dni;

        public Persona(string nombre, int dni)
        {
            this.Nombre = nombre;
            this.dni = dni;
        }

        public string GetNombre() { return Nombre; }
        public int GetDni() { return dni; }

        public virtual bool SosIgual(Comparable comparable)
        {
            Numero numero = (Numero)comparable;
            return this.dni == numero.getValor();
        }

        public virtual bool SosMenor(Comparable comparable)
        {
            Persona otraPersona = (Persona)comparable;
            return this.dni < otraPersona.GetDni();
        }

        public virtual bool SosMayor(Comparable comparable)
        {
            Persona otraPersona = (Persona)comparable;
            return this.dni > otraPersona.GetDni();
        }

        public override string ToString()
        {
            return $"Nombre: {this.GetNombre()} con Dni {this.GetDni()}.";
        }
    }
}
