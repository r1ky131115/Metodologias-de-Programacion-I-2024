namespace Metodologias_de_Programacion_I_2024.Interfaces.FactoryMethod
{
    public interface FabricaDeComparables
    {
        Comparable CrearAleatorio();
        Comparable CrearPorTeclado(int opcion);
    }
}