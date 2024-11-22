using System;

namespace Calculadora
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float a, b, resultado = 0;
            int opcion;

            do
            {
                Console.WriteLine("1: Suma");
                Console.WriteLine("2: Resta");
                Console.WriteLine("3: División");
                Console.WriteLine("4: Multiplicación");
                Console.WriteLine("5: Salir");

                Console.WriteLine("Elija una opción:");
                opcion = Convert.ToInt32(Console.ReadLine());

                if (opcion >= 1 && opcion <= 4)
                {
                    Console.WriteLine("Ingrese el primer número:");
                    a = Convert.ToSingle(Console.ReadLine());

                    Console.WriteLine("Ingrese el segundo número:");
                    b = Convert.ToSingle(Console.ReadLine());

                    switch (opcion)
                    {
                        case 1:
                            resultado = suma(a, b);
                            break;

                        case 2:
                            resultado = a - b;
                            break;

                        case 3:
                            if (b != 0)
                            {
                                resultado = a / b;
                            }
                            else
                            {
                                Console.WriteLine("No se puede dividir por cero.");
                                continue;
                            }
                            break;

                        case 4:
                            resultado = a * b;
                            break;
                    }

                    Console.WriteLine("El resultado es: {0}", resultado);
                }
                else if (opcion != 5)
                {
                    Console.WriteLine("Opción no válida, intente de nuevo.");
                }

            } while (opcion != 5);

            Console.WriteLine("Saliendo del programa...");
        }

        static float suma(float a, float b)
        {
            return a + b;
        }
    }
}
