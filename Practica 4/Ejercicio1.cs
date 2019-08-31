using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_4
{
    class Ejercicio1
    {
        static void Main(string[] args)
        {
            double pago, totalPago = 0.0;
            for (int n = 1; n <= 20; n++)
            {
                pago = 0.0;
                Console.WriteLine("Ingrese el sueldo del empleado N°{0}", n);
                pago = Convert.ToDouble(Console.ReadLine());
                totalPago += pago;
            }
            Console.WriteLine("Total de sueldos en la empresa: {0:C2}", totalPago);
            Console.WriteLine("Promedio de sueldos dentro de la empresa: {0:C2}", totalPago / 20);
            Console.ReadKey();
        }
    }
}
