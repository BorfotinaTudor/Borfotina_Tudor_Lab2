using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Borfotina_Tudor_Lab2.Models;

namespace Borfotina_Tudor_Lab2.Data
{
    public class Borfotina_Tudor_Lab2Context : DbContext
    {
        public Borfotina_Tudor_Lab2Context (DbContextOptions<Borfotina_Tudor_Lab2Context> options)
            : base(options)
        {
        }

        public DbSet<Borfotina_Tudor_Lab2.Models.Author> Author { get; set; } = default!;
        public DbSet<Borfotina_Tudor_Lab2.Models.Genre> Genre { get; set; } = default!;
    }
}
