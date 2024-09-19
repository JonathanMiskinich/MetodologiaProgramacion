using Practica3_14;
using Practica2_10;
using Practica_n4;

namespace Program
{
    public class Program
    {
        static void Main(string[] args)
        {
            Menu();
            Console.Write("Ingrese una opcion: ");
            string opc = Console.ReadLine();

            while (opc  != "9")
            {
                switch (opc)
                {
                    case "1":
                        Practica_2.Run();
                        break;
                    case "2":
                        Practica_3.Run();
                        break;
                    case "3":
                        Practica_4.FormarClase();
                        break;
                    case "4":
                        Practica_4.StudentConDecorator();
                        break;
                    default:
                        break;
                }
                Menu();
                Console.Write("Ingrese una opcion: ");
                opc = Console.ReadLine();
            }

            
        }
        static void Menu()
        {
            Console.WriteLine("Menu de opciones:");
            Console.WriteLine("1 - Estrategias comparacion Alumnos (Practica 2)");
            Console.WriteLine("2 - Patron Observer Alumno / Profesor (Practica 3)");
            Console.WriteLine("3 - Implementacion Patron Adapter (Practica 4 - ejercicio 4)");
            Console.WriteLine("4 - Patron Adapter con Decorator");
            Console.WriteLine("9 - Salir");
            Console.WriteLine("---------");
        }
    }
}