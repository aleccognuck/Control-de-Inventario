using System;

namespace ControlInventario
{
    internal class Arreglos
    {
        public static void Principal()
        {
            int[] codigo = new int[10]; // Arreglo de códigos
            string[] producto = new string[10]; // Arreglo de nombres de productos
            float[] costo = new float[10]; // Arreglo de costos

            // Predefinir algunos valores
            codigo[2] = 50;
            producto[0] = "Teclado";
            producto[2] = "Mouse";
            producto[9] = "Pantalla";
            producto[1] = "PC GAMER";
            producto[5] = "Mousepad";
            costo[2] = 200;
            costo[9] = 500;
            costo[1] = 374000;
            costo[5] = 24000;

            // Pedir al usuario que ingrese los valores
            for (int i = 0; i < 10; i++)
            {
                if (codigo[i] == 0 && string.IsNullOrEmpty(producto[i])) // Si no hay valores predefinidos
                {
                    Console.WriteLine($"Ingrese los datos para el producto en la posición {i + 1}:");

                    Console.Write("Digite el código del producto: ");
                    codigo[i] = int.Parse(Console.ReadLine());

                    Console.Write("Digite el nombre del producto: ");
                    producto[i] = Console.ReadLine();

                    Console.Write("Digite el costo del producto: ");
                    costo[i] = float.Parse(Console.ReadLine());
                }
            }

            // Mostrar todos los productos ingresados o predefinidos
            Console.WriteLine("\n** REPORTE DE PRODUCTOS **");
            for (int i = 0; i < 10; i++)
            {
                if (!string.IsNullOrEmpty(producto[i]) && codigo[i] != 0)
                {
                    Console.WriteLine($"Código: {codigo[i]} | Producto: {producto[i]} | Precio: {costo[i]:C2}");
                }
            }
            Console.WriteLine("** FIN DEL REPORTE **");
        }
    }
}
