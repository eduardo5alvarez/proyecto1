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
            Console.WriteLine("Pulse cualquier tecla para conseguir tu pasaporte");
            Console.ReadKey();
            Console.WriteLine("Introduce tu nombre");
            yourName = Console.ReadLine();

            Console.WriteLine($"Hola, {yourName} has sido enlistado en las fuerzas terrestres, creias que era asi de facil conseguir la nacionalidad morito?.");
            Console.WriteLine("Pulse cualquier tecla para continuar");
            Console.ReadKey();
            Console.WriteLine("Desterrando a jovenlandia...");
        }
    }
}