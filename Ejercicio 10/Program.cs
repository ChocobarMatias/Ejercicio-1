using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.WriteLine();
            Console.WriteLine("++++++++++++++++++++++++++++++++++++++++++++++++++++++++");
            Console.WriteLine(" Sumas de los primeros 50 numeros enteros multiplos de 3");
            Console.WriteLine("++++++++++++++++++++++++++++++++++++++++++++++++++++++++");
            Console.WriteLine();
            int suma = 0;

            for (int i = 1; i <= 50; i++)
            {
               
                Console.WriteLine($" . {i}");
                if (i % 2 == 0)
                {
                    if (i % 3 == 0)
                    {
                        suma += i;
                        Console.WriteLine($" . Suma = {suma}");
                    }
                }

            }


            Console.WriteLine();
            Console.WriteLine(" ******************");
            Console.WriteLine(" | Fin del Proceso |");
            Console.WriteLine(" ******************");
            Console.ReadKey();
        }
    }
}
