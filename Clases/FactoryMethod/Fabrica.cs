using Metodologias_de_Programacion_I_2024.Interfaces;
using Metodologias_de_Programacion_I_2024.Interfaces.FactoryMethod;

namespace Metodologias_de_Programacion_I_2024.Clases.FactoryMethod
{
    public abstract class Fabrica
    {
        public abstract Comparable crearAleatorio();
        public static Comparable CrearAleatorio()
        {
            int opcion = GeneradorDeDatosAleatorios.numeroAleatorio(1);

            Fabrica creator = FabricaOpcion(opcion);

            return creator.crearAleatorio();
        }

        public abstract Comparable crearPorTeclado();
        public static Comparable CrearPorTeclado(int opcion)
        {
            Fabrica creator = FabricaOpcion(opcion);

            return creator.crearPorTeclado();
        }


        private static Fabrica FabricaOpcion(int opcion)
        {
            Fabrica fabrica = null;
            switch (opcion)
            {
                case 0:
                    fabrica = new FabricaDeAlumno();
                    break;
                case 1:
                    fabrica = new FabricaDeNumero();
                    break;
                case 2:
                    fabrica = new FabricaDeProfesor();
                    break;
                default:
                    fabrica = new FabricaDeNumero();
                    break;
            }
            return fabrica;
        }
    }
}
