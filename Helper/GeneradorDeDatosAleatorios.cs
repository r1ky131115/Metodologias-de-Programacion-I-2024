using Metodologias_de_Programacion_I_2024.Interfaces.Chain_of_responsability;
using System.Text;

namespace Metodologias_de_Programacion_I_2024
{
    public class GeneradorDeDatosAleatorios : IObtenedorDeDatos
    {
        private IObtenedorDeDatos _siguiente;

        public void EstablecerSiguiente(IObtenedorDeDatos siguiente)
        {
            _siguiente = siguiente;
        }

        public void ObtenerDatos()
        {
            Console.WriteLine("Generando un número aleatorio: " + numeroAleatorio(100));
            Console.WriteLine("Generando una cadena aleatoria: " + StringAleatorio(10));

            _siguiente?.ObtenerDatos();
        }

        public static int numeroAleatorio(int max)
        {
            if (max <= 0) throw new ArgumentOutOfRangeException(nameof(max), "El valor debe ser mayor que 0.");
            return new Random().Next(0, max);
        }

        public static string StringAleatorio(int cant)
        {
            if (cant <= 0) throw new ArgumentOutOfRangeException(nameof(cant), "El valor debe ser mayor que 0.");
            const string caracteres = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789!@#$%^&*()_+-=<>?";
            StringBuilder resultado = new StringBuilder();
            Random random = new Random();

            for (int i = 0; i < cant; i++)
            {
                int index = random.Next(caracteres.Length);
                resultado.Append(caracteres[index]);
            }

            return resultado.ToString();
        }
    }
}
