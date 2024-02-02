using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarera2Progra3
{
    internal class Clsmenu
    {
        public static void Menu()
        {
            int opcion;
            do
            {
                Console.WriteLine("1- Agregar Productos");
                Console.WriteLine("2- Venta de Productos");
                Console.WriteLine("3- Actualizar Productos");
                Console.WriteLine("4- Actualizar Precio");
                Console.WriteLine("5- Reporte");
                Console.WriteLine("6- Salir");
                Console.WriteLine("Digite una opcion...");
                opcion = int.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        ClsProducto.AgregarProducto();
                        break;
                    case 2:
                        ClsProducto.VenderProducto();
                        break;
                    case 3:
                        ClsProducto.ActualizarProducto();
                        break;
                    case 4:
                        ClsProducto.ActualizarPrecio();
                        break;
                    case 5:
                        ClsProducto.GenerarReporte();
                        break;
                    case 6:
                        Console.WriteLine("Saliendo...");
                        break;
                    default:
                        Console.WriteLine("Opcion incorrecta");
                        break;
                }
            } while (opcion != 6);
        }
    }
}
