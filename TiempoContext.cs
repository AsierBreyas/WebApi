using Microsoft.EntityFrameworkCore;

namespace Tiempo.Models
{
    public class TiempoContext : DbContext
    {
        public TiempoContext(DbContextOptions<TiempoContext> options)
            : base(options)
        {
        }
        public DbSet<TiempoItem> Tiempo { get; set; }
    }
}