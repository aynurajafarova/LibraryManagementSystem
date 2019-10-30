using LibraryManagementSystem.DAL;
using LibraryManagementSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem.Services
{
    class LibrarianService
    {
        private readonly LibraryContext _libraryContext;

        public LibrarianService()
        {
            _libraryContext = new LibraryContext();
        }

        public int Add(Librarian librarian)
        {
            _libraryContext.Librarians.Add(librarian);
            _libraryContext.SaveChanges();

            return librarian.Id;
        }

        public Librarian Find(string username, string password)
        {
            Librarian librarian = _libraryContext.Librarians.FirstOrDefault(l=>l.Username==username && l.Password==password);

            return librarian;
        }
    }
}
