using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Ejercicio 1

            Console.WriteLine("Ingrese el primer número: ");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el segundo número: ");
            int num2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el tercer número: ");
            int num3 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el cuarto número: ");
            int num4 = int.Parse(Console.ReadLine());
            Console.WriteLine("La suma de todos es");
            Console.WriteLine(num1 + num2 + num3 + num4);
            Console.WriteLine("El promedio de todos es");
            Console.WriteLine((num1 + num2 + num3 + num4) / 4);

            Console.WriteLine("Ingrese el primer número: ");

        }
    }
}
