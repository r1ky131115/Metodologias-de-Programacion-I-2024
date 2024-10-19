using Metodologias_de_Programacion_I_2024.Clases.Proxy;
using Metodologias_de_Programacion_I_2024.Interfaces;

namespace Metodologias_de_Programacion_I_2024.Clases.FactoryMethod
{
    public class FabricaDeProxyAlumno : Fabrica
    {
        public override Comparable crearAleatorio()
        {
            Helper helper = new Helper();
            Random random = new Random();
            string nombreAleatorio = helper.GetNombre();
            int dniAleatorio = random.Next(10000000, 99999999);
            int legajoAleatorio = random.Next(1000, 9999);
            double promedioAleatorio = Math.Round(random.NextDouble() * 10, 2);

            return new ProxyAlumnoMuyEstudioso(nombreAleatorio, dniAleatorio, legajoAleatorio, promedioAleatorio);
        }

        public override Comparable crearPorTeclado()
        {
            Console.Write("Ingrese el nombre del alumno: ");
            string nombre = Console.ReadLine() ?? string.Empty;

            Console.Write("Ingrese el DNI del alumno (8 dígitos): ");
            int dni = int.Parse(Console.ReadLine());

            Console.Write("Ingrese el legajo del alumno (4 dígitos): ");
            int legajo = int.Parse(Console.ReadLine());

            Console.Write("Ingrese el promedio del alumno (0.0 a 10.0): ");
            double promedio = double.Parse(Console.ReadLine());

            return new ProxyAlumnoMuyEstudioso(nombre, dni, legajo, promedio);
        }
    }
}
