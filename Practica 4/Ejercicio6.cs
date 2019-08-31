using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_4
{
    class Ejercicio6
    {
        static void Main(string[] args)
        {
            int conta = 1, canti, aux = 0;
            double costo = 0;

            Console.WriteLine("Ingrese la cantidad de tiendas: ");
            canti = Convert.ToInt32(Console.ReadLine());
            /*while (canti != 0 && conta!=0 )
            {

                do
                {
                    Console.WriteLine("Favor ingresar el costo de la venta de la sucursal");
                    costo = Convert.ToDouble(Console.ReadLine());

                    if (costo == 0)
                    {
                        conta--;
                    }


                } while (costo !=0);*/
            while (canti != 0)
            {
                do
                {
                    for (int i = 1; i <= canti; i++)
                    {
                        for (int n = 1; n <= 3; n++)
                        {
                            Console.WriteLine("Favor ingresar el monto de la venta N°{0} de la sucursal N°{1}", n, i);
                            costo = Convert.ToDouble(Console.ReadLine());
                            if (costo == 0)
                            {
                                n = 4;
                                i = canti + 1;
                            }
                        }
                    }
                    conta--;
                } while (conta != 0);
                canti = 0;
            }
        }
    }
}
