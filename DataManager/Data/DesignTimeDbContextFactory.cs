using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System.IO;

namespace CRUD_Console.Data  // Utiliza el namespace correcto según tu estructura de carpetas
{
    public class DesignTimeDbContextFactory : IDesignTimeDbContextFactory<ApplicationDbContext>
    {
        public ApplicationDbContext CreateDbContext(string[] args)
        {
            var configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())  // Ruta para appsettings.json
                .AddJsonFile("appsettings.json", optional: false)  // Asegúrate de que la cadena de conexión esté en appsettings.json
                .Build();

            var optionsBuilder = new DbContextOptionsBuilder<ApplicationDbContext>();
            optionsBuilder.UseSqlServer(configuration.GetConnectionString("DefaultConnection"));  // Tu cadena de conexión

            return new ApplicationDbContext(optionsBuilder.Options);
        }
    }
}
