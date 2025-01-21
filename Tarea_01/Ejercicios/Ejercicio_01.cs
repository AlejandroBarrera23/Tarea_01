using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea_01.Ejercicios
{
    public class Ejercicio1
    {
        public static void Menu()
        {
            // EL MENU FUNCIONA A TRAVES DE UN CICLO WHILE
            while (true)
            {
                // ENUNCIADOS DEL MENU QUE PERMITE ACCEDER A LAS DIFERENTES OPCIONES DEL EJERCICIO
                Console.WriteLine("\n================================");
                Console.WriteLine("EJERCICIO 1");
                Console.WriteLine("================================");
                Console.WriteLine("1. Numeros pares del 1 al 100 (Sin if)");
                Console.WriteLine("2. Numeros pares del 1 al 100 (Con if)");
                Console.WriteLine("3. Numeros del 1 al 50 (FizzBuzz)");
                Console.WriteLine("4. Numeros del 1 al 10 (While)");
                Console.WriteLine("5. Suma de los primeros 100 numeros enteros (While)");
                Console.WriteLine("6. Numeros pares del 1 al 100 (While)");
                Console.WriteLine("0. Regresar");

                // LECTURA DE LA OPCION INGRESADA POR EL USUARIO
                string opcion = Console.ReadLine();

                // A TRAVES DE SWITCH SE PUEDE ESCOGER LAS OPCIONES DEL MENU Y EJECUTAR SEGUN SEA EL CASO
                switch (opcion)
                {
                    case "1":
                        Console.WriteLine("\n================================");
                        Console.WriteLine("Numeros pares del 1 al 100 sin usar if");
                        Console.WriteLine("================================");

                        // CICLO FOR PARA QUE INICIE EN 0 Y SE INCREMENTE DE 2 EN 2 HASTA EL 100 
                        for (int i = 0; i <= 100; i += 2)
                        {
                            Console.WriteLine(i);
                        }
                        break;
                    case "2":
                        Console.WriteLine("\n================================");
                        Console.WriteLine("Numeros pares del 1 al 100 usando if");
                        Console.WriteLine("================================");

                        // CICLO FOR PARA QUE INICIE EN 0 Y SE INCREMENTE DE 1 EN 1 HASTA EL 100
                        for (int i = 0; i <= 100; i++)
                        {
                            // MIENTRAS EL MODULO DE LA DIVISION ENTRE 2 SEA IGUAL A 0 ES UN NUMERO PAR
                            if (i % 2 == 0)
                            {
                                Console.WriteLine(i);
                            }
                        }
                        break;
                    case "3":
                        Console.WriteLine("\n================================");
                        Console.WriteLine("Numeros del 1 al 50 con FizzBuzz");
                        Console.WriteLine("================================");

                        // CICLO FOR PARA QUE INICIE EN 1 Y SE INCREMENTE DE 1 EN 1 HASTA EL 50
                        for (int i = 1; i <= 50; i++)
                        {
                            // MIENTRAS EL MODULO DE LA DIVISION ENTRE 3 SEA IGUAL A 0 Y EL MODULO DE LA DIVISION ENTRE 5 SEA IGUAL A 0, IMPRIMIR FizzBuzz
                            if (i % 3 == 0 && i % 5 == 0)
                            {
                                Console.WriteLine("FizzBuzz");
                            }
                            else if (i % 3 == 0)
                            {
                                Console.WriteLine("Fizz");
                            }
                            else if (i % 5 == 0)
                            {
                                Console.WriteLine("Buzz");
                            }
                            else
                            {
                                Console.WriteLine(i);
                            }
                        }
                        break;
                    case "4":
                        Console.WriteLine("\n================================");
                        Console.WriteLine("Numeros del 1 al 10 usando while");
                        Console.WriteLine("================================");

                        // INICIALIZACION DEL CONTADOR
                        int contador = 1;
                        // CICLO WHILE QUE IMPRIME LOS NUMEROS DEL 1 AL 10
                        while (contador <= 10)
                        {
                            Console.WriteLine(contador);
                            contador++;
                        }
                        break;
                    case "5":
                        Console.WriteLine("\n================================");
                        Console.WriteLine("Suma de los primeros 100 numeros enteros");
                        Console.WriteLine("================================");

                        // INICIALIZACION DE LAS VARIABLES NECESARIAS PARA LA SUMA
                        int suma = 0;
                        contador = 1;
                        // CICLO WHILE QUE CALCULA LA SUMA DE LOS PRIMEROS 100 NUMEROS ENTEROS
                        while (contador <= 100)
                        {
                            suma += contador;
                            contador++;
                        }
                        // IMPRIME LA SUMA CALCULADA
                        Console.WriteLine($"La suma es: {suma}");
                        break;
                    case "6":
                        Console.WriteLine("\n================================");
                        Console.WriteLine("Numeros pares del 1 al 100 usando while");
                        Console.WriteLine("================================");

                        // INICIALIZACION DEL CONTADOR
                        contador = 0;
                        // CICLO WHILE QUE IMPRIME LOS NUMEROS PARES DEL 1 AL 100
                        while (contador <= 100)
                        {
                            Console.WriteLine(contador);
                            contador += 2;
                        }
                        break;
                    case "0":
                        // OPCION PARA SALIR DEL MENU
                        return;
                    default:
                        // MENSAJE DE ERROR PARA OPCION INVALIDA
                        Console.WriteLine("Error: La opcion no existe, intentalo de nuevo");
                        break;
                }
            }
        }
    }
}
