using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarera2Progra3
{
    internal class ClsProducto
    {
        public int Codigo;
        public string Descripcion;
        public int Existencia;
        public int Minimo;
        public float Precio;

        public static List<ClsProducto> Productos = new List<ClsProducto>();

        public ClsProducto(int codigo, string descripcion, int existencia, int minimo, float precio)
        {
            Codigo = codigo;
            Descripcion = descripcion;
            Existencia = existencia;
            Minimo = minimo;
            Precio = precio;
        }

        public ClsProducto() { }

        public static void AgregarProducto()
        {
            Console.WriteLine("Digite el codigo:");
            int cod = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite la Descripcion:");
            string descripcion = Console.ReadLine();
            Console.WriteLine("Digite la existencia:");
            int existencia = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite el minimo:");
            int minimo = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite el precio:");
            float precio = float.Parse(Console.ReadLine());

            Productos.Add(new ClsProducto(cod, descripcion, existencia, minimo, precio));
            Console.WriteLine("Producto agregado exitosamente.");
        }

        public static void VenderProducto()
        {
            Console.WriteLine("Digite el codigo del producto a vender:");
            int cod = int.Parse(Console.ReadLine());
            var producto = Productos.FirstOrDefault(p => p.Codigo == cod);
            if (producto != null)
            {
                Console.WriteLine("Digite la cantidad a vender:");
                int cantidad = int.Parse(Console.ReadLine());
                if (cantidad <= producto.Existencia)
                {
                    producto.Existencia -= cantidad;
                    Console.WriteLine($"Venta realizada exitosamente. Existencia actual: {producto.Existencia}");
                }
                else
                {
                    Console.WriteLine("No hay suficiente existencia para realizar la venta.");
                }
            }
            else
            {
                Console.WriteLine("Producto no encontrado.");
            }
        }

        public static void ActualizarProducto()
        {
            Console.WriteLine("Digite el codigo del producto a actualizar:");
            int cod = int.Parse(Console.ReadLine());
            var producto = Productos.FirstOrDefault(p => p.Codigo == cod);
            if (producto != null)
            {
                Console.WriteLine("Digite la nueva descripción:");
                producto.Descripcion = Console.ReadLine();
                Console.WriteLine("Digite la nueva existencia:");
                producto.Existencia = int.Parse(Console.ReadLine());
                Console.WriteLine("Digite el nuevo mínimo:");
                producto.Minimo = int.Parse(Console.ReadLine());
                Console.WriteLine("Producto actualizado exitosamente.");
            }
            else
            {
                Console.WriteLine("Producto no encontrado.");
            }
        }

        public static void ActualizarPrecio()
        {
            Console.WriteLine("Digite el codigo del producto para actualizar su precio:");
            int cod = int.Parse(Console.ReadLine());
            var producto = Productos.FirstOrDefault(p => p.Codigo == cod);
            if (producto != null)
            {
                Console.WriteLine("Digite el nuevo precio:");
                producto.Precio = float.Parse(Console.ReadLine());
                Console.WriteLine("Precio actualizado exitosamente.");
            }
            else
            {
                Console.WriteLine("Producto no encontrado.");
            }
        }

        public static void GenerarReporte()
        {
            Console.WriteLine("Reporte de Productos:");
            foreach (var producto in Productos)
            {
                Console.WriteLine($"Codigo: {producto.Codigo}, Descripción: {producto.Descripcion}, Existencia: {producto.Existencia}, Minimo: {producto.Minimo}, Precio: {producto.Precio}");
            }
        }
    }
}
