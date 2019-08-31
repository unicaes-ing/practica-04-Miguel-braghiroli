using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_4
{
    class Ejercicio5
    {
        static void Main(string[] args)
        {
            string contra = "1335555", contraseña = "";

            for (int n = 0; n < 3; n++)
            {
                Console.WriteLine("Favor ingrese la contraseña");
                contraseña = Console.ReadLine();
                if (contraseña != contra)
                {
                    Console.WriteLine("Pista: ");
                    Console.WriteLine(contra[n] + "\n");
                }
            }
            Console.WriteLine("Intentos fallidos, ya no tiene intentos");
            Console.ReadKey();
        }
    }
}
