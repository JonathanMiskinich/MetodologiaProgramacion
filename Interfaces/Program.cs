using Clases.Practica_1;

namespace Program
{
    public class Program
    {
        static void Main(string[] args)
        {
            Numero num = new Numero(10);
            Numero num1 = new Numero(10);
            Numero num2 = new Numero(3);

            Console.WriteLine(num.sosIgual(num1));
            Console.WriteLine(num.sosIgual(num2));
            Console.WriteLine(num.sosMayor(num2));
            Console.WriteLine(num.sosMenor(num2));

            Console.WriteLine(num2.sosMenor(num));
        }
    }
}