/*3. Capturar por teclado un número entero mayor que 0 y menor que 5000, se debe establecer en qué rango se encuentra el número de acuerdo
con las siguientes características: rango alto mayor que 2 4000, rango medio entre 2000 y 4000 ambos incluidos y rango bajo menor que 2000. 
 El programa debe implementar un ciclo que permita validar que el número sea mayor a 0, en caso de que el número ingresado sea menor 
a 0 se debe volver a solicitar al usuario que ingrese el número este procedimiento se debe repetir hasta que el número ingresado sea mayor a 0.*/



// Estructuras repetitivas

using System;

namespace estructuras_repetitivas
{
    class estructuras_repetitivas
    {
        static void Main(string[] args)
        {
            int numero = 0;

            // Ciclo para asegurarse de que el número sea mayor que 0
            while (numero <= 0 || numero >= 5000)
            {
                Console.WriteLine("Ingresa un número entero mayor que 0 y menor que 5000:");
                numero = int.Parse(Console.ReadLine());

                if (numero <= 0)
                {
                    Console.WriteLine("El número ingresado es menor o igual a 0. Por favor intenta nuevamente.");
                }
                else if (numero >= 5000)
                {
                    Console.WriteLine("El número ingresado es mayor o igual a 5000. Por favor intenta nuevamente.");
                }
            }

            // Verificar el rango del número
            if (numero > 4000)
            {
                Console.WriteLine("El número está en el rango alto (mayor que 4000).");
            }
            else if (numero >= 2000 && numero <= 4000)
            {
                Console.WriteLine("El número está en el rango medio (entre 2000 y 4000, ambos incluidos).");
            }
            else
            {
                Console.WriteLine("El número está en el rango bajo (menor que 2000).");
            }
        }
    }
}
