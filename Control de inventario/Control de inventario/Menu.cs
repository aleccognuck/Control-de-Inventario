using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlInventario
{
    internal class menu
    {
        public static void principal()
        {
            int opcion = 0;
            do
            {
                Console.WriteLine("1-Inizializar Arreglos");
                Console.WriteLine("2-Ingresasar Articulos");
                Console.WriteLine("3- Modoficar Articulos");
                Console.WriteLine("4-Borrar Articulos");
                Console.WriteLine("5-Consultar Articulos");
                Console.WriteLine("6-Salir");
                Console.WriteLine("Digite una Opcion: ");
                opcion = int.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 1: break;
                    case 2: break;
                    case 3: break;
                    case 4: break;
                    case 5: break;
                    case 6: Console.WriteLine("Saliendo del sistema"); break;
                    default: Console.WriteLine("** opcion incorrecta**"); break;


                }

            } while (opcion != 6);

        }
    }
}