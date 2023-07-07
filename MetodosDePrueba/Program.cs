using System;

namespace MetodosDePrueba
{
    class Program
    {
        static void Main(string[] args)
        {
            // Vamos a trabajar con una suma de 2 números en este Main de prueba.

            int num1 = int.Parse(Console.ReadLine()); // Valor 1.
            int num2 = int.Parse(Console.ReadLine()); // Valor 2.
            Console.WriteLine($"La suma total de 2 números es: {num1 + num2}"); // Imprime la suma total (Sólo debes escribir 2 números consecutivos cualquiera en la ventana de comandos).
        }
    }
}
