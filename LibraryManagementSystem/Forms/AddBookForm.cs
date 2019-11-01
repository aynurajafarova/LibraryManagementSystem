using LibraryManagementSystem.Models;
using LibraryManagementSystem.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryManagementSystem.Forms
{
    public partial class AddBookForm : Form
    {
        private readonly BookService _bookService;

        public AddBookForm()
        {
            InitializeComponent();

            _bookService = new BookService();
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            Book book = new Book()
            {
                Name = TxtBookName.Text,
                Author = TxtAuthorName.Text,
                Price = NumBookPrice.Value,
                Quantity = Convert.ToInt32(TxtNumberOfBooks.Text)
            };

            if(string.IsNullOrEmpty(TxtBookName.Text) || 
                string.IsNullOrEmpty(TxtAuthorName.Text) || 
                string.IsNullOrEmpty(Convert.ToString(NumBookPrice.Value)) || 
                string.IsNullOrEmpty(TxtNumberOfBooks.Text))
            {
                MessageBox.Show("Please complete all required fields");
            }
            else
            {
                _bookService.Add(book);
                MessageBox.Show("Added a book called " + TxtBookName.Text);

                TxtBookName.Text = string.Empty;
                TxtAuthorName.Text = string.Empty;
                NumBookPrice.Value = 0;
                TxtNumberOfBooks.Text = string.Empty;
            }

        }
    }
}
