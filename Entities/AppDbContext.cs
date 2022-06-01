using Microsoft.EntityFrameworkCore;

namespace GorevYoneticisi4.Entities
{
    public class AppDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-KB0CBRS\\SQLEXPRESS;Database=dbGorevYonetici;Integrated Security=true;");
        }

        public DbSet<Gorevler> Gorevler { get; set; }
    }
}
