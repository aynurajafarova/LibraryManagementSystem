using LibraryManagementSystem.Models;
using LibraryManagementSystem.Services;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace LibraryManagementSystem.Forms
{
    public partial class ViewAllBooksForm : Form
    {
        private readonly BookService _bookService;

        public ViewAllBooksForm()
        {
            InitializeComponent();

            _bookService = new BookService();
            //foreach (var book in _bookService.AllBooks())
            //{

            //    DgvViewAllBooks.Rows.Add(book.Id,
            //                             book.Name, 
            //                             book.Author, 
            //                             book.Price.ToString("0.00 $"), 
            //                             book.Quantity,
            //                             book.PurchaseDate);
            //}
            FillBooksTable();
        }

        // This method help us to fill the DgvViewAllBooks table
        private void FillBooksTable()
        {
            foreach (var book in _bookService.AllBooks())
            {
                DgvViewAllBooks.Rows.Add(book.Id,
                                         book.Name,
                                         book.Author,
                                         book.Price.ToString("0.00 $"),
                                         book.Quantity,
                                         book.PurchaseDate);
            }

            //var books = _bookService.AllBooks();
        }

        private void BtnSearchBook_Click(object sender, System.EventArgs e)
        {
            //var searchResultList = _bookService.Search(TxtBookName.Text, 
            //                                           TxtBookAuthor.Text, 
            //                                           Convert.ToDecimal(NumBookPrice));

            //DgvViewAllBooks.Rows.Clear();

            //foreach (var book in _bookService.AllBooks())
            //{
            //    DgvViewAllBooks.Rows.Add(book.Name,
            //                             book.Author, 
            //                             book.Price);
            //}

            string bookName = TxtBookName.Text;
            string bookAuthor = TxtBookAuthor.Text;
            decimal bookPrice = NumBookPrice.Value;

            DgvViewAllBooks.Rows.Clear();

            foreach (var book in _bookService.AllBooks())
            {
               
                if (book.Name.Contains(bookName) && book.Author.Contains(bookAuthor) && decimal.Floor(book.Price)==bookPrice)
                {

                   
                    DgvViewAllBooks.Rows.Add(book.Id,
                                        book.Name,
                                        book.Author,
                                        book.Price.ToString("0.00 $"),
                                        book.Quantity,
                                        book.PurchaseDate);
                }
                
               
            }

            //FillBooksTable();


        }
    }
}
