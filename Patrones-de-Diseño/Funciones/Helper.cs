using Interfaces_Practica1;
using Clases.Numero;
using Interfaces.Clases.Persona;
using Clases.Alumnos;
using PIterator;
using Alumnos.Comparacion;
using Clases.Profesor;
using PFactoryMethod.CreadorAlumnos;
using Interfaz.IAlumnos;

namespace Funciones
{
    public static class Helper
    {
        public static void Llenar(Coleccionable coleccionable)
        {
            for (int i = 0; i < 20; i++)
            {
                Numero num = new Numero((sbyte)new Random().Next(-128,127));
                coleccionable.Agregar(num);
            }
        }
        public static void Informar(Coleccionable lista)
        {
            Console.WriteLine("La cantidad total de elementos del coleccionable es de: {0}", lista.Cuantos());
            Console.WriteLine("El valor máximo del coleccionable es de: {0}", lista.Maximo().ToString());
            Console.WriteLine("El valorr minimo del coleccionable es de: {0}", lista.Minimo().ToString());
        }

        public static string NombreAzar()
        {
            List<string> nombres = new List<string>
            {
                "Mateo", "Sofía", "Alejandro", "Valentina", "Lucas",
                "Martina", "Nicolás", "Camila", "Daniel", "Isabella",
                "Gabriel", "Emma", "Diego", "María", "Javier",
                "Lucía", "Andrés", "Catalina", "Samuel", "Julieta"
            };
            return nombres[new Random().Next(20)];
        }

        public static void LlenarPersonas(Coleccionable lista)
        {
            for (int i = 0; i < 20; i++)
            {
                Persona p = new Persona(NombreAzar(), i);
                lista.Agregar(p);
            }
        }

        public static void LlenarAlumnos(Coleccionable coleccionable, string opcion)
        {
            CreadorAlumno fabrica = new();
            for (int i = 0; i < 20; i++)
            {
                IAlumno alum = (IAlumno)fabrica.CrearAleatorio(opcion);
                coleccionable.Agregar(alum);
            }
        }
        public static void ImprimirElementos(Coleccionable coleccionable) 
        {
            IIterator iterador = coleccionable.CrearIterador();
            iterador.Primero();

            while (!iterador.Fin())
            {
                Console.WriteLine(iterador.Actual().ToString());
                iterador.Siguiente();
            }
        }

        public static void CambiarEstrategia(Coleccionable coleccionable, Comparacion estrategiaNueva)
        {
            IIterator iterador = coleccionable.CrearIterador();
            iterador.Primero();

            while (!iterador.Fin())
            {
                Alumno elem = (Alumno)iterador.Actual();
                elem.setMetodoComparar(estrategiaNueva);
                iterador.Siguiente();
            }
        }

        public static void DictadoDeCLases(Profesor p)
        {
            for (int i = 0; i < 5; i++)
            {
                p.HablarALaClase();
                p.EscribirEnElPizarron();
            }
        }
    }
}