using Metodologias_de_Programacion_I_2024.Interfaces.Command;

namespace Metodologias_de_Programacion_I_2024.Clases.Command
{
    public class OrdenAulaLlena : IOrdenEnAula1
    {
        private Aula _aula;

        public OrdenAulaLlena(Aula aula)
        {
            _aula = aula;
        }

        public void Ejecutar()
        {
            _aula.ClaseLista();
        }
    }
}
