using Microsoft.EntityFrameworkCore;

namespace Convenciones.Dal
{
    public class ConvencionesDBContext : DbContext
    {
        public ConvencionesDBContext(DbContextOptions<ConvencionesDBContext> options) : base(options)
        {

        }
        public DbSet<Etiquetas> etiquetas { get; set; }
        public DbSet<Titulos> titulos { get; set; }
        public DbSet<Entradas> entradas { get; set; }
        public DbSet<Fuentes> fuentes { get; set; }
    }
}
