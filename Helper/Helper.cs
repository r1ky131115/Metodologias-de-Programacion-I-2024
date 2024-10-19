using Metodologias_de_Programacion_I_2024.Clases;
using Metodologias_de_Programacion_I_2024.Clases.FactoryMethod;
using Metodologias_de_Programacion_I_2024.Clases.Iteradores;
using Metodologias_de_Programacion_I_2024.Clases.Strategy;
using Metodologias_de_Programacion_I_2024.Colecciones;
using Metodologias_de_Programacion_I_2024.Interfaces;
using Metodologias_de_Programacion_I_2024.Interfaces.Adapter;
using Metodologias_de_Programacion_I_2024.Interfaces.Iterator;
using Metodologias_de_Programacion_I_2024.Interfaces.Strategy;
using Metodologias_de_Programacion_I_2024.Iteradores;

namespace Metodologias_de_Programacion_I_2024
{
    public class Helper
    {
        public string GetNombre()
        {
            List<string> nombres = new List<string>();
            nombres.Add("Jose");
            nombres.Add("Roberto");
            nombres.Add("Antonio");
            nombres.Add("Martin");
            nombres.Add("Rodolfo");
            nombres.Add("Miguel");
            nombres.Add("Joaquin");
            nombres.Add("Valentin");
            nombres.Add("Ramiro");
            nombres.Add("Nahuel");
            nombres.Add("Lisandro");
            nombres.Add("Agustina");
            nombres.Add("Josefina");
            nombres.Add("Maria");
            nombres.Add("Eugenia");
            nombres.Add("Emilia");
            nombres.Add("Andrea");
            nombres.Add("Susana");
            nombres.Add("Marta");
            nombres.Add("Mirta");
            nombres.Add("Cristina");
            nombres.Add("Amalia");
            return nombres[new Random().Next(nombres.Count - 1)];
        }

        public void Llenar(Coleccionable coleccoinable)
        {
            for (int i = 0; i < 20; i++)
            {
                Comparable comparable = new Numero(new Random().Next());
                coleccoinable.Agregar(comparable);
            }
        }

        public void Informar(Coleccionable coleccionable)
        {
            Console.WriteLine("El más grande de la coleccion es {0} ", coleccionable.Maximo());
            Console.WriteLine("El más chico de la coleccion es {0} ", coleccionable.Minimo());
            Console.WriteLine("La cantidad de elementos de la cola es {0}", coleccionable.Cuantos());
            
            Random random = new Random();
            string nombreAleatorio = GetNombre();
            int dniAleatorio = random.Next(10000000, 99999999);
            int legajoAleatorio = random.Next(1000, 9999);
            double promedioAleatorio = Math.Round(random.NextDouble() * 10, 2);

            //Comparable comparable = new Alumno(nombreAleatorio, dniAleatorio, legajoAleatorio, promedioAleatorio);

            //if (coleccionable.Contiene(comparable))
            //{
            //    Console.WriteLine($"El elemento '{comparable.ToString()}' esta en la colección.");
            //}
            //else
            //{
            //    Console.WriteLine($"El elemento '{comparable.ToString()}' no esta en la colección.");
            //}
        }

        public void LlenarPersonas(Coleccionable coleccionable)
        {
            Random random = new Random();
            for (int i = 0; i < 20; i++)
            {
                string nombreAleatorio = GetNombre();
                int dniAleatorio = random.Next(10000000, 99999999);
                Persona persona = new Persona(nombreAleatorio, dniAleatorio);
                coleccionable.Agregar(persona);
            }
        }

        public void LlenarAlumnos(Coleccionable coleccionable)
        {
            Random random = new Random();
            for (int i = 0; i < 20; i++)
            {
                string nombreAleatorio = GetNombre();
                int dniAleatorio = random.Next(10000000, 99999999);
                int legajoAleatorio = random.Next(1000, 9999);
                double promedioAleatorio = Math.Round(random.NextDouble() * 10, 2);

                IAlumno alumno = new Alumno(nombreAleatorio, dniAleatorio, legajoAleatorio, promedioAleatorio);
                alumno.SetStrategy(new CompararPorNombre());
                coleccionable.Agregar(alumno);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="coleccionable">Colecciones del tipo: Pila, Cola, Diccionario o Conjunto</param>
        /// <param name="tipoIter">1 para cola
        /// 2 para pila
        /// 3 para diccionario
        /// 4 para conjunto</param>
        public void ImprimirElementos(Coleccionable coleccionable, int tipoIter)
        {
            Iterador iterador = null;

            switch (tipoIter)
            {
                case 1:
                    iterador = new IteradorDeCola(coleccionable);
                    break;
                case 2:
                    iterador = new IteradorDePila(coleccionable);
                    break;
                case 3:
                    iterador = new IteradorDeDiccionario(coleccionable);
                    break;
                case 4:
                    iterador = new IteradorDeConjunto(coleccionable);
                    break;
                default:
                    break;
            }

            while (!iterador.fin())
            {
                Console.WriteLine(iterador.actual());
                iterador.siguiente();
            }
        }

        public void CambiarEstrategia(Coleccionable coleccionable, IStrategyAlumno strategyComparable)
        {
            Pila pilaAlumnos = (Pila)coleccionable;

            foreach (var item in pilaAlumnos.pila)
            {
                IAlumno alumno = (Alumno)item;
                alumno.SetStrategy(strategyComparable);
            }
        }

        public void LlenarFabricaAlatoria(Coleccionable coleccionable)
        {
            for (int i = 1; i < 21; i++)
            {
                Comparable comparable = Fabrica.CrearAleatorio();
                coleccionable.Agregar(comparable);
            }

            //for (int i = 0; i < 20; i++)
            //{
            //    Comparable comparable = Fabrica.CrearPorTeclado(opcion);
            //    coleccionable.Agregar(comparable);
            //}
        }

        public static void DictadoDeClases(Profesor profesor)
        {
            Random random = new Random();
            int iter = 0;
            do
            {
                switch (random.Next(1, 3))
                {
                    case 1:
                        profesor.hablarALaClase();
                        break;
                    case 2:
                        profesor.escribirEnElPizarron();
                        break;
                    default:
                        profesor.hablarALaClase();
                        break;
                }
                iter++;

            } while (iter < 3);
            
        }

        public void LlenarAlumnosObservando(Profesor profesor)
        {
            Random random = new Random();
            for (int i = 0; i < 10; i++)
            {
                string nombreAleatorio = GetNombre();
                int dniAleatorio = random.Next(10000000, 99999999);
                int legajoAleatorio = random.Next(1000, 9999);
                double promedioAleatorio = Math.Round(random.NextDouble() * 10, 2);

                IAlumno alumno = new Alumno(nombreAleatorio, dniAleatorio, legajoAleatorio, promedioAleatorio);
                profesor.AgregarObservador((Alumno)alumno);
            }
        }

    }
}
