    using Microsoft.EntityFrameworkCore;
    using Borfotina_Tudor_Lab2.Models;
    namespace Borfotina_Tudor_Lab2.Data
    {
        public class LibraryContext : DbContext
        {
            public LibraryContext(DbContextOptions<LibraryContext> options) :
           base(options)
            {
            }
            public DbSet<Borfotina_Tudor_Lab2.Models.Book> Book { get; set; } = default!;
            public DbSet<Borfotina_Tudor_Lab2.Models.Customer> Customer { get; set; } = default!;
            public DbSet<Borfotina_Tudor_Lab2.Models.Genre> Genre { get; set; } = default!;
            public DbSet<Borfotina_Tudor_Lab2.Models.Author> Author { get; set; } = default!;

    }
}
