
/*Programa calculadora en C#*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace calculadora
{
    class Program
    {
        /*Declarar los numeros*/
        static int suma(int a, int b)
        /*Las funciones o "programas" de la calculadora*/
        {
            int suma = a + b;
            return suma;
        }
        static int resta(int a, int b)
        {
            int resta = a - b;
            return resta;
        }
        static int multiplicacion(int a, int b)
        {
            int multi = a * b;
            return multi;
        }
        static int division(int a, int b)
        {
            int divi = a / b;
            return divi;
        }
        /*Menú principal*/
        static void Main(string[] args)
        {
            int a, b;
            Console.Write("\n" + "Introduce el 1er número: ");
            a = int.Parse(Console.ReadLine());
            Console.Write("\n" + "Introduce el 2do número: ");
            b = int.Parse(Console.ReadLine());
            Console.Write("\n" + "Seleccione una opción: " + "\n" + "\n");
            Console.Write("\n" + "     1º) Suma" + "\n" + "     2º) Resta" + "\n" + "     3º) Multiplicación" + "\n" + "     4º) División" + "\n" + "     5º) Salir del Programa" + "\n" + "\n");
            switch (Console.Read())
            {
                case '1':
                    Console.Write("\n" + "    Suma = " + suma(a, b));
                    break;
                case '2':
                    Console.Write("\n" + "    Resta = " + resta(a, b));
                    break;
                case '3':
                    Console.Write("\n" + "    Multiplicación = " + multiplicacion(a, b));
                    break;
                case '4':
                    Console.Write("\n" + "    División = " + division(a, b));
                    break;
                case '5':
                    Console.Write("\n" + "      °º¤ø,¸¸,ø¤º°`°º¤ø,¸( Hasta la próxima )¸,ø¤º°`°º¤ø,¸,ø¤º°");
                    break;
            }
            /*esto es para dejar el resultado hasta que pulses una tecla*/
            Console.ReadKey();
        }
    }
}
