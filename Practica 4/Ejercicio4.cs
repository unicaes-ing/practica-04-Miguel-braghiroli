using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_4
{
    class Ejercicio4
    {
        static void Main(string[] args)
        {
            double venta, dinero = 0;
            int conta = 0;
            do
            {
                Console.WriteLine("Favor ingrese la cantidad de ventas realizadas: ");
                venta = Convert.ToDouble(Console.ReadLine());

                if (venta == -1)
                {
                }
                else
                {
                    dinero += venta;
                    conta++;
                }
            } while (venta != -1);
            Console.WriteLine("Ingrese la cantidad de ventas: {0:N2}", conta);
            Console.WriteLine("Dinero ganado en las ventas: {0:C2}", dinero);
            Console.WriteLine("Ventas realizadas + 5% de bono: {0:C2}",(dinero + (dinero * 0.05)));
            Console.ReadKey();
        }
    }
}
