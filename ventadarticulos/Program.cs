namespace ventadarticulos
{
    internal class Program
    {
        static void Main(string[] args)

        {

            Console.WriteLine("En este programa digitas el precio de un articulo, luego la cantidad que se lleva el cliente y luego se muestra la cantidad que debe de abonar");

            // Declarando variables


            int precio = 0;
            int cantidad = 0;
            int resultado = 0;

            // Recoleccion de datos
            
            Console.WriteLine("Digite el precio del articulo:");
            precio = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Escriba la cantidad del articulo:");
            cantidad = Convert.ToInt32(Console.ReadLine());

            



            Console.WriteLine("Hello, World!");
        }
    }
}
