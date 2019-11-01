using LibraryManagementSystem.Services;
using System.Windows.Forms;

namespace LibraryManagementSystem.Forms
{
    public partial class ViewAllLibrariansForm : Form
    {
        private readonly LibrarianService _librarianService;
        public ViewAllLibrariansForm()
        {
            InitializeComponent();

            _librarianService = new LibrarianService();

            FillLibrariansTable();
        }


        // This method help us to fill the DgvViewAllLibrarians table
        private void FillLibrariansTable()
        {
            foreach (var librarian in _librarianService.AllLibrarians())
            {
                DgvViewAllLibrarians.Rows.Add(librarian.Username, 
                                              librarian.Password, 
                                              librarian.Email, 
                                              librarian.Phone);
            }
        }
    }
}
