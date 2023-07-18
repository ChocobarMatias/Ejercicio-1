using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.WriteLine();
            Console.WriteLine("++++++++++++++++++++++++++");
            Console.WriteLine(" Ciclo do while del 1 al N");
            Console.WriteLine("++++++++++++++++++++++++++");
            Console.WriteLine();
            int n = 0;
            int contador = 0;
            Console.Write(" Ingresar el numero N = ");
            n = Int32.Parse(Console.ReadLine());
            do
            {
                contador++;
                Console.WriteLine();
                Console.WriteLine(" . " + contador);

            } while (contador!= n);

            Console.WriteLine();
            Console.WriteLine(" ******************");
            Console.WriteLine(" | Fin del Proceso |");
            Console.WriteLine(" ******************");
            Console.ReadKey();
        }
    }
}
