﻿using System;

namespace MetodosDePrueba
{
    class Program
    {
        static void Main(string[] args)
        {
            // Por el momento dejaremos esta sección de código como comentario para probar con otros métodos.
            // Vamos a trabajar con una suma de 2 números en este Main de prueba.

            // int num1 = int.Parse(Console.ReadLine()); // Valor 1.
            // int num2 = int.Parse(Console.ReadLine()); // Valor 2.
            // Console.WriteLine($"La suma total de 2 números es: {num1 + num2}"); // Imprime la suma total (Sólo debes escribir 2 números consecutivos cualquiera en la ventana de comandos).

            // Ahora procedemos con una variable para sumar 2 números en este método.

            // double total = Suma(2, 3); // Esta línea de código tiene que tener un método estático.
            // Console.WriteLine(total); // Imprime desde la variable la suma total.

            Suma(); // LLAMADO DEL PRIMER MÉTODO...
            Resta(); // LLAMADO DEL SEGUNDO MÉTODO...
            Suma2(); // LLAMADO DEL TERCER MÉTODO...
            Resta2(); // LLAMADO DEL CUARTO MÉTODO...
            Suma3(); // LLAMADO DEL QUINTO MÉTODO...
        }

        // public double[] Suma()
        // {
            // return new double[] { 5, 5 }; // Pero no es la forma correcta.
            // Console.WriteLine("También hay otra forma para poder sumar con este método");
        // }

        public static void Suma()
        {
            // Console.WriteLine($"La suma de dos números es {num1 + num2}"); // Imprime la suma total de dos números.

            // return num1 + num2;

            // Existen diferentes formas de sumar dos números fundamentales utilizando variables ya avanzadas.

            Console.WriteLine("*****SUMAR 2 NÚMEROS*****");

            Console.WriteLine("INTRODUCE UN NÚMERO: ");

            int num1 = int.Parse(Console.ReadLine()); // Número 1

            Console.WriteLine("INTRODUCE OTRO NÚMERO: ");

            int num2 = int.Parse(Console.ReadLine()); // Número 2

            Console.WriteLine($"La suma total de dos números es: {num1 + num2}"); // Suma total de 2 números.

        }

        public static void Resta()
        {
            // Console.WriteLine($"La resta de dos números es {num1 - num2}"); // Imprime la resta total de dos números.

            // return num1 - num2;

            // Existen diferentes formas de restar dos números fundamentales utilizando variables ya avanzadas.

            Console.WriteLine("*****RESTAR 2 NÚMEROS*****");

            Console.WriteLine("INTRODUCE UN NÚMERO: ");

            int num1 = int.Parse(Console.ReadLine()); // Número 1.

            Console.WriteLine("INTRODUCE OTRO NÚMERO: ");

            int num2 = int.Parse(Console.ReadLine()); // Número 2.

            Console.WriteLine($"La resta total de dos números es: {num1 - num2}"); // Resta total.

        }

        public static void Suma2()
        {
            Console.WriteLine("*****SUMAR 3 NÚMEROS*****");

            Console.WriteLine("INTRODUCE UN NÚMERO: ");

            int num1 = int.Parse(Console.ReadLine()); // Número 1.

            Console.WriteLine("INTRODUCE OTRO NÚMERO: ");

            int num2 = int.Parse(Console.ReadLine()); // Número 2.

            Console.WriteLine("INTRODUCE OTRO NÚMERO: ");

            int num3 = int.Parse(Console.ReadLine()); // Número 3.

            Console.WriteLine($"La suma total de tres números es: {num1 + num2 + num3}"); // Suma total de 3 números.
        }

        public static void Resta2()
        {
            Console.WriteLine("*****RESTAR 3 NÚMEROS*****");

            Console.WriteLine("INTRODUCE UN NÚMERO: ");

            int num1 = int.Parse(Console.ReadLine()); // Número 1.

            Console.WriteLine("INTRODUCE OTRO NÚMERO: ");

            int num2 = int.Parse(Console.ReadLine()); // Número 2.

            Console.WriteLine("INTRODUCE OTRO NÚMERO: ");

            int num3 = int.Parse(Console.ReadLine()); // Número 3.

            Console.WriteLine($"La resta total de tres números es: {num1 - num2 - num3}"); // Resta total de 3 números.
        }

        public static void Suma3()
        {
            Console.WriteLine("*****SUMAR 4 NÚMEROS*****");

            Console.WriteLine("INTRODUCE UN NÚMERO: ");

            int num1 = int.Parse(Console.ReadLine()); // Número 1.

            Console.WriteLine("INTRODUCE OTRO NÚMERO: ");

            int num2 = int.Parse(Console.ReadLine()); // Número 2.

            Console.WriteLine("INTRODUCE OTRO NÚMERO: ");

            int num3 = int.Parse(Console.ReadLine()); // Número 3.

            Console.WriteLine("INTRODUCE OTRO NÚMERO: ");

            int num4 = int.Parse(Console.ReadLine()); // Número 4.

            Console.WriteLine($"La suma total de cuatro números es: {num1 + num2 + num3 + num4}"); // Suma total de 4 números.
        }
    }
}
