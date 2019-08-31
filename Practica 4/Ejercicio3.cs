using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_4
{
    class Ejercicio3
    {
        static void Main(string[] args)
        {
            string nombre;
            int conta = 0;

            Console.WriteLine("Favor ingrese un nombre: ");
            nombre = Console.ReadLine();
            for (int n = 0; n < nombre.Length; n++)
            {
                if (nombre[n] == 'a')
                {
                    conta++;
                }
                if (nombre[n] == 'á')
                {
                    conta++;
                }
                if (nombre[n] == 'A')
                {
                    conta++;
                }
                if (nombre[n] == 'Á')
                {
                    conta++;
                }
                if (nombre[n] == 'e')
                {
                    conta++;
                }
                if (nombre[n] == 'é')
                {
                    conta++;
                }
                if (nombre[n] == 'E')
                {
                    conta++;
                }
                if (nombre[n] == 'É')
                {
                    conta++;
                }
                if (nombre[n] == 'i')
                {
                    conta++;
                }
                if (nombre[n] == 'í')
                {
                    conta++;
                }
                if (nombre[n] == 'I')
                {
                    conta++;
                }
                if (nombre[n] == 'Í')
                {
                    conta++;
                }
                if (nombre[n] == 'o')
                {
                    conta++;
                }
                if (nombre[n] == 'ó')
                {
                    conta++;
                }
                if (nombre[n] == 'O')
                {
                    conta++;
                }
                if (nombre[n] == 'Ó')
                {
                    conta++;
                }
                if (nombre[n] == 'u')
                {
                    conta++;
                }
                if (nombre[n] == 'ú')
                {
                    conta++;
                }
                if (nombre[n] == 'U')
                {
                    conta++;
                }
                if (nombre[n] == 'Ú')
                {
                    conta++;
                }
            }
            Console.WriteLine("La cantidad de vocales en el nombre son: {0:N2}", conta);
            Console.ReadKey();
        }
    }
}
