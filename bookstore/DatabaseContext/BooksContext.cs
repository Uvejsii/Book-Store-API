global using Microsoft.EntityFrameworkCore;

namespace bookstore.DatabaseContext 
{
    public class BooksContext : DbContext
    {
        public BooksContext(DbContextOptions<BooksContext> options) : base(options)
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Server=.\\SQLExpress;Database=bookapidb;Trusted_Connection=true;TrustServerCertificate=true");
        }

        public DbSet<Book> Books => Set<Book>();
    }
}