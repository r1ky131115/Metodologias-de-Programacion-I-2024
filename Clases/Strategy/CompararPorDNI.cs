using Metodologias_de_Programacion_I_2024.Interfaces;
using Metodologias_de_Programacion_I_2024.Interfaces.Adapter;
using Metodologias_de_Programacion_I_2024.Interfaces.Strategy;

namespace Metodologias_de_Programacion_I_2024.Clases.Strategy
{
    public partial class CompararPorDNI : IStrategyAlumno
    {
        public bool SosMayor(Comparable a, Comparable b) => ((IAlumno)a).GetDni() < ((IAlumno)b).GetDni();
        public bool SosMenor(Comparable a, Comparable b) => ((IAlumno)a).GetDni() > ((IAlumno)b).GetDni();
        public bool SosIgual(Comparable a, Comparable b) => ((IAlumno)a).GetDni() == ((IAlumno)b).GetDni();
    }
}
