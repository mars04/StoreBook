using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using StoreBook.Models;

namespace StoreBook.Models
{
    public class StoreBookContext : DbContext
    {
        public StoreBookContext (DbContextOptions<StoreBookContext> options)
            : base(options)
        {
        }

        public DbSet<StoreBook.Models.Book> Book { get; set; }

        public DbSet<StoreBook.Models.Author> Author { get; set; }

        public DbSet<StoreBook.Models.Editor> Editor { get; set; }

        public DbSet<StoreBook.Models.Genre> Genre { get; set; }

        public DbSet<StoreBook.Models.Publish> Publish { get; set; }

        public DbSet<StoreBook.Models.Series> Series { get; set; }

    }
}
