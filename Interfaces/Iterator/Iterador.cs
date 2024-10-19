using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metodologias_de_Programacion_I_2024.Interfaces.Iterator
{
    public interface Iterador
    {
        void primero();
        void siguiente();
        bool fin();
        object actual();
    }
}
