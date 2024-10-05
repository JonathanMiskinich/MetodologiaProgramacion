using Interfaces.Clases.Persona;

namespace PTemplateMethod
{
    public abstract class JuegoCartas
    {
        // Plantilla
        public Persona Jugar(Persona p1, Persona p2)
        {
            MezclarCartas();
            RepartirCartasIniciales();
            bool ganador  = false;
            
            while (!ganador)
            {
                foreach (Persona jugador in ObtenerJugadores())
                {
                    JugarMano(jugador);
                }
                ganador = ChequearGanador();
            }

            return Ganador();

        }
        // Pasos
        protected abstract void MezclarCartas();
        protected abstract void RepartirCartasIniciales();
        protected abstract List<Persona> ObtenerJugadores();
        protected abstract void JugarMano(Persona jugador);
        protected abstract bool ChequearGanador();
        protected abstract Persona Ganador();
    }
}