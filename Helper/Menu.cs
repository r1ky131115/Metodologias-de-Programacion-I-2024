using Metodologias_de_Programacion_I_2024.Clases;
using Metodologias_de_Programacion_I_2024.Clases.Adapter;
using Metodologias_de_Programacion_I_2024.Clases.Command;
using Metodologias_de_Programacion_I_2024.Clases.Composite;
using Metodologias_de_Programacion_I_2024.Clases.Decorator;
using Metodologias_de_Programacion_I_2024.Clases.FactoryMethod;
using Metodologias_de_Programacion_I_2024.Clases.Strategy;
using Metodologias_de_Programacion_I_2024.Clases.Template_Method;
using Metodologias_de_Programacion_I_2024.Colecciones;
using Metodologias_de_Programacion_I_2024.Interfaces;
using Metodologias_de_Programacion_I_2024.Interfaces.Adapter;
using Metodologias_de_Programacion_I_2024.Interfaces.Command;

namespace Metodologias_de_Programacion_I_2024
{
    public static class Menu
    {
        public static void Practica_1()
        {
            Helper helper = new Helper();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("PRACTICA 1:");
            Console.ResetColor();

            Pila pila = new Pila();
            Cola cola = new Cola();
            ColeccionMultiple coleccionMultiple = new ColeccionMultiple(pila, cola);

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Llenando la pila...");
            Console.ResetColor();
            helper.Llenar(pila);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Pila llena.");
            Console.ResetColor();

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Llenando la cola...");
            Console.ResetColor();
            helper.Llenar(cola);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Cola llena.");
            Console.ResetColor();

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Informando sobre la pila...");
            Console.ResetColor();
            helper.Informar(pila);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Información de la pila mostrada.");
            Console.ResetColor();

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Informando sobre la cola...");
            Console.ResetColor();
            helper.Informar(cola);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Información de la cola mostrada.");
            Console.ResetColor();

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Informando sobre la colección múltiple...");
            Console.ResetColor();
            helper.Informar(coleccionMultiple);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Información de la colección múltiple mostrada.");
            Console.ResetColor();

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("******************************************************");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Para reflexionar. Además de la creación de la nueva clase ColeccionMultiple y la adaptación del módulo main, responda ¿qué tuvo que modificar de lo realizado en los primeros seis ejercicios?");
            Console.ResetColor();
            Console.WriteLine("Reflexión: " +
                "No se tuvo que modificar nada ya que las colecciones trabajan con objetos comparables, lo que permite una flexibilidad en la implementación de las mismas.");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("******************************************************");

            Console.ResetColor();

            Pila pilaPersonas = new Pila();
            Cola colaPersonas = new Cola();
            ColeccionMultiple coleccionMultiplePersonas = new ColeccionMultiple(pilaPersonas, colaPersonas);

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Llenando personas en la pila...");
            Console.ResetColor();
            helper.LlenarPersonas(pilaPersonas);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Personas en la pila llenadas.");
            Console.ResetColor();

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Llenando personas en la cola...");
            Console.ResetColor();
            helper.LlenarPersonas(colaPersonas);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Personas en la cola llenadas.");
            Console.ResetColor();

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Informando sobre la Coleccion Multiple Personas nuevamente...");
            Console.ResetColor();
            helper.Informar(coleccionMultiplePersonas);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Información de la Coleccion Multiple Personas mostrada nuevamente.");
            Console.ResetColor();

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("******************************************************");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Para reflexionar. Además de la creación de la nueva clase Persona, la creación de la función llenarPersonas y la adaptación del módulo main, responda ¿qué tuvo que modificar de lo realizado en los ejercicios 1 a 6 y el 8?");
            Console.ResetColor();
            Console.WriteLine("Reflexión: " +
                "No se tuvo que modificar nada ya que las colecciones trabajan con objetos comparables, solo especificar en las comparaciones que el comparable es del tipo Persona, lo que permite una flexibilidad en la implementación de las mismas.");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("******************************************************");
            Console.ResetColor();

            Pila pilaAlumnos = new Pila();
            Cola colaAlumnos = new Cola();
            ColeccionMultiple coleccionMultipleAlumnos = new ColeccionMultiple(pilaAlumnos, colaAlumnos);

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Llenando personas en la pila...");
            Console.ResetColor();
            helper.LlenarAlumnos(pilaAlumnos);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Personas en la pila llenadas.");
            Console.ResetColor();

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Llenando personas en la cola...");
            Console.ResetColor();
            helper.LlenarAlumnos(colaAlumnos);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Personas en la cola llenadas.");
            Console.ResetColor();

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Informando sobre la Coleccion Multiple Alumnos nuevamente...");
            Console.ResetColor();
            helper.Informar(coleccionMultipleAlumnos);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Información de la Coleccion Multiple Alumnos mostrada nuevamente.");
            Console.ResetColor();

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("******************************************************");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Responda ¿Funcionó? ¿Fue necesario decir explícitamente que Alumno tiene que implementar la interface Comparable? ¿Cuál fue el criterio por el cual se comparó a los alumnos? ¿Por qué?");
            Console.ResetColor();
            Console.WriteLine("Respuesta: " +
                "Funciono. No fue necesario explicitamente decir que alumno tenga que implementar la interface comparable ya que la heredo de persona. Se los comparo por legajo.");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("******************************************************");

            Console.WriteLine();

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("******************************************************");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Para reflexionar. Responda ¿Podría haber hecho esto mismo sin interfaces? ¿A qué costo?");
            Console.ResetColor();
            Console.WriteLine("Reflexión: " +
                "Sí, podría haber hecho lo mismo sin interfaces, pero a un costo significativo. Sin interfaces, habría perdido la flexibilidad y el polimorfismo, obligándo a duplicar código para cada tipo de colección (Pila, Cola, etc.) y para cada tipo de objeto (Persona, Alumno). Esto resultaría en un diseño rígido, difícil de mantener y extender, ya que cada cambio requeriría modificar múltiples partes del código en lugar de simplemente implementar una nueva interfaz o clase que siga un contrato común. Además, el código sería menos reutilizable y menos claro.");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("******************************************************");
            Console.ResetColor();

        }

