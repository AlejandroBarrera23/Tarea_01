using System;
using Tarea_01.Ejercicios;

class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            // MENU PRINCIPAL CON LOS 3 EJERCICIOS DE LA TAREA
            Console.WriteLine("\n================================");
            Console.WriteLine("TAREA #1");
            Console.WriteLine("================================");
            Console.WriteLine("\nSelecciona un ejercicio para ejecutar:\n");
            Console.WriteLine("1. Ejercicio 1");
            Console.WriteLine("2. Ejercicio 2");
            Console.WriteLine("3. Ejercicio 3");
            Console.WriteLine("0. Salir");

            // LEER LA OPCIÓN SELECCIONADA
            string opcion = Console.ReadLine();

            // EJECUTAR LA OPCIÓN SELECCIONADA
            switch (opcion)
            {
                case "1":
                    Ejercicio1.Menu();
                    break;
                case "2":
                    Ejercicio2.Ejecutar();
                    break;
                case "3":
                    Ejercicio3.Ejecutar();
                    break;
                case "0":
                    Console.WriteLine("Fin del programa");
                    return;
                default:
                    Console.WriteLine("Error: Opcion incorrecta. Intenta nuevamente");
                    break;
            }
        }
    }
}
