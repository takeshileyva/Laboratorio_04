using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1, num2;
            Console.Write("Ingrese el número 1: ");
            num1 = int.Parse(Console.ReadLine());
            Console.Write("Ingrese el número 2: ");
            num2 = int.Parse(Console.ReadLine());
            resultado(num1, num2, out int mul, out int suma);
            Console.WriteLine("La multiplicación de ambos números: " + mul);
            Console.WriteLine("La suma de ambos números: " + suma);
        }

        private static void resultado(int num1, int num2, out int mul, out int suma)
        {
            mul = num1 * num2;
            suma = num1 + num2;
        }
    }
}
