using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.WriteLine();
            Console.WriteLine("+++++++++++++++++++++");
            Console.WriteLine(" Ciclo For del 1 al N");
            Console.WriteLine("+++++++++++++++++++++");
            Console.WriteLine();
            int n = 0;
            Console.Write(" Ingresar el numero N = ");
            n = Int32.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
             
                    Console.WriteLine();
                    Console.WriteLine(" . " + i);
                
            }

            Console.WriteLine();
            Console.WriteLine(" ******************");
            Console.WriteLine(" | Fin del Proceso |");
            Console.WriteLine(" ******************");
            Console.ReadKey();
        }
    }
}
