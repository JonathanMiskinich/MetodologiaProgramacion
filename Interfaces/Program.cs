using Clases.Numero;
using Clases.Pila;
using Interfaces_Practica1;

namespace Program
{
    public class Program
    {
        static void Main(string[] args)
        {
            Pila numeros = new Pila(5);

            Numero num0 = new Numero(3);
            Numero num1 = new Numero(34);
            Numero num2 = new(10);
            Numero num3 = new Numero(32);
            Numero num4 = new Numero(31);
            Numero num5 = new Numero(8);

            Numero[] numerosArray = {num0, num1, num2, num3, num4, num5};

            for (int i = 0; i < 6; i++)
            {
                try
                {
                    numeros.Agregar(numerosArray[i]);
                    Console.WriteLine("El número {0} fue agregado.", numerosArray[i].VALOR);
                }
                catch (PilaLLenaException)
                {
                    Console.WriteLine("No se puede agregar. Pila llena.");
                }
                catch (System.Exception)
                {
                    Console.WriteLine("");
                }
            }

            Pila numerosPila = new();
            // numerosPila.Apilar(5);
            // numerosPila.Apilar(7);
            // numerosPila.Apilar(87);
            // numerosPila.Apilar(2);
            // numerosPila.Apilar(3245);

            Console.WriteLine("El numero minimo es: {0}", numerosPila.Minimo());
            Console.WriteLine("El numero maximo es: {0}", numerosPila.Maximo());

            numerosPila.DesApilar();
            numerosPila.DesApilar();
            
            Console.WriteLine("El numero minimo es: {0}", numerosPila.Minimo());
            Console.WriteLine("El numero maximo es: {0}", numerosPila.Maximo());

            Console.WriteLine(numerosPila.Top());
            Console.WriteLine("La cantidad de elementos es de: {0}", numerosPila.Cuantos());
            numerosPila.Limpiar();
            try
            {
                Console.WriteLine(numerosPila.Top());
            }
            catch (System.Exception)
            {
                Console.WriteLine();
            }
            Console.WriteLine("La cantidad de elementos es de: {0}", numerosPila.Cuantos());
        }
    }
}