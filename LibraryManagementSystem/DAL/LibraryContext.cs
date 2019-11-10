using LibraryManagementSystem.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem.DAL
{
    class LibraryContext:DbContext
    {
        public LibraryContext() : base("LibraryContext") { }

        public DbSet<Librarian> Librarians { get; set; }

        public DbSet<Book> Books { get; set; }

        public DbSet<Member> Members { get; set; }

        public DbSet<Order> Orders { get; set; }


    }
}
