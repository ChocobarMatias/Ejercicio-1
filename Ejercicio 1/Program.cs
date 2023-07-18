using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.WriteLine();
            Console.WriteLine("+++++++++++++++++++++++++++++++++++++");
            Console.WriteLine(" Ingreso de numeros enteros positivos");
            Console.WriteLine("+++++++++++++++++++++++++++++++++++++");
            Console.WriteLine();
            int num1 = 0;
            int num2 = 0;
            int ingreso = 1;
            
            while (ingreso > 0)
            {
                
                Console.WriteLine(" Ingresar primer numero entero = ");
                num1 = Int32.Parse(Console.ReadLine());
                Console.WriteLine(" Ingresar primer numero entero = ");
                num2 = Int32.Parse(Console.ReadLine());
                Console.WriteLine();
                if (num1 < 0 || num1 == 0)
                {
                    if(num2 < 0 || num2 == 0)
                    { ingreso++; }
                }
                else
                {
                    if (num2 < 0 || num2 == 0)
                    { ingreso++; }
                    else
                    {
                        ingreso = 0;
                    }
                }
            }

            Console.WriteLine(" Numero Valido Ingresado");
            Console.WriteLine();
            Console.WriteLine(" ******************");
            Console.WriteLine(" | Fin del Proceso |");
            Console.WriteLine(" ******************");
            Console.ReadKey();
        }
    }
}
