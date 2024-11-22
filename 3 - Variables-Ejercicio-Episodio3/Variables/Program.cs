using System;
using System.Diagnostics.CodeAnalysis;

namespace Variables1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //byte num1 = 12;
            //byte num2 = 33;

            //if (num1 == 0) { Console.WriteLine("No se puede dividir por cero"); } 

            //else if( num1 < 0 ) { Console.WriteLine("No se puede dividir por un numero negativo"); }

            //else {
            //float result = (float)num1 / num2;

            //Console.WriteLine("La division es {0}",result); }



            //Console.WriteLine("El resultado de las suma de {0} + {1} = {2}",num1,num2,result);


            //Prueba 2

            //string nombre;
            //int edad;
            //double estatura;

            //Console.WriteLine("Ingrese su nombre: ");
            //nombre = Console.ReadLine();

            //Console.WriteLine("Ingrese su edad: ");
            //edad = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("Ingrese su estatura: ");
            //estatura = Convert.ToDouble(Console.ReadLine());

            //Console.WriteLine("Su nombre es {0} y su edad es {1} y mi estatura {2}", nombre, edad, estatura);

            //Console.ReadKey();

            string nombre;
            int num1, num2, suma;

            Console.WriteLine("Ingrese su nombre:");
            nombre = Console.ReadLine();
            Console.WriteLine("Bienvenido {0}", nombre);

            Console.WriteLine("Ingrese un los numeros a sumar:");

            num1 = Convert.ToInt32(Console.ReadLine());
            num2 = Convert.ToInt32(Console.ReadLine());

            suma = num1 + num2;

            Console.WriteLine("El resultado es {0}", suma);

        }
    }
}
