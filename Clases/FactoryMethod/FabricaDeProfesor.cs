using Metodologias_de_Programacion_I_2024.Interfaces;

namespace Metodologias_de_Programacion_I_2024.Clases.FactoryMethod
{
    internal class FabricaDeProfesor : Fabrica
    {
        public override Comparable crearAleatorio()
        {
            Random random = new Random();
            string nombreAleatorio = GeneradorDeDatosAleatorios.StringAleatorio(4);
            int dniAleatorio = random.Next(10000000, 99999999);
            int antiguedad = random.Next(0, 35);

            return new Profesor(nombreAleatorio, dniAleatorio, antiguedad);
        }

        public override Comparable crearPorTeclado()
        {
            Console.Write("Ingrese el nombre del alumno: ");
            string nombre = Console.ReadLine() ?? string.Empty;

            Console.Write("Ingrese el DNI del alumno (8 dígitos): ");
            int dni = int.Parse(Console.ReadLine());

            Console.Write("Ingrese una antiguedad: ");
            int antiguedad = int.Parse(Console.ReadLine());

            return new Profesor(nombre, dni, antiguedad);
        }
    }
}
