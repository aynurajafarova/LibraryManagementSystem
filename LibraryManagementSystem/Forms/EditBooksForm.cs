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

            BtnAdd.Show();
            BtnDelete.Hide();
            BtnUpdate.Hide();
        }

        private void FillBooks()
        {
            foreach (var book in _bookService.AllBooks())
            {
                DgvBooks.Rows.Add(book.Id,
                                  book.Name,
                                  book.Author,
                                  book.Price,
                                  book.Quantity,
                                  book.PurchaseDate);
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
            DtpPurchaseDate.Value = _selectedBook.PurchaseDate.Date;

            BtnAdd.Hide();
            BtnDelete.Show();
            BtnUpdate.Show();
        }


        private void Reset()
        {
            TxtBookName.Clear();
            TxtBookAuthor.Clear();
            TxtBookPrice.ResetText();
            TxtBookQuantity.Clear();
            DtpPurchaseDate.ResetText();  
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            Book book = new Book()
            {
                Name = TxtBookName.Text,
                Author = TxtBookAuthor.Text,
                Price = Convert.ToDecimal(TxtBookPrice.Value),
                Quantity = Convert.ToInt32(TxtBookQuantity.Text),
                PurchaseDate = Convert.ToDateTime(DtpPurchaseDate.Value)
            };

            if (string.IsNullOrEmpty(TxtBookName.Text) ||
                string.IsNullOrEmpty(TxtBookAuthor.Text) ||
                string.IsNullOrEmpty(Convert.ToString(TxtBookPrice.Value)) ||
                string.IsNullOrEmpty(Convert.ToString(TxtBookQuantity.Text)) ||
                string.IsNullOrEmpty(Convert.ToString(DtpPurchaseDate.Value)))
            {
                MessageBox.Show("Zəhmət olmasa, bütün məlumatları daxil edin", "Uğursuz əməliyyat!");
            }
            else
            {
                _bookService.Add(book);

                DgvBooks.Rows.Add(book.Id,
                                  book.Name,
                                  book.Author,
                                  book.Price,
                                  book.Quantity,
                                  book.PurchaseDate);

                MessageBox.Show(TxtBookName.Text+" adlı yeni kitab əlavə olundu");

                Reset();
            }
        }

        private void BtnUpdate_Click_1(object sender, EventArgs e)
        {
            _selectedBook.Name = TxtBookName.Text;
            _selectedBook.Author = TxtBookAuthor.Text;
            _selectedBook.Price = Convert.ToDecimal(TxtBookPrice.Text);
            _selectedBook.Quantity = Convert.ToInt32(TxtBookQuantity.Text);
            _selectedBook.PurchaseDate = DtpPurchaseDate.Value;

            _bookService.Update(_selectedBook);

            Reset();

            DgvBooks.Rows[_selectedRowIndex].Cells[1].Value = _selectedBook.Name;
            DgvBooks.Rows[_selectedRowIndex].Cells[2].Value = _selectedBook.Author;
            DgvBooks.Rows[_selectedRowIndex].Cells[3].Value = _selectedBook.Price.ToString("0.00 $");
            DgvBooks.Rows[_selectedRowIndex].Cells[4].Value = _selectedBook.Quantity;
            DgvBooks.Rows[_selectedRowIndex].Cells[5].Value = _selectedBook.PurchaseDate;


            MessageBox.Show(_selectedBook.Name + " adlı kitab məlumatları yeniləndi", "Yeniləmə");
        }

        private void BtnDelete_Click_1(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bu kitabı silmək istədiyinizdən əminsiniz?", "Silmə", MessageBoxButtons.YesNo);

            if (dialogResult == DialogResult.Yes)
            {
                _bookService.Delete(_selectedBook);

                DgvBooks.Rows.RemoveAt(_selectedRowIndex);
                MessageBox.Show(_selectedBook.Name + " adlı kitab silindi", "Silmə");

                Reset();
            }
        }

        private void BtnBackArrow_Click(object sender, EventArgs e)
        {
            this.Hide();

            ViewAllBooksForm viewAllBooksForm = new ViewAllBooksForm();
            viewAllBooksForm.Show();
        }

        private void BtnMainboardForm_Click(object sender, EventArgs e)
        {
            this.Hide();

            MainboardForm mainboardForm = new MainboardForm();
            mainboardForm.Show();
        }
    }
}
