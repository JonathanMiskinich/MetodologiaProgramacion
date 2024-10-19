using Alumnos.Comparaciones;
using Interfaces_Practica1;
using Interfaz.IAlumnos;

namespace Clases.Alumnos
{
    public class AlumnoProxy : IAlumno
    {
        private IAlumno alumnoReal = null;
        private string nombre;
        private int dni;
        private int legajo;
        private float promedio;
        private int calificacion;
        private Comparacion st = null;
        public AlumnoProxy(string nombre, int dni, int legajo, float promedio) 
        {
            this.nombre = nombre;
            this.dni = dni;
            this.legajo = legajo;
            this.promedio = promedio;
            this.st = null;
        }
        public int getCalificacion()
        {
            return this.calificacion;
        }

        public int getDni()
        {
            return this.dni;
        }

        public int getLegajo()
        {
            return this.legajo;
        }

        public string getNombre()
        {
            return this.nombre;
        }

        public float getPromedio()
        {
            return this.promedio;
        }

        public string MostrarCalificacion()
        {
            return $"{this.nombre}\t{this.calificacion.ToString()}";
        }

        public int ResponderPregunta(int pregunta)
        {
            if (alumnoReal == null)
                alumnoReal = new Alumno(nombre, dni, legajo, promedio);
            return alumnoReal.ResponderPregunta(pregunta);
        }

        public void setCalificacion(int calif)
        {
            this.calificacion = calif;
        }

        public void setMetodoComparar(Comparacion comparar)
        {
            this.st = comparar;
        }
        public bool sosIgual(Comparable comparacion)
        {
            if (st == null)
                st = new ComparacionCalificacion();
            return st.Iguales(this, (IAlumno)comparacion);
        }
        public bool sosMayor(Comparable comparacion)
        {
            if (st == null)
                st = new ComparacionCalificacion();
            return st.MayorQue(this, (IAlumno)comparacion);
        }
        public bool sosMenor(Comparable comparacion)
        {
            if (st == null)
                st = new ComparacionCalificacion();
            return st.MenorQue(this, (IAlumno)comparacion);
        }
    }
}