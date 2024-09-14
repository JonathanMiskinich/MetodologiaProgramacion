using PObserver.Suscriptora;

namespace PObserver.Notify
{
    public interface INotify
    {
        public void Suscribirse(ISuscriptora s);
        public void DesSuscribirse(ISuscriptora s);
        public void Notificar();
    }
}