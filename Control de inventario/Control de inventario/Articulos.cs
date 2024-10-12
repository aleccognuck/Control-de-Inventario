using System;

namespace ControlInventario
{
    public static class Articulos // Clase estática
    {
        public static int[] id = new int[100];
        public static string[] nombre = new string[100];

        // Menú principal
        public static void Principal()
        {
            int opcion = 0;
            do
            {
                Console.WriteLine("\n** MENÚ PRINCIPAL **");
                Console.WriteLine("1 - Inicializar Arreglos");
                Console.WriteLine("2 - Ingresar Artículos");
                Console.WriteLine("3 - Modificar Artículos");
                Console.WriteLine("4 - Consultar Artículos");
                Console.WriteLine("5 - Excluir Artículos");
                Console.WriteLine("6 - Salir");
                Console.Write("Digite una opción: ");

                if (int.TryParse(Console.ReadLine(), out opcion))
                {
                    switch (opcion)
                    {
                        case 1:
                            InicializarArreglos();
                            break;
                        case 2:
                            IngresarProductos();
                            break;
                        case 3:
                            ModificarProductos();
                            break;
                        case 4:
                            ConsultarProductos();
                            break;
                        case 5:
                            ExcluirProductos();
                            break;
                        case 6:
                            Console.WriteLine("Saliendo del sistema.");
                            break;
                        default:
                            Console.WriteLine("** Opción incorrecta **");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("** Opción no válida, intente nuevamente **");
                }

            } while (opcion != 6);
        }

        // Inicializa los arreglos
        public static void InicializarArreglos()
        {
            for (int i = 0; i < id.Length; i++)
            {
                id[i] = 0;
                nombre[i] = string.Empty;
            }
            Console.WriteLine("Los arreglos han sido inicializados.");
        }

        // Ingresa productos
        public static void IngresarProductos()
        {
            for (int i = 0; i < id.Length; i++)
            {
                Console.Write("Digite un código (0 para terminar): ");
                if (!int.TryParse(Console.ReadLine(), out int codigo) || codigo == 0)
                    break;

                Console.Write("Digite un artículo: ");
                string articulo = Console.ReadLine();

                id[i] = codigo;
                nombre[i] = articulo;

                Console.WriteLine("Producto ingresado correctamente.");
            }
        }

        // Modifica un producto existente
        public static void ModificarProductos()
        {
            Console.Write("Digite el código del artículo que desea modificar: ");
            if (!int.TryParse(Console.ReadLine(), out int codigoModificar))
            {
                Console.WriteLine("Código no válido.");
                return;
            }

            for (int i = 0; i < id.Length; i++)
            {
                if (id[i] == codigoModificar)
                {
                    Console.WriteLine($"Código: {id[i]} - Nombre: {nombre[i]}");
                    Console.Write("Digite el nuevo nombre: ");
                    nombre[i] = Console.ReadLine();
                    Console.WriteLine("Producto modificado correctamente.");
                    return;
                }
            }

            Console.WriteLine("Producto no encontrado.");
        }

        // Consulta todos los productos
        public static void ConsultarProductos()
        {
            Console.WriteLine("\n**REPORTE DE ARTÍCULOS**");
            for (int i = 0; i < id.Length; i++)
            {
                if (id[i] != 0 && !string.IsNullOrEmpty(nombre[i]))
                    Console.WriteLine($"Código: {id[i]} - Nombre: {nombre[i]}");
            }
            Console.WriteLine("**FIN DEL REPORTE**\n");
        }

        // Elimina un producto por código
        public static void ExcluirProductos()
        {
            Console.Write("Digite el código del artículo que desea eliminar: ");
            if (!int.TryParse(Console.ReadLine(), out int codigoEliminar))
            {
                Console.WriteLine("Código no válido.");
                return;
            }

            for (int i = 0; i < id.Length; i++)
            {
                if (id[i] == codigoEliminar)
                {
                    id[i] = 0;
                    nombre[i] = string.Empty;
                    Console.WriteLine("Producto eliminado correctamente.");
                    return;
                }
            }

            Console.WriteLine("Producto no encontrado.");
        }
    }
}
