using Interfaces_Practica1;

namespace Interfaces.Clases.Persona
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
        public virtual string getNombre
        { 
            get{return this.nombre;} 
        }
        public int getDni
        {
            get { return this.dni;}
        }
        //Metodos Comparable
        public virtual bool sosIgual(Comparable comparacion)
        {
            if (comparacion is Persona)
            {
                Persona p = (Persona)comparacion;
                return p.getDni == this.dni;
            }

            return false;
        }
        public virtual bool sosMenor(Comparable comparacion)
        {
            if (comparacion is Persona)
            {
                Persona p = (Persona)comparacion;
                return p.getDni < this.dni;
            }
            return false;
        }
        public virtual bool sosMayor(Comparable comparacion)
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