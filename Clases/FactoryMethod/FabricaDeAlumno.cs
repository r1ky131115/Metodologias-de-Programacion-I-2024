﻿using Metodologias_de_Programacion_I_2024.Interfaces;
using Metodologias_de_Programacion_I_2024.Interfaces.Chain_of_responsability;

namespace Metodologias_de_Programacion_I_2024.Clases.FactoryMethod
{
    public class FabricaDeAlumno : Fabrica
    {
        public override Comparable crearAleatorio()
        {
            Helper helper = new Helper();
            Random random = new Random();
            string nombreAleatorio = helper.GetNombre();
            int dniAleatorio = GeneradorDeDatosAleatorios.numeroAleatorio(5);
            int legajoAleatorio = GeneradorDeDatosAleatorios.numeroAleatorio(999);
            double promedioAleatorio = Math.Round(random.NextDouble() * 10, 2);

            return new Alumno(nombreAleatorio, dniAleatorio, legajoAleatorio, promedioAleatorio);
        }

        public override Comparable crearPorTeclado()
        {
            IObtenedorDeDatos lector = new LectorDeDatos();

            Console.Write("Ingrese el nombre del alumno: ");
            string nombre = Console.ReadLine() ?? string.Empty;

            Console.Write("Ingrese el DNI del alumno (8 dígitos): ");
            int dni = int.Parse(Console.ReadLine());

            Console.Write("Ingrese el legajo del alumno (4 dígitos): ");
            int legajo = int.Parse(Console.ReadLine());

            Console.Write("Ingrese el promedio del alumno (0.0 a 10.0): ");
            double promedio = double.Parse(Console.ReadLine());

            return new Alumno(nombre, dni, legajo, promedio);
        }
    }
}
