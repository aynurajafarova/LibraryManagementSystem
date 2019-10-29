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

        public DbSet<User> Users { get; set; }
       

    }
}
