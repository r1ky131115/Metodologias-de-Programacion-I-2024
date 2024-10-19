using Metodologias_de_Programacion_I_2024.Interfaces;
using Metodologias_de_Programacion_I_2024.Interfaces.Adapter;
using Metodologias_de_Programacion_I_2024.Interfaces.Strategy;

namespace Metodologias_de_Programacion_I_2024.Clases.Strategy
{
    public partial class CompararPorNombre : IStrategyAlumno
    {
        public bool SosMayor(Comparable a, Comparable b) => string.Compare(((IAlumno)a).GetNombre(), ((IAlumno)b).GetNombre()) < 0;
        public bool SosMenor(Comparable a, Comparable b) => string.Compare(((IAlumno)a).GetNombre(), ((IAlumno)b).GetNombre()) > 0;
        public bool SosIgual(Comparable a, Comparable b) => string.Compare(((IAlumno)a).GetNombre(), ((IAlumno)b).GetNombre()) == 0;
    }
}
