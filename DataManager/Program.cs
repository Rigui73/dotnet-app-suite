using CRUD_Console.Data;
using CRUD_Console.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;

// 1: Crear la configuración (cargar appsettings.json)
var configuration = new ConfigurationBuilder()
    .SetBasePath(AppDomain.CurrentDomain.BaseDirectory) // Asegurarse de que se busque en el directorio correcto
    .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
    .Build();

// 2: Configurar DI
var serviceProvider = new ServiceCollection()
    .AddDbContext<ApplicationDbContext>(options =>
        options.UseSqlServer(configuration.GetConnectionString("DefaultConnection")))
    .AddScoped<ProductoService>() // Registrar el servicio que manejará las operaciones CRUD
    .BuildServiceProvider();

// 3: Obtener el servicio
var productService = serviceProvider.GetRequiredService<ProductoService>();

// 4: Ejecución Programa
bool running = true;

while (running) {
    Console.Clear();
    Console.WriteLine("\nCRUD Operations:");
    Console.WriteLine("1. (C) Crear Producto");
    Console.WriteLine("2. (R) Leer Productos");
    Console.WriteLine("3. (U) Actualizar Producto");
    Console.WriteLine("4. (D) Eliminar Producto");
    Console.WriteLine("5. Salir");
    Console.Write("Escoge una opción: ");

    var choice = Console.ReadLine();

    switch (choice) {
        case "1":
            // Crear Producto
            await productService.CrearProductoAsync();
            break;

        case "2":
            // Leer Productos
            await productService.ListarProductosAsync();
            break;

        case "3":
            // Actualizar Producto
            await productService.ActualizarProductoAsync();
            break;

        case "4":
            // Eliminar Producto
            await productService.EliminarProductoAsync();
            break;

        case "5":
            // Salir
            running = false;
            break;

        default:
            Console.WriteLine($"La opción: {choice}, no es un valor válido. Escoge un valor entre [1-5].");
            break;
    }

    Console.WriteLine("\nPresiona cualquier tecla para continuar...");
    Console.ReadKey();
}
