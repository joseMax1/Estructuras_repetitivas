/* Se solicita la creación de una aplicación que elabore una matriz de 4
× 4 en la cual se almacenarán números entre el 3 y el 6 ambos
incluidos que se deben capturar por teclado.
Una vez obtenida la información se debe establecer cuantas veces
se repiten cada uno de los números del 3 al 6 y hallar la potencia
de ellos de acuerdo con las veces que se repita.
Se debe mostrar por pantalla la matriz generada y las potencias de
los 4 números.     */


using System;

class Program
{
    static void Main()
    {
        int[,] matriz = new int[4, 4];
        int[] contador = new int[4]; // índice 0 para 3, índice 1 para 4, índice 2 para 5, índice 3 para 6

        // Capturar los números entre 3 y 6 y contar repeticiones
        for (int i = 0; i < 4; i++)
            for (int j = 0; j < 4; j++)
            {
                do
                {
                    Console.Write($"Número (3-6) en [{i},{j}]: ");
                    matriz[i, j] = int.Parse(Console.ReadLine());
                } while (matriz[i, j] < 3 || matriz[i, j] > 6);
                contador[matriz[i, j] - 3]++;
            }

        // Mostrar matriz generada
        Console.WriteLine("\nMatriz generada:");
        for (int i = 0; i < 4; i++)
            Console.WriteLine($"{matriz[i, 0]}\t{matriz[i, 1]}\t{matriz[i, 2]}\t{matriz[i, 3]}");

        // Mostrar potencias
        Console.WriteLine("\nPotencias de los números del 3 al 6:");
        for (int i = 0; i < 4; i++)
            Console.WriteLine($"{i + 3}^{contador[i]} = {Math.Pow(i + 3, contador[i])}");
    }
}
