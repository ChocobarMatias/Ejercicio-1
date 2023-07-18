using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.WriteLine();
            Console.WriteLine("++++++++++++++++++++++++++++++++++++++++++++++++++");
            Console.WriteLine(" 10 primeros numeros mayores a 2500 multiplos de 6");
            Console.WriteLine("++++++++++++++++++++++++++++++++++++++++++++++++++");
            Console.WriteLine();
            int numero = 2500;
            int contador = 0;

            do
            {
                numero++;
            if (numero % 6 == 0)
            {
                contador++;
                Console.WriteLine($"{contador}) . {numero}");
            }
            } while (contador != 10);
        
            Console.WriteLine();
            Console.WriteLine(" ******************");
            Console.WriteLine(" | Fin del Proceso |");
            Console.WriteLine(" ******************");
            Console.ReadKey();
        }
    }
}
