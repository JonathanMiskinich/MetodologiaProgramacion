using Interfaces.Clases.Persona;
using Interfaces_Practica1;
using Interfaces.PStrategy_Comparacion;
using PObserver.Suscriptora;
using PDecorator.MostrarCalificacion;

namespace Clases.Alumnos
{
    public class Alumno : Persona, ISuscriptora, IMostrarCalificacion
    {
        private int legajo;
        private float promedio;
        private Comparacion metodoComparar;
        private int calificacion;

        //COnstructores
        public Alumno(string nombre, int dni, int legajo, float promedio) : base(nombre, dni)
        {
            this.legajo = legajo;
            this.promedio = promedio;
            this.calificacion = 0;
        }
        // Getters and Setters
        public override string getNombre
        {
            get { return this.getNombre; }
        }
        public int getLegajo
        {
            get {return this.legajo;}
        }
        public float getPromedio
        {
            get { return this.promedio; }
        }
        public int getCalificacion
        {
            get{ return this.calificacion; }
        }
        public void setCalificacion(int calif)
        {
            this.calificacion = calif;
        }
        //Strategy
        public void setMetodoComparar(Comparacion comparar)
        {
            this.metodoComparar = comparar;
        }

        public bool Comparacion(Alumno alum)
        {
            return metodoComparar.ComparacionIguales(this, alum);
        }
        //Interfaces
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
