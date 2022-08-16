using System;

namespace condiciones_y_funciones._6
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, num2;
            Console.WriteLine("Introduzca un número: ");
            num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduzca otro número: ");
            num2 = int.Parse(Console.ReadLine());

            Console.WriteLine("La suma es: " + suma(num1, num2));
            Console.WriteLine("La resta es: " + resta(num1, num2));
            Console.WriteLine("La multiplicación es: " + multi(num1, num2));
            Console.WriteLine("La división es: " + div(num1, num2));

            static int suma(int num1, int num2)
            {
                var suma = num1 + num2;
                return suma;
            }
            static int resta(int num1 , int num2)
            {
                return (num1 - num2);
            }
            static int multi(int num1, int num2) => num1 * num2;

            static double div(int num1 , int num2)
            {
                double numd1 = Convert.ToDouble(num1);
                double numd2 = Convert.ToDouble(num2);
                return numd1 / numd2;
            }
        }
    }
}
