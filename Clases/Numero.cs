using Metodologias_de_Programacion_I_2024.Interfaces;

namespace Metodologias_de_Programacion_I_2024.Clases
{
    public class Numero : Comparable
    {
        public int valor;

        public Numero(int v)
        {
            this.valor = v;
        }

        public int getValor()
        {
            return valor;
        }

        public virtual bool SosIgual(Comparable comparable)
        {
            Numero otroNumero = (Numero)comparable;
            return this.valor == otroNumero.getValor();
        }

        public virtual bool SosMenor(Comparable comparable)
        {
            Numero otroNumero = (Numero)comparable;
            return this.valor < otroNumero.getValor();
        }

        public virtual bool SosMayor(Comparable comparable)
        {
            Numero otroNumero = (Numero)comparable;
            return this.valor > otroNumero.getValor();
        }

        public override string ToString()
        {
            return this.getValor().ToString();
        }
    }
}
