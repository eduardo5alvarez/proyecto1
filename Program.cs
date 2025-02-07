using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string? yourName = null;   

            Console.WriteLine("Bienvenido a ESPAÑA");
            Console.WriteLine("Pulse cualquier tecla para entrar al país");
            Console.ReadKey();
            Console.WriteLine("Introduce tu nombre y tu DNI");
            yourName = Console.ReadLine();

            Console.WriteLine($"Hola, {yourName} has sido enlistado en las fuerzas terrestres, espabila y no des tu información a cualquiera.");
            Console.WriteLine("Pulse cualquier tecla para continuar");
            Console.ReadKey();
            Console.WriteLine("cargando...");
        }
    }
}
