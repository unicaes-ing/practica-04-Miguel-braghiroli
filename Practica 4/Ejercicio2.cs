using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_4
{
    class Ejercicio2
    {
        static void Main(string[] args)
        {
            double nota, asisten;
            int Apro = 0, repro = 0;
            for (int n = 1; n <= 10; n++)
            {
                nota = 0.0;
                asisten = 0.0;
                Console.WriteLine("Ingrese la nota del alumno N°{0}", n);
                nota = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Ingrese el procentaje de asistencia asignado al alumno N°{0}", n);
                asisten = Convert.ToDouble(Console.ReadLine());
                if (nota >= 7.0 && asisten >= 75)
                {
                    Apro++;
                }
                else
                {
                    repro++;
                }
            }
            Console.WriteLine("Alumnos aprobados: {0:N2}", Apro);
            Console.WriteLine("Alumnos reprobados: {0:N2}", repro);
            Console.ReadKey();
        }
    }
}
