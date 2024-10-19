using Metodologias_de_Programacion_I_2024.Interfaces;
using Metodologias_de_Programacion_I_2024.Interfaces.Adapter;
using Metodologias_de_Programacion_I_2024.Interfaces.Strategy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metodologias_de_Programacion_I_2024.Clases.Decorator
{
    public abstract class Decorador : IAlumno
    {
        private IAlumno al;

        protected Decorador(IAlumno alumno)
        {
            this.al = alumno;
        }

        public void Distraerse()
        {
            al.Distraerse();
        }

        public int GetCalificacion()
        {
            return al.GetCalificacion();
        }

        public int GetDni()
        {
            return al.GetDni();
        }

        public int GetLegajo()
        {
            return al.GetLegajo();
        }

        public string GetNombre()
        {
            return al.GetNombre();
        }

        public double GetPromerdio()
        {
            return al.GetPromerdio();
        }

        public abstract string MostrarCalificacion();

        public void PrestarAtencion()
        {
            al.PrestarAtencion();
        }

        public int ResponderPregunta(int pregunta)
        {
            return al.ResponderPregunta(pregunta);
        }

        public void SetCalificacion(int calificacion)
        {
            al.SetCalificacion(calificacion);
        }

        public void SetStrategy(IStrategyAlumno strategy)
        {
            al.SetStrategy(strategy);
        }

        public bool SosIgual(Comparable comparable)
        {
            return al.SosIgual(comparable);
        }

        public bool SosMayor(Comparable comparable)
        {
            return al.SosMayor(comparable);
        }

        public bool SosMenor(Comparable comparable)
        {
            return al.SosMenor(comparable);
        }
    }
}
