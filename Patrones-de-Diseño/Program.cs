using Strategy;
using Iterator;
using PObserver;
using PAdapter;
using Decorator;
using Proxy;
using PCommand;
using PComposite;

namespace Program
{
    public class Program
    {
        static void Main(string[] args)
        {
            Menu();
            Console.Write("Ingrese una opcion: ");
            string opc = Console.ReadLine();

            while (opc  != "0")
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
                        PDecoratorRun.Run();
                        break;
                    case "7":
                        ProxyRun.Run();
                        break;
                    case "8":
                        CommandRun.Run();
                        break;
                    case "9":
                        CompositeRun.Run();
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
            Console.WriteLine("5 - Patron Adapter");
            Console.WriteLine("6 - Patron Decorator");
            Console.WriteLine("7 - Patron Proxy con Decorator");
            Console.WriteLine("8 - Patron Command");
            Console.WriteLine("9 - Patron Composite");
            Console.WriteLine("0 - Salir");
            Console.WriteLine("---------");
        }
    }
}