using Microsoft.EntityFrameworkCore;

namespace ControleFinanceiro.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Despesa> Despesas { get; set; }
    }
}
