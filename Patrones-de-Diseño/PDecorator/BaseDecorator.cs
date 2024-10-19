using Alumnos.Comparaciones;
using Interfaces_Practica1;
using Interfaz.IAlumnos;

namespace PDecorator.BaseDecorators
{
    public class BaseDecorator : IAlumno
    {
        protected IAlumno alum;
        public BaseDecorator(IAlumno componente)
        {
            this.alum = componente;
        }
        public int getCalificacion()
        {
            return alum.getCalificacion();
        }

        public int getDni()
        {
            throw new NotImplementedException();
        }

        public int getLegajo()
        {
            return this.alum.getLegajo();
        }

        public string getNombre()
        {
            return this.alum.getNombre();
        }

        public float getPromedio()
        {
            return this.alum.getPromedio();
        }

        public virtual string MostrarCalificacion()
        {
            return this.alum.MostrarCalificacion();
        }

        public int ResponderPregunta(int pregunta)
        {
            return this.alum.ResponderPregunta(pregunta);
        }

        public void setCalificacion(int calif)
        {
            this.alum.setCalificacion(calif);
        }

        public void setMetodoComparar(Comparacion comparar)
        {
            this.alum.setMetodoComparar(comparar);
        }
        /* public bool sosIgual(IAlumno comparacion)
        {
            return this.alum.sosIgual(comparacion);
        } */
        public bool sosIgual(Comparable comparacion)
        {
            return this.alum.sosIgual(comparacion);
        }
        /* public bool sosMayor(IAlumno comparacion)
        {
            return this.alum.sosMayor(comparacion);
        } */
        public bool sosMayor(Comparable comparacion)
        {
            return this.alum.sosMayor(comparacion);
        }

        public bool sosMenor(Comparable comparacion)
        {
            return this.alum.sosMenor(comparacion);
        }

        /* public bool sosMenor(IAlumno comparacion)
        {
            return this.alum.sosMenor(comparacion);
        } */
    }
}