using Microsoft.EntityFrameworkCore;
using Sales.Data.Entities;

namespace Sales.Data.Context
{
    public class ConeContext : DbContext
    {
        public ConeContext(DbContextOptions <ConeContext> options) : base(options)
        {
            
        }

        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<Configuracion> Configuraciones { get; set; }
        public DbSet<DetalleVenta> DetallesVentas { get; set; }
    }
}
