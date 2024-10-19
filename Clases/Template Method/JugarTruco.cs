namespace Metodologias_de_Programacion_I_2024.Clases.Template_Method
{
    public class JuegoTruco : JuegoCartas
    {
        private List<string> mazo;
        private Dictionary<Persona, List<string>> cartasJugadores;
        private Dictionary<Persona, int> puntosJugadores;

        public JuegoTruco(List<Persona> jugadores, int puntosGanador) : base(jugadores, puntosGanador)
        {
            mazo = new List<string>
            {
                "1 de Espadas", "1 de Bastos", "7 de Espadas", "7 de Oros",
                "3 de Espadas", "3 de Bastos", "2 de Espadas", "2 de Bastos",
                "1 de Copas", "1 de Oros", "12 de Espadas", "12 de Bastos",
                "11 de Espadas", "11 de Bastos", "10 de Espadas", "10 de Bastos",
                "7 de Copas", "7 de Bastos", "6 de Espadas", "6 de Bastos",
                "5 de Espadas", "5 de Bastos", "4 de Espadas", "4 de Bastos",
                "3 de Copas", "3 de Oros", "2 de Copas", "2 de Oros"
            };

            cartasJugadores = new Dictionary<Persona, List<string>>();
            puntosJugadores = new Dictionary<Persona, int>();
        }

        protected override void MezclarMazo()
        {
            Console.WriteLine("Mezclando el mazo...");
            Random rand = new Random();
            mazo.Sort((a, b) => rand.Next(-1, 2));
        }

        protected override void RepartirCartas()
        {
            Console.WriteLine("Repartiendo cartas iniciales...");
            foreach (var jugador in jugadores)
            {
                cartasJugadores[jugador] = new List<string>();
                for (int i = 0; i < 3; i++) // Reparte 3 cartas
                {
                    cartasJugadores[jugador].Add(mazo[0]);
                    mazo.RemoveAt(0);
                }
                Console.WriteLine($"{jugador.GetNombre()} recibe: {string.Join(", ", cartasJugadores[jugador])}");
            }
        }

        protected override void JugarMano()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\nJugando una mano...");
            Console.ResetColor();
            foreach (var jugador in jugadores)
            {
                // Simular la elección de carta para jugar
                string cartaElegida = cartasJugadores[jugador][new Random().Next(cartasJugadores[jugador].Count)];
                Console.WriteLine($"{jugador.GetNombre()} juega: {cartaElegida}");

                // Lógica para acumular puntos en base a la carta jugada
                int puntos = CalcularPuntos(cartaElegida);
                puntosJugadores[jugador] = puntosJugadores.GetValueOrDefault(jugador) + puntos;
                Console.WriteLine($"{jugador.GetNombre()} acumula {puntos} puntos. Total: {puntosJugadores[jugador]}");
            }
        }

        protected override bool ChequearGanador(out Persona ganador)
        {
            ganador = null;
            foreach (var jugador in jugadores)
            {
                if (puntosJugadores[jugador] >= puntosGanador)
                {
                    ganador = jugador;
                    return true;
                }
            }
            return false;
        }

        private int CalcularPuntos(string carta)
        {
            // Ejemplo de cálculo de puntos, ajustar según las reglas del Truco
            if (carta.Contains("1 de Espadas") || carta.Contains("1 de Bastos"))
                return 3;
            if (carta.Contains("7 de Espadas") || carta.Contains("7 de Oros"))
                return 2;
            if (carta.Contains("3"))
                return 1;
            return 0; // Otras cartas no suman puntos
        }
    }
}