using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num;
            Console.Write("Ingrese el número: ");
            num = int.Parse(Console.ReadLine());
            duplicar(in num);
        }

        private static void duplicar(in int num)
        {
            Console.WriteLine("El valor original: " + num);
            Console.WriteLine("El valor duplicado es: " + num * 2);
        }
    }
}
