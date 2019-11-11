using LibraryManagementSystem.Services;
using System;
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
            
            FillBooksTable();
        }

        // This method help us to fill the DgvViewAllBooks table
        private void FillBooksTable()
        {
            foreach (var book in _bookService.AllBooks())
            {
                DgvViewAllBooks.Rows.Add(book.Name,
                                         book.Author,
                                         book.Price.ToString("0.00 $"),
                                         book.Quantity,
                                         book.PurchaseDate);
            }

        }


        // This event will look for books in the database
        private void BtnSearchBook_Click(object sender, System.EventArgs e)
        {

            string bookName = TxtBookName.Text;
            string bookAuthor = TxtBookAuthor.Text;
            decimal bookPrice = NumBookPrice.Value;
            int findedBook = 0;

            DgvViewAllBooks.Rows.Clear();

            foreach (var book in _bookService.AllBooks())
            {
               
                if (book.Name.Contains(bookName)&& book.Author.Contains(bookAuthor)&& decimal.Floor(book.Price)==bookPrice)
                {


                    DgvViewAllBooks.Rows.Add(book.Name,
                                         book.Author,
                                         book.Price.ToString("0.00 $"),
                                         book.Quantity,
                                         book.PurchaseDate);
                    findedBook += 1;
                   
                }       
            }
            if (findedBook == 0)
            {
                MessageBox.Show("Sistemdə belə bir kitab tapılmadı");
            }
        }


        // This event will close the current - ViewAllBooksForm form and open the MainboardForm
        private void BtnBackArrow_Click(object sender, EventArgs e)
        {
            this.Hide();

            MainboardForm mainboardForm = new MainboardForm();
            mainboardForm.Show();
        }


        // This event will close the current - ViewAllBooksForm form and open the EditBooksForm
        private void BtnEditBooks_Click(object sender, EventArgs e)
        {
            this.Hide();

            EditBooksForm editBooksForm = new EditBooksForm();
            editBooksForm.Show();
        }

       
    }
}
