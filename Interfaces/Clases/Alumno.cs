using Interfaces.Clases.Persona;
using Interfaces_Practica1;
using Interfaces.PStrategy_Comparacion;

namespace Clases.Alumno
{
    public class Alumno : Persona
    {
        private int legajo;
        private float promedio;
        private Comparacion? metodoComparar = null;

        public Alumno(string nombre, int dni, int legajo, float promedio) : base(nombre, dni)
        {
            this.legajo = legajo;
            this.promedio = promedio;
        }

        public int getLegajo
        {
            get {return this.legajo;}
        }
        public float getPromedio
        {
            get { return this.promedio; }
        }
        public void setMetodoComparar(Comparacion comparar)
        {
            this.metodoComparar = comparar;
        }

        public bool Comparacion(Alumno alum)
        {
            return metodoComparar.ComparacionIguales(this, alum);
        }
        public override bool sosIgual(Comparable comparacion)
        {
            if (comparacion is Alumno)
            {
                Alumno alum = (Alumno)comparacion;
                return alum.getLegajo == this.legajo;
            }

            return false;
        }

        public override bool sosMenor(Comparable comparacion)
        {
            if (comparacion is Alumno)
            {
                Alumno alum = (Alumno)comparacion;
                return alum.getLegajo < this.legajo;
            }

            return false;
        }

        public override bool sosMayor(Comparable comparacion)
        {
            if (comparacion is Alumno)
            {
                Alumno alum = (Alumno)comparacion;
                return alum.getLegajo > this.legajo;
            }

            return false;
        }
        public override string ToString()
        {
            return $"Nombre: {this.nombre}\nDni: {this.dni}\nLegajo: {this.legajo}\nPromedio: {this.promedio}";
        }
    }
}
