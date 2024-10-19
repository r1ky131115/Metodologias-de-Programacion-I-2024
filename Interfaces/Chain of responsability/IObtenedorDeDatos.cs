namespace Metodologias_de_Programacion_I_2024.Interfaces.Chain_of_responsability
{
    public interface IObtenedorDeDatos
    {
        void EstablecerSiguiente(IObtenedorDeDatos siguiente);
        void ObtenerDatos();
    }
}
