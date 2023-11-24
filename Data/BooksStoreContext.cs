using Microsoft.EntityFrameworkCore;

namespace BookShoop.Data
{
    public class BooksStoreContext : DbContext
    {

        public BooksStoreContext(DbContextOptions<BooksStoreContext> options) 
            : base (options)
        {
             
        }

        public DbSet<Books> Books { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=localhost;Initial Catalog=BookStore;" +
            "Integrated Security=True;TrustServerCertificate=True; User Id=sa; Password=Genovese123!;");
            base.OnConfiguring(optionsBuilder);
        }
    }
}
