using System;

namespace condiciones_y_funciones._3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese el número a evaluar: ");
            int multiplo = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el número del límite: ");
            int limite = int.Parse(Console.ReadLine());

            for (int i = 0; i <= limite; i++)
            {
                if (i % multiplo == 0)
                {
                    Console.Write(i + " ");
                }
            }
        }
    }
}