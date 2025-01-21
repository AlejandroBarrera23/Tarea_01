using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea_01.Ejercicios
{
    public class Ejercicio2
    {
        public static void Ejecutar()
        {
            // CICLO WHILE QUE PERMITE MOSTRAR EL MENU HASTA QUE SE ELIJA SALIR
            while (true)
            {
                // MENU PRINCIPAL CON LAS OPCIONES DEL EJERCICIO
                Console.WriteLine("\n================================");
                Console.WriteLine("EJERCICIO 2");
                Console.WriteLine("================================");
                Console.WriteLine("1. Evaluar si un numero es positivo, negativo o cero");
                Console.WriteLine("2. Evaluar una calificacion");
                Console.WriteLine("3. Determinar el rango de un numero");
                Console.WriteLine("4. Mostrar el dia de la semana");
                Console.WriteLine("5. Calculadora basica");
                Console.WriteLine("0. Regresar");

                // LECTURA DE LA OPCION INGRESADA POR EL USUARIO
                string opcion = Console.ReadLine();

                // SWITCH PARA EJECUTAR LA LOGICA SEGUN LA OPCION SELECCIONADA
                switch (opcion)
                {
                    case "1":
                        // EVALUAR SI UN NUMERO ES POSITIVO, NEGATIVO O CERO
                        Console.WriteLine("Ingresa un numero:");
                        if (int.TryParse(Console.ReadLine(), out int numero))
                        {
                            // DETERMINAR SI EL NUMERO ES POSITIVO, NEGATIVO O CERO
                            string resultado = numero > 0 ? "positivo" : numero < 0 ? "negativo" : "cero";
                            Console.WriteLine($"El numero {numero} es {resultado}");
                        }
                        else
                        {
                            // MENSAJE DE ERROR EN CASO DE ENTRADA INVALIDA
                            Console.WriteLine("Error: Ingresa un numero entero");
                        }
                        break;
                    case "2":
                        // EVALUAR UNA CALIFICACION ENTRE 0 Y 100
                        Console.WriteLine("\nIngresa una calificacion entre 0 y 100:");
                        if (int.TryParse(Console.ReadLine(), out int calificacion))
                        {
                            // DETERMINAR SI LA CALIFICACION ES APROBATORIA O NO
                            if (calificacion >= 60)
                            {
                                Console.WriteLine("Aprobado");
                            }
                            else
                            {
                                Console.WriteLine("Reprobado");
                            }
                        }
                        else
                        {
                            // MENSAJE DE ERROR EN CASO DE ENTRADA INVALIDA
                            Console.WriteLine("Error: Ingresa un numero entero");
                        }
                        break;
                    case "3":
                        // DETERMINAR EL RANGO DE UN NUMERO
                        Console.WriteLine("\nIngresa un numero para determinar su rango:");
                        if (int.TryParse(Console.ReadLine(), out numero))
                        {
                            // EVALUAR SI EL NUMERO ES MENOR QUE 10, ENTRE 10 Y 20, O MAYOR QUE 20
                            if (numero < 10)
                            {
                                Console.WriteLine("Menor que 10");
                            }
                            else if (numero >= 10 && numero <= 20)
                            {
                                Console.WriteLine("Entre 10 y 20");
                            }
                            else
                            {
                                Console.WriteLine("Mayor que 20");
                            }
                        }
                        else
                        {
                            // MENSAJE DE ERROR EN CASO DE ENTRADA INVALIDA
                            Console.WriteLine("Error: Ingresa un numero entero");
                        }
                        break;
                    case "4":
                        // MOSTRAR EL DIA DE LA SEMANA SEGUN UN NUMERO DEL 1 AL 7
                        Console.WriteLine("\nIngresa un numero del 1 al 7 para obtener un dia de la semana:");
                        if (int.TryParse(Console.ReadLine(), out int dia))
                        {
                            // SWITCH EXPRESION PARA DETERMINAR EL DIA DE LA SEMANA
                            string diaSemana = dia switch
                            {
                                1 => "Lunes",
                                2 => "Martes",
                                3 => "Miercoles",
                                4 => "Jueves",
                                5 => "Viernes",
                                6 => "Sabado",
                                7 => "Domingo",
                                _ => "Error: Fuera de rango"
                            };
                            Console.WriteLine(diaSemana);
                        }
                        else
                        {
                            // MENSAJE DE ERROR EN CASO DE ENTRADA INVALIDA
                            Console.WriteLine("Error: Ingresa un numero entero");
                        }
                        break;
                    case "5":
                        // REALIZAR OPERACIONES ARITMETICAS BASICAS
                        Console.WriteLine("\nIngresa el primer numero:");
                        if (double.TryParse(Console.ReadLine(), out double numero1))
                        {
                            Console.WriteLine("Ingresa el segundo numero:");
                            if (double.TryParse(Console.ReadLine(), out double numero2))
                            {
                                Console.WriteLine("Ingresa la operacion a ejecutar (+, -, *, /):");
                                string operacion = Console.ReadLine();

                                // SWITCH EXPRESION PARA EJECUTAR LA OPERACION SELECCIONADA
                                double resultado = operacion switch
                                {
                                    "+" => numero1 + numero2,
                                    "-" => numero1 - numero2,
                                    "*" => numero1 * numero2,
                                    "/" when numero2 != 0 => numero1 / numero2, // VALIDACION PARA EVITAR DIVISION POR CERO
                                    "/" => double.NaN,
                                    _ => double.NaN // OPERACION INVALIDA
                                };

                                // IMPRIMIR EL RESULTADO O UN MENSAJE DE ERROR SI ES INVALIDO
                                if (double.IsNaN(resultado))
                                {
                                    Console.WriteLine("Operacion invalida o division por cero.");
                                }
                                else
                                {
                                    Console.WriteLine($"El resultado es: {resultado}");
                                }
                            }
                            else
                            {
                                // MENSAJE DE ERROR EN CASO DE ENTRADA INVALIDA PARA EL SEGUNDO NUMERO
                                Console.WriteLine("Error: Entrada invalida en el segundo numero");
                            }
                        }
                        else
                        {
                            // MENSAJE DE ERROR EN CASO DE ENTRADA INVALIDA PARA EL PRIMER NUMERO
                            Console.WriteLine("Error: Entrada invalida en el primer numero");
                        }
                        break;
                    case "0":
                        // SALIR DEL MENU
                        return;
                    default:
                        // MENSAJE DE ERROR EN CASO DE OPCION INCORRECTA
                        Console.WriteLine("Error: Opcion incorrecta. Intente nuevamente.");
                        break;
                }
            }
        }
    }
}

