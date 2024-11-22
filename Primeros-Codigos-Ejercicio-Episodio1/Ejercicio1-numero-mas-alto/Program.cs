using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1_numero_mas_alto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, num3, resultado;


            Console.WriteLine("Ingresa el primer número:");
            num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ingresa el segundo número:");
            num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ingresa el tercer número:");
            num3 = Convert.ToInt32(Console.ReadLine());

            resultado = Comparar(num1, num2, num3);

            Console.WriteLine("El resultado es: " + resultado);


        }

        public static int Comparar(int num1, int num2, int num3)
        {
            if (num1 > num2 && num1 > num3)
            {
                Console.WriteLine("El número 1 es el más grande: {0}", num1);
                return num1;
            }
            else if (num2 > num1 && num2 > num3)
            {
                Console.WriteLine("El número 2 es el más grande: {0}", num2);
                return num2;
            }
            else if (num3 > num1 && num3 > num2)
            {
                Console.WriteLine("El número 3 es el más grande: {0}", num3);
                return num3;
            }
            else
            {
                Console.WriteLine("No hay un único número mayor, pueden ser iguales.");
                return -1; // Devuelve un valor especial para indicar igualdad
            }
        }


    }
}
