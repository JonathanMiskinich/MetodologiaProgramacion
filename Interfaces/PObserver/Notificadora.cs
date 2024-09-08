using PObserver.Notify;
using PObserver.Suscriptora;

namespace PObserver.Notificadora
{
    public abstract class Notificadora : INotify
    {
        protected List<ISuscriptora> listaSuscriptores;
        public virtual void Suscribirse(ISuscriptora s)
        {
            listaSuscriptores.Add(s);
        }

        public virtual void DesSuscribirse(ISuscriptora s)
        {
            listaSuscriptores.Remove(s);
        }

        public virtual void Notificar()
        {
            foreach (ISuscriptora sub in listaSuscriptores)
            {
                sub.Update();
            }
        }
    }
}