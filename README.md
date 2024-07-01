# _Methods_

- **_Un método es un bloque de código que contiene una serie de instrucciones._**
- **_Un programa hace que se ejecuten las instrucciones al llamar al método y especificando los argumentos de método necesarios._**
- **_En C#, todas las instrucciones ejecutadas se realizan en el contexto de un método._**

**_Cómo efectuar este procedimiento:_**

**_Se ingresan 2 números para poder efectuar básicamente algunas operaciones matemáticas._**

**_Ejemplo:_**

- **_Valor 1:_** ```5```
- **_Valor 2:_** ```5```
- **_Entre ambos números, se puede efectuar cualquier operación matemática, como en este caso es la suma de estos 2, y da como resultado ```10```._**

### _Algoritmo completo mediante código en C#:_
```
using System;

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

            bool salir = false; // SI ACTUALMENTE SIGUE EJECUTANDO CUALQUIERA DE ALGUNAS OPCIONES DEL MENÚ EN CASO DE NO SEGUIR...

            while(!salir)
            {
        Console.WriteLine("               *****                    *****");
                Console.WriteLine("              *******                  *******");
                Console.WriteLine("             *********                *********");
                Console.WriteLine("            ***** *****              ***** *****");
                Console.WriteLine("           *****   *****            *****   *****");
                Console.WriteLine("          *****     *****          *****     *****");
                Console.WriteLine("                    *****          *****");
                Console.WriteLine("                    *****          *****");
                Console.WriteLine("                    *****          *****");
                Console.WriteLine("                    *****          *****");
                Console.WriteLine("                    ********************                    ");
                Console.WriteLine("                    ********************                    ");
                Console.WriteLine("                    *****  ******  *****                    ");
                Console.WriteLine("                    *****  ******  *****                    ");
                Console.WriteLine("                    ********************                    ");
                Console.WriteLine("                    *********  *********                    ");
                Console.WriteLine("                    ********************                    ");
                Console.WriteLine("                    *****          *****                    ");
                Console.WriteLine("                    ********************                    ");
                Console.WriteLine("                    ********************                    ");
                Console.WriteLine("");
                Console.WriteLine("**********BIENVENIDO A LA SECCIÓN DE MÉTODOS, ESTIMADO!!!!!**********");
                Console.WriteLine("SELECCIONE ALGUNAS DE LAS OPCIONES A REALIZAR DICHA OPERACION: ");
                Console.WriteLine("OPCION 1: SUMAR 2 NÚMEROS");
                Console.WriteLine("OPCION 2: RESTAR 2 NÚMEROS");
                Console.WriteLine("OPCION 3: SUMAR 3 NÚMEROS");
                Console.WriteLine("OPCION 4: RESTAR 3 NÚMEROS");
                Console.WriteLine("OPCION 5: SUMAR 4 NÚMEROS");
                Console.WriteLine("OPCION 6: RESTAR 4 NÚMEROS");
                Console.WriteLine("OPCION 7: SALIR");

                int opcion = Convert.ToInt32(Console.ReadLine()); // SE DEBEN DE ELEGIR NÚMEROS DEL 1 AL 7 PARA EFECTUAR DICHO PROCESO...

                switch (opcion)
                {
                    case 1:
                        Console.WriteLine("*****SUMAR 2 NÚMEROS*****");
                        Suma(); // LLAMADO DEL PRIMER MÉTODO...
                        break;
                    case 2:
                        Console.WriteLine("*****RESTAR 2 NÚMEROS*****");
                        Resta(); // LLAMADO DEL SEGUNDO MÉTODO...
                        break;
                    case 3:
                        Console.WriteLine("*****SUMAR 3 NÚMEROS*****");
                        Suma2(); // LLAMADO DEL TERCER MÉTODO...
                        break;
                    case 4:
                        Console.WriteLine("*****RESTAR 3 NÚMEROS*****");
                        Resta2(); // LLAMADO DEL CUARTO MÉTODO...
                        break;
                    case 5:
                        Console.WriteLine("*****SUMAR 4 NÚMEROS*****");
                        Suma3(); // LLAMADO DEL QUINTO MÉTODO...
                        break;
                    case 6:
                        Console.WriteLine("*****RESTAR 4 NÚMEROS*****");
                        Resta3(); // LLAMADO DEL SEXTO MÉTODO...
                        break;
                    case 7:
                        Console.WriteLine("¡¡¡¡¡NOS VEMOS PRONTO!!!!! :(");
                        break;
                    default:
                        Console.WriteLine("SELECCIONE UNA OPCION DEL 1 AL 7!!!!");
                            break;
                }
            }
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

            Console.WriteLine("INTRODUCE UN NÚMERO: ");

            int num1 = int.Parse(Console.ReadLine()); // Número 1.

            Console.WriteLine("INTRODUCE OTRO NÚMERO: ");

            int num2 = int.Parse(Console.ReadLine()); // Número 2.

            Console.WriteLine($"La resta total de dos números es: {num1 - num2}"); // Resta total.

        }

        public static void Suma2()
        {
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

        public static void Resta3()
        {
            Console.WriteLine("INTRODUCE UN NÚMERO: ");

            int num1 = int.Parse(Console.ReadLine()); // Número 1.

            Console.WriteLine("INTRODUCE OTRO NÚMERO: ");

            int num2 = int.Parse(Console.ReadLine()); // Número 2.

            Console.WriteLine("INTRODUCE OTRO NÚMERO: ");

            int num3 = int.Parse(Console.ReadLine()); // Número 3.

            Console.WriteLine("INTRODUCE OTRO NÚMERO: ");

            int num4 = int.Parse(Console.ReadLine()); // Número 4.

            Console.WriteLine($"La resta total de cuatro números es: {num1 - num2 - num3 - num4}"); // Suma total de 4 números.
        }

        public static void Suma4()
        {
            Console.WriteLine("");
            Console.WriteLine("INTRODUCE UN NÚMERO: ");

            int num1 = int.Parse(Console.ReadLine()); // Número 1.

            Console.WriteLine("INTRODUCE OTRO NÚMERO: ");

            int num2 = int.Parse(Console.ReadLine()); // Número 2.

            Console.WriteLine("INTRODUCE OTRO NÚMERO: ");

            int num3 = int.Parse(Console.ReadLine()); // Número 3.

            Console.WriteLine("INTRODUCE OTRO NÚMERO: ");

            int num4 = int.Parse(Console.ReadLine()); // Número 4.

            Console.WriteLine("INTRODUCE UN ÚLTIMO NÚMERO: ");

            int num5 = int.Parse(Console.ReadLine()); // Número 5.

            Console.WriteLine($"La suma total de cinco números es: {num1 + num2 + num3 + num4 + num5}"); // Suma total de 5 números.
        }

        public static void Resta4()
        {
            Console.WriteLine("");
            Console.WriteLine("INTRODUCE UN NÚMERO: ");

            int num1 = int.Parse(Console.ReadLine()); // Número 1.

            Console.WriteLine("INTRODUCE OTRO NÚMERO: ");

            int num2 = int.Parse(Console.ReadLine()); // Número 2.

            Console.WriteLine("INTRODUCE OTRO NÚMERO: ");

            int num3 = int.Parse(Console.ReadLine()); // Número 3.

            Console.WriteLine("INTRODUCE OTRO NÚMERO: ");

            int num4 = int.Parse(Console.ReadLine()); // Número 4.

            Console.WriteLine("INTRODUCE UN ÚLTIMO NÚMERO: ");

            int num5 = int.Parse(Console.ReadLine()); // Número 5.

            Console.WriteLine($"La resta total de cinco números es: {num1 - num2 - num3 - num4 - num5}"); // Resta total de 5 números.
        }
    }
}
```
