using Interfaces_Practica1;
using Clases.Numero;
using Clases.Persona;

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
    }
}