using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJERCICIO1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Convertidor de km";
            Double km, yd, vr, mt, R1, R2;
            Console.WriteLine("Bienvenido. Vamos a convertir km en yardas y varas. Para comenzar:");
            Console.WriteLine("Escriba la cantidad de km que desea convertir:");
            km = Double.Parse(Console.ReadLine());
            mt = 1000 * km;
            yd = 1.09361;
            vr = 1.1963;
            R1 = mt*yd;
            R2 = mt * vr;
            Console.WriteLine("\nLa cantidad en yardas y varas de " + km);
            Console.WriteLine("es igual a: ");
            Console.WriteLine("Yardas = " + R1);
            Console.WriteLine("Varas = " + R2);
            Console.ReadKey();
        }
    }
}
