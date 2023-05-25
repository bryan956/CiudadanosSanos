using CiudadanosSanos.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;

namespace CiudadanosSanos.Data
{
    public class Consulta_ExternaContext : DbContext
    {
        public Consulta_ExternaContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Consulta_Externa> Consulta_Externas { get; set; }
    }
}
