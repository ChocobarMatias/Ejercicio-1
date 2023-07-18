using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.WriteLine();
            Console.WriteLine("++++++++++++++++++++++++++++++++++++++");
            Console.WriteLine(" Numeros enteros entre A = 10 y B = 20");
            Console.WriteLine("++++++++++++++++++++++++++++++++++++++");
            Console.WriteLine();
            const int A = 10;
            const int B = 20;
            int numero = 0;
            bool bandera = false;
            int contador = 0;
            while (bandera == false)
            {
                Console.WriteLine();
                Console.Write(" Ingresar un numero entero = ");
                numero = Int32.Parse(Console.ReadLine());
                if (numero < A || numero > B)
                {
                    contador++;
                }
                else
                {
                    bandera = true;
                }
            }
            Console.WriteLine();
            Console.WriteLine(" Numero Valido ingresado");
            Console.WriteLine($" Intentos no validos = {contador}");
            Console.WriteLine();
            Console.WriteLine(" ******************");
            Console.WriteLine(" | Fin del Proceso |");
            Console.WriteLine(" ******************");
            Console.ReadKey();
        }
    }
}
