using Metodologias_de_Programacion_I_2024;

class Program
{
    static void Main(string[] args)
    {
        bool continuar = true;

        while (continuar)
        {
            Console.Clear(); // Limpia la consola para mejor visualización
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("******************************************************");
            Console.WriteLine("         METODOLOGIA DE LA PROGRAMACIÓN - I.");
            Console.WriteLine("******************************************************");
            Console.ResetColor();

            Console.WriteLine("1- Interfaces y POO");
            Console.WriteLine("2- Strategy e Iterator");
            Console.WriteLine("3- Factory Method y Observer");
            Console.WriteLine("4- Adapter y Decorator");
            Console.WriteLine("5- Proxy y Command");
            Console.WriteLine("6- Composite y Template Method");
            Console.WriteLine("7- Chain of ResponsabilityArchivo y Singleton");
            Console.WriteLine("0- Salir");
            Console.WriteLine();

            Console.WriteLine("Seleccionar una opcion segun la practica a revisar: ");
            int opcion = ObtenerOpcion();

            switch (opcion)
            {
                case 1:
                    Menu.Practica_1();
                    break;
                case 2:
                    Menu.Practica_2();
                    break;
                case 3:
                    Menu.Practica_3();
                    break;
                case 4:
                    Menu.Practica_4();
                    break;
                case 5:
                    Menu.Practica_5();
                    break;
                case 6:
                    Menu.Practica_6();
                    break;
                case 7:
                    Menu.Practica_7();
                    break;
                case 0:
                    continuar = false; // Salir del bucle
                    break;
                default:
                    Console.WriteLine("Opción no válida, por favor intente de nuevo.");
                    break;
            }

            // Esperar a que el usuario presione una tecla antes de continuar
            if (continuar)
            {
                Console.WriteLine("Presione cualquier tecla para volver al menú...");
                Console.ReadKey();
            }
        }
    }

    private static int ObtenerOpcion()
    {
        while (true)
        {
            Console.Write("Por favor, ingresa una opción: ");
            string input = Console.ReadLine();

            // Verificar si la entrada es nula o vacía
            if (string.IsNullOrEmpty(input))
            {
                Console.WriteLine("Error: Debes ingresar un valor.");
                continue; // Volver a solicitar la entrada
            }

            // Intentar convertir la entrada a un entero
            if (int.TryParse(input, out int opcion))
            {
                return opcion; // Retorna la opción si es válida
            }
            else
            {
                Console.WriteLine("Error: Debes ingresar un número válido.");
            }
        }
    }
}
