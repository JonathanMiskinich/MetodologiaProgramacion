using Clases.Aulas;
using Funciones;
using IAlumnos;
using IAlumnos.Compuesto;
using IColeccionable.Pilas;
using ObtencionDeDatos;
using PCommand;
using PFactoryMethod.CreadorAlumnos;
using PIterator;

namespace PComposite
{
    public class CompositeRun
    {
        public static void Run()
        {
            Pila pila = new Pila();
            Aula aula = new Aula();

            pila.SetOrdenInicio(new OrdenInicio(aula));
            pila.SetOrdenLlegaAlumno(new OrdenLlegaAlumno(aula));
            pila.SetOrdenAulaLlena(new OrdenAulaLlena(aula));

            Helper.LlenarAlumnos(pila, "4");

            IIterator iterador = pila.CrearIterador();
            CreadorAlumno fabrica = new();
            
            iterador.Primero();
            while (!iterador.Fin())
            {
                for(int i = 0; i < 2; i++)
                {
                    AlumnoCompuesto alumCompuesto = (AlumnoCompuesto)iterador.Actual();
                    alumCompuesto.AgregarHijo((IAlumno)fabrica.Crear("1", GeneradorDatosAzar.GetInstancia()));
                }
                iterador.Siguiente();
            }

            Helper.LlenarAlumnos(pila, "2");
        }
    }
}