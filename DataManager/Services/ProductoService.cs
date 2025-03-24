using CRUD_Console.Data;
using CRUD_Console.Models;
using Microsoft.EntityFrameworkCore;

namespace CRUD_Console.Services
{
    public class ProductoService
    {
        private readonly ApplicationDbContext _context;

        public ProductoService(ApplicationDbContext context)
        {
            _context = context;
        }

        // C: Crear
        public async Task CrearProductoAsync()
        {
            string? nombre = null;
            decimal precio;

            while (string.IsNullOrWhiteSpace(nombre))
            {
                Console.WriteLine("Ingrese el nombre del producto:");
                nombre = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(nombre))
                {
                    Console.WriteLine("El nombre no puede estar vacío.");
                }
            }

            while(true)
            {
                Console.WriteLine("Ingrese el precio del producto:");
                var precioInput = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(precioInput))
                {
                    Console.WriteLine("El precio no puede estar vacío.");
                    continue;
                }

                if (decimal.TryParse(precioInput, out precio)) {
                    break;
                } else {
                    Console.WriteLine("Por favor, ingrese un valor válido para el precio.");
                }
            }

            var producto = new Producto {
                Nombre = nombre,
                Valor = precio,
                Stock = 0
            };

            _context.Productos.Add(producto);
            await _context.SaveChangesAsync();
            Console.WriteLine("Producto creado con éxito.");
        }

        // R: Leer
        public async Task ListarProductosAsync()
        {
            var productos = await _context.Productos.ToListAsync();
            if (productos.Any())
            {
                Console.WriteLine("Productos en la base de datos:");
                foreach (var producto in productos)
                {
                    Console.WriteLine($"ID: {producto.Id}, Nombre: {producto.Nombre}, Valor: {producto.Valor}, Stock: {producto.Stock}");
                }
            }
            else
            {
                Console.WriteLine("No hay productos en la base de datos.");
            }
        }

        // U: Actualizar
        public async Task ActualizarProductoAsync()
        {
            int id;
            string? nuevoNombre = null;
            decimal precio;

            while (true)
            {
                Console.WriteLine("Ingrese el ID del producto a actualizar: ");
                var idInput = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(idInput))
                {
                    Console.WriteLine("El ID no puede estar vacío.");
                    continue;
                }

                if (!int.TryParse(idInput, out id)) {
                    Console.WriteLine("Por favor, ingrese un valor válido para el ID.");
                    continue;
                } else {
                    break;
                }
            }

            while (string.IsNullOrWhiteSpace(nuevoNombre))
            {
                Console.WriteLine("Ingrese el nuevo nombre del producto:");
                nuevoNombre = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(nuevoNombre))
                {
                    Console.WriteLine("El nombre no puede estar vacío.");
                }
            }

            while(true)
            {
                Console.WriteLine("Ingrese el nuevo precio del producto:");
                var precioInput = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(precioInput))
                {
                    Console.WriteLine("El precio no puede estar vacío.");
                    continue;
                }

                if (decimal.TryParse(precioInput, out precio)) {
                    break;
                } else {
                    Console.WriteLine("Por favor, ingrese un valor válido para el precio.");
                }
            }

            var producto = await _context.Productos.FindAsync(id);
            if (producto != null)
            {
                producto.Nombre = nuevoNombre;
                producto.Valor = precio;
                await _context.SaveChangesAsync();
                Console.WriteLine("Producto actualizado con éxito.");
            }
            else
            {
                Console.WriteLine("Producto no encontrado.");
            }
        }

        // D: Eliminar
        public async Task EliminarProductoAsync()
        {
            Console.Write("Introduce el ID del producto a eliminar: ");
            var id = int.Parse(Console.ReadLine() ?? "0");

            var producto = await _context.Productos.FindAsync(id);
            if (producto != null)
            {
                _context.Productos.Remove(producto);
                await _context.SaveChangesAsync();
                Console.WriteLine("Producto eliminado con éxito.");
            }
            else
            {
                Console.WriteLine("Producto no encontrado.");
            }
        }
    }
}
