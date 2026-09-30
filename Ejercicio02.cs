using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b;
            Console.Write("Ingrese el valor de a: ");
            a = int.Parse(Console.ReadLine());
            Console.Write("Ingrese el valor de b: ");
            b = int.Parse(Console.ReadLine());
            Console.WriteLine("Antes: ");
            Console.WriteLine("a: " + a);
            Console.WriteLine("b: " + b);
            intercambio(ref a, ref b);
            Console.WriteLine("Después: ");
            Console.WriteLine("a: " + a);
            Console.WriteLine("b: " + b);
            Console.ReadKey();
        }

        private static void intercambio(ref int num1, ref int num2)
        {
            int valor_temporal = num1;
            num1 = num2;
            num2 = valor_temporal;
        }
    }
}
