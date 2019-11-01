﻿using LibraryManagementSystem.DAL;
using LibraryManagementSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    }
}
