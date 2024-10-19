using Metodologias_de_Programacion_I_2024.Interfaces.Chain_of_responsability;

namespace Metodologias_de_Programacion_I_2024
{
    public class LectorDeDatos : IObtenedorDeDatos
    {
        private IObtenedorDeDatos _siguiente;

        public void EstablecerSiguiente(IObtenedorDeDatos siguiente)
        {
            _siguiente = siguiente;
        }

        public void ObtenerDatos()
        {
            double numero = NumeroPorTeclado();
            string texto = StringPorTeclado();

            Console.WriteLine($"Número leído: {numero}");
            Console.WriteLine($"Texto leído: {texto}");

            _siguiente?.ObtenerDatos();
        }

        public double NumeroPorTeclado()
        {
            double numero;
            while (true)
            {
                Console.Write("Introduce un número: ");
                string entrada = Console.ReadLine();
                if (double.TryParse(entrada, out numero))
                {
                    return numero;
                }
                Console.WriteLine("Entrada no válida. Por favor, introduce un número.");
            }
        }

        public string StringPorTeclado()
        {
            Console.Write("Introduce un texto: ");
            return Console.ReadLine();
        }
    }
}