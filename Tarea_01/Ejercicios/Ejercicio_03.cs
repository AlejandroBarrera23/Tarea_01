using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea_01.Ejercicios
{
    public class Ejercicio3
    {
        public static void Ejecutar()
        {
            // ENCABEZADO DEL EJERCICIO 3
            Console.WriteLine("\n================================");
            Console.WriteLine("EJERCICIO 3");
            Console.WriteLine("================================");

            // CREACION Y USO DE UNA INSTANCIA DE LA CLASE PERSONA
            var persona = new Persona { Nombre = "Juan", Edad = 25, DNI = "12345678" };
            persona.MostrarInformacion();

            // CREACION Y USO DE UNA INSTANCIA DE LA CLASE PUNTO
            var punto = new Punto { X = 5, Y = 10 };
            Console.WriteLine($"Punto en el plano cartesiano: ({punto.X}, {punto.Y})");

            // CREACION Y USO DE UNA INSTANCIA DE LA CLASE CIRCULO
            var circulo = new Circulo { X = 0, Y = 0, Radio = 5 };
            Console.WriteLine($"Area del circulo: {circulo.CalcularArea()}");

            // CREACION Y USO DE UNA INSTANCIA DE LA CLASE PERSONA EXTENDIDA
            var personaExtendida = new PersonaExtendida { Nombre = "Maria", Apellido = "Perez", Edad = 30, Genero = "Femenino" };
            personaExtendida.MostrarInformacion();
        }

        // CLASE PERSONA
        public class Persona
        {
            public string Nombre { get; set; } 
            public int Edad { get; set; } 
            public string DNI { get; set; }

            // METODO PARA MOSTRAR LA INFORMACION DE LA PERSONA
            public void MostrarInformacion()
            {
                Console.WriteLine($"Nombre: {Nombre}, Edad: {Edad}, DNI: {DNI}");
            }
        }

        // CLASE PUNTO
        public class Punto
        {
            public int X { get; set; } 
            public int Y { get; set; } 
        }

        // CLASE CIRCULO
        public class Circulo
        {
            public int X { get; set; } 
            public int Y { get; set; } 
            public double Radio { get; set; } 

            // METODO PARA CALCULAR EL AREA DEL CIRCULO
            public double CalcularArea()
            {
                return Math.PI * Radio * Radio;
            }
        }

        // CLASE PERSONA EXTENDIDA 
        public class PersonaExtendida : Persona
        {
            public string Apellido { get; set; } // Apellido de la persona
            public string Genero { get; set; }   // Genero de la persona

            // Metodo para mostrar la informacion de la persona extendida
            public new void MostrarInformacion()
            {
                Console.WriteLine($"Nombre: {Nombre} {Apellido}, Edad: {Edad}, Genero: {Genero}, DNI: {DNI}");
            }
        }
    }
}


