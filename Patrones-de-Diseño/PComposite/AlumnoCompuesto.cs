using Interfaces.PStrategy_Comparacion;
using Interfaces_Practica1;
using Interfaz.IAlumnos;

namespace Alumnos
{
    public class AlumnoCompuesto : IAlumno
    {
        private List<IAlumno> hijos = null;

        public AlumnoCompuesto()
        {
            this.hijos = new();
        }

        //METODOS

        public List<IAlumno> GetAlumnos()
        {
            return this.hijos;
        }

        public void AgregarHijo(IAlumno hijo)
        {
            hijos.Add(hijo);
        }

        public void EliminarHijo(IAlumno hijo)
        {
            hijos.Remove(hijo);
        }

        public int getLegajo()
        {
            throw new NotImplementedException();
        }

        public string getNombre()
        {
            string nombres = "";
            
            foreach (IAlumno hijo in hijos)
            {
                nombres += hijo.getNombre() + "\n";
            }

            return nombres;
        }

        public int getCalificacion()
        {
            throw new NotImplementedException();
        }

        public void setCalificacion(int calif)
        {
            foreach (IAlumno hijo in hijos)
            {
                hijo.setCalificacion(calif);
            }
        }

        public float getPromedio()
        {
            throw new NotImplementedException();
        }

        public string MostrarCalificacion()
        {
            string calificaciones = "";

            foreach (IAlumno hijo in hijos)
            {
                calificaciones += hijo.MostrarCalificacion() + "\n";
            }

            return calificaciones;
        }

        public int ResponderPregunta(int pregunta)
        {
            Dictionary<int,int> respuestas = new();
            
            foreach (IAlumno hijo in hijos)
            {
                int number = hijo.ResponderPregunta(pregunta);
                if (respuestas.TryGetValue(number, out int value))
                {
                    respuestas[number] = ++value;
                }else
                {
                    respuestas[number] = 1;
                }
            }

            int maxRepeticiones = 0;
            int respuestaMasRepetida = 0;

            foreach (var valor in respuestas)
            {
                if (valor.Value > maxRepeticiones)
                {
                    maxRepeticiones = valor.Value;
                    respuestaMasRepetida = valor.Key;
                }
            }

            return respuestaMasRepetida;
        }

        public int getDni()
        {
            throw new NotImplementedException();
        }

        public void setMetodoComparar(Comparacion comparar)
        {
            foreach (IAlumno hijo in hijos)
            {
                hijo.setMetodoComparar(comparar);
            }
        }

        public bool sosIgual(Comparable comparacion)
        {
            bool flag = false;

            foreach (IAlumno hijo in hijos)
            {
                if (hijo.sosIgual(comparacion))
                {
                    flag = true;
                    break;
                }
            }

            return flag;
        }

        public bool sosMenor(Comparable comparacion)
        {
            bool flag = true;

            foreach (IAlumno hijo in hijos)
            {
                if (!hijo.sosMenor(comparacion))
                {
                    flag = false;
                    break;
                }
            }

            return flag;
        }

        public bool sosMayor(Comparable comparacion)
        {
            bool flag = true;

            foreach (IAlumno hijo in hijos)
            {
                if (!hijo.sosMayor(comparacion))
                {
                    flag = false;
                    break;
                }
            }

            return flag;
        }
    }
}