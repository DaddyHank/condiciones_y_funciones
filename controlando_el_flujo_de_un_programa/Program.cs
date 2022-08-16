using System;

namespace controlando_el_flujo_de_un_programa
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcion;
            do
            {
                Console.WriteLine("Ingrese el primer valor: ");
                int num1 = int.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese el segundo valor: ");
                int num2 = int.Parse(Console.ReadLine());

                Console.WriteLine("Por favor, ingrese un número para realizar una operación de las presentadas en el siguiente menú:");
                Console.WriteLine("1) Suma");
                Console.WriteLine("2) Resta");
                Console.WriteLine("3) Multiplicación");
                Console.WriteLine("4) División");
                int option = int.Parse(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        static int suma(int num1, int num2) => num1 + num2;
                        Console.WriteLine("La respuesta a la suma es: " + suma(num1, num2));
                        break;
                    case 2:
                        static int resta(int num1, int num2) => num1 - num2;
                        Console.WriteLine("La respuesta a la resta es: " + resta(num1, num2));
                        break;
                    case 3:
                        static int multi(int num1, int num2) => num1 * num2;
                        Console.WriteLine("La respuesta a la multiplicación es: " + multi(num1, num2));
                        break;
                    case 4:
                        static double division(int num1, int num2)
                        {
                            double numd1 = Convert.ToDouble(num1);
                            double numd2 = Convert.ToDouble(num2);
                            return numd1 / numd2;
                        }
                        Console.WriteLine("La respuesta a la división es: " + division(num1, num2));
                        break;
                    default:
                        Console.WriteLine("Esta opción está fuera de los parámetros establecidos");
                        break;
                }
                Console.WriteLine("presione nuevamente un número para realizar otra operacion. Sino, presione 1 para salir del programa");
                opcion = int.Parse(Console.ReadLine());
            } while (opcion != 1);
        }
    }
}
