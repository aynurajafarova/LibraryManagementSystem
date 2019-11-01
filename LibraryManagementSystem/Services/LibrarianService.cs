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

        public void Update(Librarian librarian)
        {
            if (!this.Contains(librarian))
            {
                throw new NullReferenceException();
            }

            _libraryContext.Entry(librarian).State = System.Data.Entity.EntityState.Modified;
            _libraryContext.SaveChanges();
        }

        public void Delete(Librarian librarian)
        {
            if (!this.Contains(librarian))
            {
                throw new NullReferenceException();
            }

            _libraryContext.Librarians.Remove(librarian);
            _libraryContext.SaveChanges();
        }

        public List<Librarian> AllLibrarians()
        {
            return _libraryContext.Librarians.ToList();
        }

        public Librarian Find(string username, string password)
        {
            Librarian librarian = _libraryContext.Librarians.FirstOrDefault(l=>l.Username==username && l.Password==password);

            return librarian;
        }

        public bool Contains(Librarian librarian)
        {
            return _libraryContext.Librarians.Contains(librarian);
        }
    }
}
