using Interfaces.Clases.Persona;
using PObserver.Notify;
using PObserver.Suscriptora;

namespace Clases.Profesor
{
    public class Profesor : Persona, INotify
    {
        private int _antiguedad;
        //Este Atributo sirve como parametro para el update de suscriptores
        private bool _hablando = false;
        private List<ISuscriptora> listaSuscriptores;
        //COnstructor
        public Profesor(string nombre, int dni, int ant) : base(nombre , dni)
        {
            this._antiguedad = ant;
            this.listaSuscriptores = new List<ISuscriptora>();
        }
        //Getters and setters
        public int GetAntiguedad
        {
            get {return this._antiguedad;}
        }
        //Metodos
        public void HablarALaClase()
        {
            Console.WriteLine("Hablando de algun tema a la clase.");
            this._hablando = true;
            this.Notificar();
        }

        public void EscribirEnElPizarron()
        {
            Console.WriteLine("Escribiendo en el pizarron.");
            this._hablando = false;
            this.Notificar();
        }
        public override string ToString()
        {
            return "Nombre: " + this.nombre + "\nDNI: " + this.dni + "\nAntiguedad: " + this._antiguedad;
        }
        //Metodos Interfaz Notify        
        public void Suscribirse(ISuscriptora s)
        {
            listaSuscriptores.Add(s);
        }

        public void DesSuscribirse(ISuscriptora s)
        {
            listaSuscriptores.Remove(s);
        }

        public void Notificar()
        {
            foreach (ISuscriptora sub in listaSuscriptores)
            {
                sub.Update(this._hablando);
            }
        }
    }
}