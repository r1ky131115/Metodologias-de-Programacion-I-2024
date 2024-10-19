using Metodologias_de_Programacion_I_2024.Interfaces;

namespace Metodologias_de_Programacion_I_2024.Clases.FactoryMethod
{
    public class FabricaDeNumero : Fabrica
    {
        public override Comparable crearAleatorio()
        {
            return new Numero(new Random().Next());

        }

        public override Comparable crearPorTeclado()
        {
            Console.Write("Ingrese un número: ");
            int numero = int.Parse(Console.ReadLine());

            return new Numero(numero);
        }
    }
}
