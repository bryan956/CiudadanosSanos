using CiudadanosSanos.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;

namespace CiudadanosSanos.Data
{
    public class ConsultaContext : DbContext
    {
        public ConsultaContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Product> Products { get; set; }
        //public DbSet<Consulta> Categories { get;set; }
        public DbSet<Provider> Providers { get; set; }
        public DbSet<PayMode> PayModes { get; set; }
        public DbSet<Producto> Productos { get; set; }
        public DbSet<Compra> Compras { get; set; }
        public DbSet<Consulta> Consultas { get; set; }
    }
}
