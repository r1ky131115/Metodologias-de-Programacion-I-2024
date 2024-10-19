namespace Metodologias_de_Programacion_I_2024.Clases.Template_Method
{
    public abstract class JuegoCartas
    {
        protected List<Persona> jugadores;
        protected int puntosGanador;

        public JuegoCartas(List<Persona> jugadores, int puntosGanador)
        {
            this.jugadores = jugadores;
            this.puntosGanador = puntosGanador;
        }

        public Persona Jugar()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Iniciando el juego...");
            Console.ResetColor();
            MezclarMazo();
            RepartirCartas();

            while (true)
            {
                JugarMano();
                if (ChequearGanador(out Persona ganador))
                {
                    Console.ForegroundColor= ConsoleColor.Yellow;
                    Console.WriteLine("\n*********************************");
                    Console.WriteLine($"     El ganador es: {ganador.GetNombre()}");
                    Console.WriteLine("*********************************\n");
                    Console.ResetColor();
                    return ganador;
                }
            }
        }

        protected abstract void MezclarMazo();
        protected abstract void RepartirCartas();
        protected abstract void JugarMano();
        protected abstract bool ChequearGanador(out Persona ganador);
    }
}
