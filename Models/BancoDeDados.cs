using Microsoft.EntityFrameworkCore;

namespace CrudCsharpv2.Models
{
    public class BancoDeDados : DbContext
    {
        public DbSet<Usuario> Usuarios { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(connectionString: @"Server=DESKTOP-CM8F2OC\SQLEXPRESS;Database=DWTestesCrud; Integrated Security=True");
        }
    }
}
