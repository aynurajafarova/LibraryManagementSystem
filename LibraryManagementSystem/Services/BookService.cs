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
            if (!this.Contains(book.Id))
            {
                //throw new Exception("This book does not exist");
                throw new NullReferenceException();
            }

            _libraryContext.Entry(book).State = System.Data.Entity.EntityState.Modified;
            _libraryContext.SaveChanges();
        }

        public void Delete(Book book)
        {
            if (!this.Contains(book.Id))
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

        public Book Find(int id)
        {
            Book book = _libraryContext.Books.Find(id);

            return book;
        }

        public bool Contains(int id)
        {
            return _libraryContext.Books.Any(b => b.Id == id);
        }

        //public List<Book> Search(string book)
        //{
        //    foreach (var book in _bookService.AllBooks())
        //    {
        //        if (book.Name.Contains(bookName))
        //        {
        //            DgvViewAllBooks.Rows.Clear();
        //            DgvViewAllBooks.Rows.Add(book.Id,
        //                                book.Name,
        //                                book.Author,
        //                                book.Price.ToString("0.00 $"),
        //                                book.Quantity,
        //                                book.PurchaseDate);
        //        }

        //    }
        //}
    }
}
