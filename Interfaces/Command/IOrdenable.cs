namespace Metodologias_de_Programacion_I_2024.Interfaces.Command
{
    public interface IOrdenable
    {
        void setOrdenInicio(IOrdenEnAula1 ordenEnAula1);
        void setOrdenLlegaAlumno(IOrdenEnAula2 ordenEnAula2, Comparable comparable);
        void setOrdenAulaLlena(IOrdenEnAula1 ordenEnAula1);
    }
}