        public static void Practica_2()
        {
            Helper helper = new Helper();

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("PRACTICA 2:");
            Console.ResetColor();

            Pila pilaAlumnos = new Pila();
            Cola colaAlumnos = new Cola();
            ColeccionMultiple coleccionMultipleAlumnos = new ColeccionMultiple(pilaAlumnos, colaAlumnos);

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Llenando personas en la pila...");
            Console.ResetColor();
            helper.LlenarAlumnos(pilaAlumnos);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Personas en la pila llenadas.");
            Console.ResetColor();

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Llenando personas en la cola...");
            Console.ResetColor();
            helper.LlenarAlumnos(colaAlumnos);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Personas en la cola llenadas.");
            Console.ResetColor();

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Informando sobre la Coleccion Multiple Alumnos nuevamente...");
            Console.ResetColor();
            helper.Informar(coleccionMultipleAlumnos);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Información de la Coleccion Multiple Alumnos mostrada nuevamente.");
            Console.ResetColor();

            Diccionario diccionario = new Diccionario();
            Conjunto conjunto = new Conjunto();

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Informando sobre la Coleccion Multiple Alumnos nuevamente...");
            Console.ResetColor();
            helper.LlenarAlumnos(diccionario);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Información de la Coleccion Multiple Alumnos mostrada nuevamente.");
            Console.ResetColor();

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Informando sobre la Coleccion Multiple Alumnos nuevamente...");
            Console.ResetColor();
            helper.LlenarAlumnos(conjunto);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Información de la Coleccion Multiple Alumnos mostrada nuevamente.");
            Console.ResetColor();

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Iterando coleccion...");
            Console.ResetColor();
            helper.ImprimirElementos(colaAlumnos, 1);
            helper.ImprimirElementos(pilaAlumnos, 2);
            helper.ImprimirElementos(diccionario, 3);
            helper.ImprimirElementos(conjunto, 4);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Fin de la iteracción");
            Console.ResetColor();


            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Cambiando estrategias...");
            Console.ResetColor();

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Estrategia de comparar por dni");
            Console.ResetColor();
            helper.CambiarEstrategia(pilaAlumnos, new CompararPorDNI());
            helper.Informar(pilaAlumnos);

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Estrategia de Comparar Por Legajo");
            Console.ResetColor();
            helper.CambiarEstrategia(pilaAlumnos, new CompararPorLegajo());
            helper.Informar(pilaAlumnos);

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Estrategia de Comparar Por Promedio");
            Console.ResetColor();
            helper.CambiarEstrategia(pilaAlumnos, new CompararPorPromedio());
            helper.Informar(pilaAlumnos);
            Console.ResetColor();
        }

        internal static void Practica_3()
        {
            Helper helper = new Helper();

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("PRACTICA 3:");

            Console.ResetColor();

            Pila pilaAlumnos = new Pila();

            helper.LlenarFabricaAlatoria(pilaAlumnos);

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Informando sobre la pila Alumnos fabricados...");
            Console.ResetColor();
            helper.Informar(pilaAlumnos);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Información de la pila Alumnos fabricados mostrada.");
            Console.ResetColor();

            Console.WriteLine("Reflexión: " +
                "Se podria tener una fabrica de coleccionables que tenga un metodo llamado \"crearColeccion\" que reciba una opcion y eliga que tipo de coleecion se crea.");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("******************************************************");


            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Implementando Observer");
            Console.ResetColor();
            Profesor profesor = new Profesor("Profe", 123, 10);

            helper.LlenarAlumnosObservando(profesor);

            Helper.DictadoDeClases(profesor);
            Console.ResetColor();
        }

        public static void Practica_4()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("******************************************************");
            Console.WriteLine("PRACTICA 4:");
            Console.WriteLine("******************************************************");
            Console.ResetColor();

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Patron Adapter...");
            Console.ResetColor();

