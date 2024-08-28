using Interfaces_Practica1;

namespace Clases.Persona
{
    public class Persona : Comparable
    {
        protected string nombre;
        protected int dni;

        public Persona (string nombre, int dni)
        {
            this.nombre = nombre;
            this.dni = dni;
        }

        //Getter and Setters
        public string getNombre
        { 
            get{return this.nombre;} 
        }
        public int getDni
        {
            get { return this.dni;}
        }
        //Metodos Comparable
        public bool sosIgual(Comparable comparacion)
        {
            if (comparacion is Persona)
            {
                Persona p = (Persona)comparacion;
                return p.getDni == this.dni;
            }

            return false;
        }
        public bool sosMenor(Comparable comparacion)
        {
            if (comparacion is Persona)
            {
                Persona p = (Persona)comparacion;
                return p.getDni < this.dni;
            }
            return false;
        }
        public bool sosMayor(Comparable comparacion)
        {
            if (comparacion is Persona)
            {
                Persona p = (Persona)comparacion;
                return p.getDni > this.dni;
            }

            return false;
        }

        public override string ToString()
        {
            return "Nombre: " + this.nombre + "\nDni: " + this.dni;
        }
    }
}