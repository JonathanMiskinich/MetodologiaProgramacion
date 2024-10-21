using IAlumnos;
using IAlumnos.Compuesto;
using IColeccionable.Pilas;
using ObtencionDeDatos;
using PFactoryMethod.CreadorAlumnos;
using PIterator;

namespace PChainOfResponsability
{
    public class ChainRun
    {
        // Muestra el dato por pantalla o uno aleatorio en caso de no cumplir con ciertas condiciones
        public static void Run()
        {
            LectorDeDatos lector = new();
            GeneradorDatosAzar datosAzar = GeneradorDatosAzar.GetInstancia();

            lector.SetManejador(datosAzar);

            Console.Write("Ingrese un numero:");
            Console.WriteLine(lector.ObtenerNumero(100));

            Console.WriteLine("Ingrese un texto cualquiera: ");
            Console.WriteLine(lector.ObtenerCadena(10));
        }

        public static void ConSingleton()
        {
            CreadorAlumno fabrica = new();
            Pila pila = new();

            LectorDeDatos lector = new();
            GeneradorDatosAzar datosAzar = GeneradorDatosAzar.GetInstancia();
            LectorDeArchivos lectorArchivos = LectorDeArchivos.GetInstancia();

            lectorArchivos.SetManejador(datosAzar);
            lector.SetManejador(lectorArchivos);
            
            for (int i = 0; i < 5; i++)
            {
                pila.Agregar(fabrica.Crear("1", datosAzar));
            }

            Console.WriteLine("Ingrese los datos del alumno: (DNI, Legajo y promedio)");
            pila.Agregar(fabrica.Crear("2", lector));

            Console.WriteLine("Ingrese los datos del alumno: (DNI, Legajo y promedio)");
            pila.Agregar(fabrica.Crear("2", lector));

            AlumnoCompuesto alum = new();

            for (int i = 0; i < 5; i++)
            {
                alum.AgregarHijo((IAlumno)fabrica.Crear("1", lectorArchivos));
            }

            pila.Agregar(alum);

            IIterator iterador = pila.CrearIterador();

            iterador.Primero();
            while(!iterador.Fin())
            {
                Console.WriteLine(iterador.Actual().ToString());
                iterador.Siguiente();
            }
        }
    }
}