            Teacher teacher = new Teacher();
            List<Comparable> listaAlumnos = new List<Comparable>();

            for (int i = 0; i < 10; i++)
            {
                IAlumno alumnoPorFabrica = (IAlumno)new FabricaDeAlumno().crearAleatorio();
                listaAlumnos.Add(alumnoPorFabrica);
                Student student = new AlumnoToStudent(alumnoPorFabrica);
                teacher.goToClass(student);

                alumnoPorFabrica.SetStrategy(new CompararPorCalificacion());
            }

            for (int i = 0; i < 10; i++)
            {
                IAlumno alumnoPorFabrica = (IAlumno)new FabricaDeAlumno().crearAleatorio();
                AlumnoMuyEstudioso alumnoMuyEstudioso = new AlumnoMuyEstudioso(
                    alumnoPorFabrica.GetNombre(),
                    alumnoPorFabrica.GetDni(),
                    alumnoPorFabrica.GetLegajo(),
                    alumnoPorFabrica.GetPromerdio()
                    );

                listaAlumnos.Add(alumnoMuyEstudioso);
                Student student = new AlumnoToStudent(alumnoMuyEstudioso);

                teacher.goToClass(student);
                alumnoPorFabrica.SetStrategy(new CompararPorCalificacion());
            }

            teacher.teachingAClass();

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\nPatron decorator...\n");

            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("\nNotas en letras:");
            Console.ResetColor();

            foreach (var alum in listaAlumnos)
            {
                Decorador decorador = new NotaEnLetrasDecorator((IAlumno)alum);
                Console.WriteLine(decorador.MostrarCalificacion());
            }

            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("\nNotas segun estado:");
            Console.ResetColor();

            foreach (var alum in listaAlumnos)
            {
                Decorador decorador = new EstadoDecorator((IAlumno)alum);
                Console.WriteLine(decorador.MostrarCalificacion());
            }

            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("\nNotas con recuadro:");
            Console.ResetColor();

            foreach (var alum in listaAlumnos)
            {
                Decorador decorador = new RecuadroDecorator((IAlumno)alum);
                Console.WriteLine(decorador.MostrarCalificacion());
            }

            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("\nNotas con legajo:");
            Console.ResetColor();

            foreach (var alum in listaAlumnos)
            {
                Decorador decorador = new LegajoDecorator((IAlumno)alum);
                Console.WriteLine(decorador.MostrarCalificacion());
            }
        }

        public static void Practica_5()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("******************************************************");
            Console.WriteLine("PRACTICA 5:");
            Console.WriteLine("******************************************************");
            Console.ResetColor();

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Patron Proxy...");
            Console.ResetColor();

            Teacher teacher = new Teacher();
            IAlumno proxyAlumno = (IAlumno)new FabricaDeProxyAlumno().crearAleatorio();

            Student student = new AlumnoToStudent(proxyAlumno);
            teacher.goToClass(student);
            proxyAlumno.SetStrategy(new CompararPorCalificacion());

            teacher.teachingAClass();

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\n\nPatron Command...");
            Console.ResetColor();

            Aula aula = new Aula();
            Pila pila = new Pila();

            IOrdenEnAula1 commandInicio = new OrdenInicio(aula);
            IOrdenEnAula2 commandReceptor = new OrdenReceptor(aula);
            IOrdenEnAula1 commandAulaLlena = new OrdenAulaLlena(aula);

            pila.setOrdenInicio(commandInicio);

            //commandInicio.Ejecutar();
            for (int i = 0; i < 10; i++)
            {
                //commandReceptor.Ejecutar(new FabricaDeAlumno().crearAleatorio());
                pila.setOrdenLlegaAlumno(commandReceptor, new FabricaDeAlumno().crearAleatorio());
            }

            //commandAulaLlena.Ejecutar();
            pila.setOrdenAulaLlena(commandAulaLlena);
        }

        public static void Practica_6()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("******************************************************");
            Console.WriteLine("PRACTICA 6:");
            Console.WriteLine("******************************************************");
            Console.ResetColor();

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\nPatron Composite...\n");
            Console.ResetColor();

            Aula aula = new Aula();
            Teacher teacher = new Teacher();

            AlumnoCompuesto alumnoCompuesto = new AlumnoCompuesto();

            for (int i = 0; i < 5; i++)
            {
                IAlumno proxyAlumno = (IAlumno)new FabricaAlumnoCompuesto().crearAleatorio();

                alumnoCompuesto.AgregarAlumno(proxyAlumno);
            }

            alumnoCompuesto.Distraerse();

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\n\nFactory Method...\n");
            Console.ResetColor();

            var jugador1 = new Persona("Alice", 123);
            var jugador2 = new Persona("Bob", 321);
            var jugadores = new List<Persona> { jugador1, jugador2 };
            int puntosGanador = 15; // Puntos necesarios para ganar

            JuegoCartas juego = new JuegoTruco(jugadores, puntosGanador);
            Persona ganador = juego.Jugar();

            Console.WriteLine($"La persona ganadora es: {ganador.GetNombre()}");
        }

    }
}
