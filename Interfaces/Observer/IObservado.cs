using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metodologias_de_Programacion_I_2024.Interfaces.Observer
{
    public interface IObservado
    {
        void AgregarObservador(IObservador observador);
        void QuitarObservador(IObservador observador);
        void Notificar();
    }
}
