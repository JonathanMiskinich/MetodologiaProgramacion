using Interfaces.Clases.Persona;

namespace Clases.Profesor
{
    public class Profesor : Persona
    {
        private int _antiguedad;
        //COnstructor
        public Profesor(string nombre, int dni, int ant) : base(nombre , dni)
        {
            this._antiguedad = ant;
        }
        //Getters and setters
        public int GetAntiguedad
        {
            get {return this._antiguedad;}
        }
        public void HablarALaClase()
        {
            Console.WriteLine("Hablando de algun tema a la clase.");
        }

        public void EscribirEnElPizarron()
        {
            Console.WriteLine("Escribiendo en el pizarron.");
        }
        public override string ToString()
        {
            return "Nombre: " + this.nombre + "\nDNI: " + this.dni + "\nAntiguedad: " + this._antiguedad;
        }
    }
}