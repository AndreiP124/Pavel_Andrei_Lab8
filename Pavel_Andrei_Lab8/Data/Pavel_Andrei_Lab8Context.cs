using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Pavel_Andrei_Lab8.Models;

namespace Pavel_Andrei_Lab8.Data
{
    public class Pavel_Andrei_Lab8Context : DbContext
    {
        public Pavel_Andrei_Lab8Context (DbContextOptions<Pavel_Andrei_Lab8Context> options)
            : base(options)
        {
        }

        public DbSet<Pavel_Andrei_Lab8.Models.Book> Book { get; set; }

        public DbSet<Pavel_Andrei_Lab8.Models.Publisher> Publisher { get; set; }

        public DbSet<Pavel_Andrei_Lab8.Models.Category> Category { get; set; }
    }
}
