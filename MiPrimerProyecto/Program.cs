using System;
using System.Collections.Generic;

namespace GestionDeProductos
{
    // Clase Producto
    public class Producto
    {
        // Propiedades
        public string Nombre { get; set; }
        public decimal Precio { get; set; }
        public int Cantidad { get; set; }

        // Constructor
        public Producto(string nombre, decimal precio, int cantidad)
        {
            Nombre = nombre;
            Precio = precio;
            Cantidad = cantidad;
        }

        // Método para mostrar la información del producto
        public void MostrarInformacion()
        {
            Console.WriteLine($"Nombre: {Nombre}, Precio: {Precio:C}, Cantidad: {Cantidad}");
        }
    }

    // Clase Inventario
    public class Inventario
    {
        // Lista privada de productos (encapsulamiento)
        private List<Producto> productos = new List<Producto>();

        // Método para agregar un producto al inventario
        public void AgregarProducto(Producto producto)
        {
            productos.Add(producto);
            Console.WriteLine("Producto agregado al inventario.");
        }

        // Método para listar todos los productos
        public void ListarProductos()
        {
            Console.WriteLine("\nLista de productos en el inventario:");
            foreach (var producto in productos)
            {
                producto.MostrarInformacion();
            }
        }
    }

    // Programa Principal
    class Program
    {
        static void Main(string[] args)
        {
            // Crear una instancia de la clase Inventario
            Inventario inventario = new Inventario();

            // Agregar al menos 3 productos
            inventario.AgregarProducto(new Producto("Laptop", 1500.99m, 5));
            inventario.AgregarProducto(new Producto("Mouse", 25.50m, 10));
            inventario.AgregarProducto(new Producto("Teclado", 45.75m, 7));

            // Listar todos los productos en el inventario
            inventario.ListarProductos();

            Console.WriteLine("\nPresione cualquier tecla para salir...");
            Console.ReadKey();
        }
    }
}
