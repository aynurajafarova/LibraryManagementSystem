using LibraryManagementSystem.Services;
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
                                         book.Quantity);
            }
        }
    }
}
