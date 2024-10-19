namespace Metodologias_de_Programacion_I_2024
{
    public class LectorDeDatos
    {
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
