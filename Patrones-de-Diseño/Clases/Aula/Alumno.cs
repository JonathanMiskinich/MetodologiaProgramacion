using Interfaces.Clases.Persona;
using Alumnos.Comparaciones;
using PObserver.Suscriptora;

namespace IAlumnos.Regular
{
    public class Alumno : Persona, ISuscriptora, IAlumno
    {
        private int legajo;
        private float promedio;
        private int calificacion;
        private Comparacion st = null;

        //COnstructores
        public Alumno(string nombre, int dni, int legajo, float promedio, Comparacion st = null) : base(nombre, dni)
        {
            this.legajo = legajo;
            this.promedio = promedio;
            this.calificacion = 0;
            this.st = st;
        }
        // Getters and Setters
        public string getNombre()
        {
            return this.nombre;
        }
        public int getDni()
        {
            return this.dni;
        }
        public int getLegajo()
        {
            return this.legajo;
        }
        public float getPromedio()
        {
            return this.promedio;
        }
        public int getCalificacion()
        {
            return this.calificacion;
        }
        public void setCalificacion(int calif)
        {
            this.calificacion = calif;
        }
        //Strategy
        public void setMetodoComparar(Comparacion comparar)
        {
            this.st = comparar;
        }

        
        //Interfaces
        public bool sosIgual(IAlumno comparacion)
        {
            return st.Iguales(this, comparacion);
        }

        public bool sosMenor(IAlumno comparacion)
        {
            return st.MenorQue(this, comparacion);
        }

        public bool sosMayor(IAlumno comparacion)
        {
            return st.MayorQue(this, comparacion);
        }
        //Metodos
        public override string ToString()
        {
            return $"Nombre: {this.nombre}\nDni: {this.dni}\nLegajo: {this.legajo}\nPromedio: {this.promedio}";
        }
        public void PrestarAtencion()
        {
            Console.WriteLine("Prestando Atencion.");
        }
        public void Distraerse()
        {
            int num =new Random().Next(3);
            switch (num)
            {
                case 0: 
                    Console.WriteLine("Mirando el Celular.");
                    break;
                case 1:
                    Console.WriteLine("Dibujando en el margen de la carpeta.");
                    break;
                default:
                    Console.WriteLine("Tirando un avion de papel.");
                    break;
            }
        }

        public void Update(bool b)
        {
            if (b)
                this.PrestarAtencion();
            else
                this.Distraerse();
        }
        public virtual int ResponderPregunta(int pregunta)
        {
            return new Random().Next(1,4);
        }
        public string MostrarCalificacion()
        {
            return $"{this.nombre}\t{this.calificacion.ToString()}";
        }
    }
}
