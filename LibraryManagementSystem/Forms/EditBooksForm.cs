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
    public partial class EditBooksForm : Form
    {
        private readonly BookService _bookService;

        private Book _selectedBook;

        private int _selectedRowIndex;

        public EditBooksForm()
        {
            InitializeComponent();

            _bookService = new BookService();

            _selectedBook = new Book();

            FillBooks();
        }

        private void FillBooks()
        {
            foreach (var book in _bookService.AllBooks())
            {
                DgvBooks.Rows.Add(book.Id,
                                  book.Name,
                                  book.Author,
                                  book.Price,
                                  book.Quantity);
            }
        }


        private void DgvBooks_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            _selectedBook = _bookService.Find(Convert.ToInt32(DgvBooks.Rows[e.RowIndex].Cells[0].Value));

            _selectedRowIndex = e.RowIndex;

            TxtBookName.Text = _selectedBook.Name;
            TxtBookAuthor.Text = _selectedBook.Author;
            TxtBookPrice.Text = Convert.ToString(_selectedBook.Price);
            TxtBookQuantity.Text = _selectedBook.Quantity.ToString();
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            _selectedBook.Name = TxtBookName.Text;
            _selectedBook.Author = TxtBookAuthor.Text;
            _selectedBook.Price = Convert.ToDecimal(TxtBookPrice.Text);
            _selectedBook.Quantity = Convert.ToInt32(TxtBookQuantity.Text);

            _bookService.Update(_selectedBook);

            Reset();

            DgvBooks.Rows[_selectedRowIndex].Cells[1].Value = _selectedBook.Name;
            DgvBooks.Rows[_selectedRowIndex].Cells[2].Value = _selectedBook.Author;
            DgvBooks.Rows[_selectedRowIndex].Cells[3].Value = _selectedBook.Price.ToString("0.00 $");
            DgvBooks.Rows[_selectedRowIndex].Cells[4].Value = _selectedBook.Quantity;

            MessageBox.Show("Updated");
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure?", "Delete", MessageBoxButtons.YesNo);

            if (dialogResult == DialogResult.Yes)
            {
                _bookService.Delete(_selectedBook);

                DgvBooks.Rows.RemoveAt(_selectedRowIndex);
                MessageBox.Show("Done");
                Reset();
            }
        }

        private void Reset()
        {
            TxtBookName.Clear();
            TxtBookAuthor.Clear();
            TxtBookPrice.Clear();
            TxtBookQuantity.Clear();
        }
    }
}
