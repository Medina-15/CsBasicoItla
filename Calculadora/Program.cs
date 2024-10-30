using System;

internal class Program
{
    static void Main(string[] args)
    {

        Calcularnumeros();

    }
    private static void Calcularnumeros()
    {

        // Declaracion de variables
        int num1 = 0;
        int num2 = 0;
        int num3 = 0;
        int num4 = 0;
        int suma = 0;
        int producto = 0;

        Console.WriteLine("Este programa calcula la suma de los dos primeros numeros y el producto de los otros dos");

        // Recoleccion de datos
        Console.WriteLine("Digite el primer numero:");
        num1 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Digite el segundo numero:");
        num2 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Digite el tercer numero:");
        num3 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Digite el cuerto numero:");
        num4 = Convert.ToInt32(Console.ReadLine());

        // Operacion
        suma = num1 + num2;
        producto = num3 * num4;

        // Resultado
        Console.WriteLine($"La suma es igual a {suma} y el producto es igual a {producto}");

        Console.WriteLine("Gracias por participar!");



        //Main


    }
}
