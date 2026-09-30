using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1 suma
            int num1, num2;
            Console.Write("Ingrese un número: ");
            num1 = int.Parse(Console.ReadLine());
            Console.Write("Ingrese otro número: ");
            num2 = int.Parse(Console.ReadLine());
            Console.WriteLine("La suma de los números originales es: " + suma1(num1, num2));

            //2 Suma ref
            int num3, num4;
            Console.Write("Ingrese un número: ");
            num3 = int.Parse(Console.ReadLine());
            Console.Write("Ingrese otro número: ");
            num4 = int.Parse(Console.ReadLine());
            suma2(ref num3, num4);
            Console.WriteLine("La suma de los números por referencia es: " + num3);

            //3 Suma out
            int num5, num6;
            Console.Write("Ingrese un número: ");
            num5 = int.Parse(Console.ReadLine());
            Console.Write("Ingrese otro número: ");
            num6 = int.Parse(Console.ReadLine());
            suma3(num5, num6, out int res);
            Console.WriteLine("La suma de los números por out es: " + res);
        }

        private static int suma1(int num1, int num2)
        {
            return num1 + num2;
        }

        private static void suma2(ref int num, int cantidad)
        {
            num += cantidad;
        }

        private static void suma3(int num5, int num6, out int res)
        {
            res = num5 + num6;
        }
    }
}
