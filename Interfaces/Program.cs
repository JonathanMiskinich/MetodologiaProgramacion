using Practica3_14;
using Practica2_10;

namespace Program
{
    public class Program
    {
        static void Main(string[] args)
        {
            Menu();
            Console.Write("Ingrese una opcion: ");
            string opc = Console.ReadLine();

            while (opc  != "3")
            {
                switch (opc)
                {
                    case "1":
                        Practica_2.Run();
                        break;
                    case "2":
                        Practica_3.Run();
                        break;
                    default:
                        break;
                }
            }
            
        }
        static void Menu()
        {
            Console.WriteLine("Menu de opciones:");
            Console.WriteLine("1 - Estrategias comparacion Alumnos (Practica 2)");
            Console.WriteLine("2 - Patron Observer Alumno / Profesor (Practica 3)");
            Console.WriteLine("3 - Salir");
            Console.WriteLine("---------");
        }
    }
}