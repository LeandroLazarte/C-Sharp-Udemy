using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seccion2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ///****Operaciones*******/
            /* //Usando el operador suma
             Console.WriteLine(45 + 34);
             //Usando el operador restar
             Console.WriteLine(50 - 3);
             //Usando el operador multiplicación
             Console.WriteLine(50 * 8);
             //Usando el operador resta
             Console.WriteLine(16.8M / 4.1M);
             //Resto de division
             Console.WriteLine(5 % 2);
             //Residuo
             Console.WriteLine(5.3 % 2.3);
            //*/

            /******************************/
            //Jerarquia de operaciones
            /* double resultado;

             resultado = 3.0 / (3 + 5) * 2;

             Console.WriteLine(resultado);
            */

            /****Pedir datos al usuario*****/
            /* string nombre;

             //Preguntamos el nombre del usuario
             Console.Write("¿Como te llamas?: ");
             nombre = Console.ReadLine();

             //Saludamos al usuario
             Console.WriteLine("Hola {0}, como estas", nombre);
            */


            /****Convertir una cadena******/
            /*
            //Declarando variables
            int numUno = 5;
            int numDos;
            int resultado;
            string nombre;

            //Pedimos al usuario que ingrese su nombre
            Console.WriteLine("Ingrese su nombre: ");
            //Muestra el nombre por pantalla
            nombre = Console.ReadLine();
            Console.WriteLine("Bienvenido {0}", nombre);
            //Pedimos un numero por teclado
            Console.WriteLine("Dame un numero para sumarlo: ");

            numDos = Int32.Parse(Console.ReadLine());

            resultado = numUno + numDos;

            //Muestra el resultado por pantalla
            Console.WriteLine("El resultado de la suma es: {0}", resultado);
            */

            /*****Calcular area y perimetro de un rectangulo*****/

            //Declarando variables
            double altura;
            double ancho;
            double area;
            double perimetro;

            //Pedir altura
            Console.WriteLine("Ingrese el alto del rectangulo: ");
            //Pedir ancho
            Console.WriteLine("Ingrese el ancho del rectangulo: ");

        }
    }
}
