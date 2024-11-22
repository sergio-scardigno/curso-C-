//using System;


//namespace CicloFor
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {

//            var valores = new[] { 10, 20, 30, 40, 50, 60, 70, 80, 90, 100 };

//            var contador = 0;

//            for (int i = 0; i < 5; i++) { 

//                Console.WriteLine(valores[i]);
//                contador++;
//                Console.WriteLine(contador);
//            }

//        }
//    }
//}


using System;
using System.Collections.Generic;
using CicloFor.Controllers; // Importa el namespace donde está Persona

namespace CicloFor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Lista de objetos Persona
            var personas = new List<Persona>
            {
                new Persona("Juan", 25),
                new Persona("Ana", 30),
                new Persona("Carlos", 35),
                new Persona("Laura", 28),
                new Persona("Pedro", 22),
                new Persona("Sofía", 40),
                new Persona("Sergio", 42)
            };

            var contador = 0;

            foreach (var persona in personas)
            {
                if (contador >= 10) break;

                Console.WriteLine($"Nombre: {persona.Nombre}, Edad: {persona.Edad}");
                contador++;
                Console.WriteLine($"Contador: {contador}\n");
            }
        }
    }
}
