using System;

namespace Almacen
{

    //Un almacén de escritorios hace los siguientes descuentos: si el cliente compra menos de 5 unidades se le da un descuento del 10% sobre la compra; 
    //si el número de unidades es mayor o igual a cinco pero menos de 10 se le otorga un 20%, y si son 10 o más se le da un 40%.
    //Hacer un programa que determine cuánto debe pagar un cliente si el valor de cada escritorio es de $650.000.

    internal class Program
    {
        static void Main(string[] args)
        {
            const int PRECIO = 650; // Precio por escritorio
            int unidades;
            double totalPagar;

            // Solicitar al usuario el número de escritorios
            Console.WriteLine("Ingrese el número de escritorios que desea comprar:");
            unidades = Convert.ToInt32(Console.ReadLine());

            // Calcular el total con el descuento correspondiente
            if (unidades < 5)
            {
                // Descuento del 10%
                totalPagar = CalcularDescuento(unidades, PRECIO, 10);
            }
            else if (unidades >= 5 && unidades < 10)
            {
                // Descuento del 20%
                totalPagar = CalcularDescuento(unidades, PRECIO, 20);
            }
            else
            {
                // Descuento del 40%
                totalPagar = CalcularDescuento(unidades, PRECIO, 40);
            }

            // Mostrar el total a pagar
            Console.WriteLine("El total a pagar por {0} escritorios es: ${1:N0}", unidades, totalPagar);
        }

        // Función para calcular el descuento
        static double CalcularDescuento(int unidades, int precio, int descuento)
        {
            double totalSinDescuento = unidades * precio;
            double descuentoAplicado = totalSinDescuento * descuento / 100;
            return totalSinDescuento - descuentoAplicado;
        }
    }
}

