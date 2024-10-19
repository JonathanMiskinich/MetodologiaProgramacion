using Practica_n4;
using Practicas;
using Strategy;
using Iterator;
using PObserver;
using PAdapter;

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
                        StrategyRun.Run();
                        break;
                    case "2":
                        IteratorRun.Run();
                        break;
                    case "3":
                        IteratorRun.ConStrategy();
                        break;
                    case "4":
                        ObserverRun.Run();
                        break;
                    case "5":
                        AdapterRun.Run();
                        break;
                    case "6":
                        DecoratorRun.Run();
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
            Console.WriteLine("1 - Patron Strategy.");
            Console.WriteLine("2 - Patron Iterator.");
            Console.WriteLine("3 - Patron Iterator Con Strategy.");
            Console.WriteLine("4 - Patron Observer.");
            Console.WriteLine("6 - Patron Compuesto - Crear Clase");
            Console.WriteLine("9 - Salir");
            Console.WriteLine("---------");
        }
    }
}