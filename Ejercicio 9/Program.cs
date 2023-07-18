using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.WriteLine();
            Console.WriteLine("+++++++++++++++++++++++++++++++++++++++++++++++++++++++++");
            Console.WriteLine(" Primeros numeros enteros mayores a B y son multiplo de M");
            Console.WriteLine("+++++++++++++++++++++++++++++++++++++++++++++++++++++++++");
            Console.WriteLine();
            int n = 0;
            int b = 0;
            int m = 0;
            Console.Write(" Ingresar el numero entero B = ");
            b = Int32.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.Write(" Ingresar el numero entero N = ");
            n = Int32.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.Write(" Ingresar el numero entero M = ");
            m = Int32.Parse(Console.ReadLine());
            Console.WriteLine();
            if (n > 0 && b > 0 && m > 0)
            {
                for (int i = 0; i < n; i++)
                {
                    if (i > b)
                    {
                            if (i % m == 0)
                            {
                                Console.WriteLine($" . {i}");
                            }
                     }
                }
            }
            else
            {
                Console.WriteLine(" Los numeros ingresados tienen que ser mayor que cero");
            }

            Console.WriteLine();
            Console.WriteLine(" ******************");
            Console.WriteLine(" | Fin del Proceso |");
            Console.WriteLine(" ******************");
            Console.ReadKey();
        }
    }
}
