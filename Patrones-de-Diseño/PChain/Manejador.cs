namespace ObtencionDeDatos
{
    public interface IObtenerDatos
    {
        public void SetManejador(IObtenerDatos manejador);
        public int ObtenerNumero(int max);
        public string ObtenerCadena(int cant);
    }

    public abstract class BaseManejadorDatos : IObtenerDatos
    {
        protected IObtenerDatos siguienteManejador;
        public void SetManejador(IObtenerDatos manejador)
        {
            this.siguienteManejador = manejador;
        }

        public virtual int ObtenerNumero(int max)
        {
            throw new NotImplementedException();
        }

        public virtual string ObtenerCadena(int cant)
        {
            throw new NotImplementedException();
        }

        
    }
}