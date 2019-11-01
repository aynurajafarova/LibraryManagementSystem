using LibraryManagementSystem.DAL;
using LibraryManagementSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace LibraryManagementSystem.Services
{
    class BookService
    {
        private readonly LibraryContext _libraryContext;

        public BookService()
        {
            _libraryContext = new LibraryContext();
        }

        public int Add(Book book)
        {
            _libraryContext.Books.Add(book);
            _libraryContext.SaveChanges();

            return book.Id;
        }

        public void Update(Book book) 
        {
            if (!this.Contains(book))
            {
                //throw new Exception("This book does not exist");
                throw new NullReferenceException();
            }

            _libraryContext.Entry(book).State = System.Data.Entity.EntityState.Modified;
            _libraryContext.SaveChanges();
        }

        public void Delete(Book book) 
        {
            if (!this.Contains(book))
            {
                throw new NullReferenceException();
            }

            _libraryContext.Books.Remove(book);
            _libraryContext.SaveChanges();
        }

        public List<Book> AllBooks() 
        {
            return _libraryContext.Books.ToList();
        }

        public Book Find(int Id)
        {
          Book book = _libraryContext.Books.FirstOrDefault(b => b.Id == Id);

            return book;
        }

        public bool Contains(Book book)
        {
            return _libraryContext.Books.Contains(book);
        }
    }
}
