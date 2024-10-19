namespace Metodologias_de_Programacion_I_2024.Clases.Template_Method
{
    public class JuegoPoker : JuegoCartas
    {
        private List<string> mazo;
        private Dictionary<Persona, List<string>> cartasJugadores;

        public JuegoPoker(List<Persona> jugadores, int puntosGanador) : base(jugadores, puntosGanador)
        {
            mazo = new List<string> { "As", "Rey", "Reina", "J", "10", "9", "8", "7", "6", "5", "4", "3", "2" };
            cartasJugadores = new Dictionary<Persona, List<string>>();
        }

        protected override void MezclarMazo()
        {
            Console.WriteLine("Mezclando el mazo...");
            Random rand = new Random();
            mazo.Sort((a, b) => rand.Next(-1, 2)); // Mezclar aleatoriamente
        }

        protected override void RepartirCartas()
        {
            Console.WriteLine("Repartiendo cartas iniciales...");
            foreach (var jugador in jugadores)
            {
                cartasJugadores[jugador] = new List<string> { mazo[0], mazo[1] }; // Reparte 2 cartas
                mazo.RemoveRange(0, 2); // Quita las cartas del mazo
                Console.WriteLine($"{jugador.GetNombre()} recibe: {string.Join(", ", cartasJugadores[jugador])}");
            }
        }

        protected override void JugarMano()
        {
            Console.WriteLine("Jugando una mano...");
            foreach (var jugador in jugadores)
            {
                Console.WriteLine($"{jugador.GetNombre()} está jugando...");
            }
        }

        protected override bool ChequearGanador(out Persona ganador)
        {
            ganador = null;

            foreach (var jugador in jugadores)
            {
                int puntos = new Random().Next(0, 10); // Puntuación aleatoria
                Console.WriteLine($"{jugador.GetNombre()} obtiene {puntos} puntos.");

                if (puntos >= puntosGanador)
                {
                    ganador = jugador;
                    return true;
                }
            }
            return false;
        }
    }
}
