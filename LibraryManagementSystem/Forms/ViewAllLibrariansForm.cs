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

        private void BtnBackArrow_Click(object sender, System.EventArgs e)
        {
            this.Hide();
           
            MainboardForm mainboardForm = new MainboardForm();
            mainboardForm.Show();
        }

        private void BtnEditLibrarians_Click(object sender, System.EventArgs e)
        {
            this.Hide();

            EditLibrariansForm editLibrariansForm = new EditLibrariansForm();
            editLibrariansForm.Show();
        }

        private void BtnSearchLibrarian_Click(object sender, System.EventArgs e)
        {
            string librarianUsername = TxtLibrarianName.Text;
            string librarianEmail = TxtLibrarianEmail.Text;
            string librarianPhone = TxtLibrarianPhone.Text;

            DgvViewAllLibrarians.Rows.Clear();

            foreach (var librarian in _librarianService.AllLibrarians())
            {
                if(librarian.Username.Contains(librarianUsername)&& librarian.Email.Contains(librarianEmail)&& librarian.Phone.Contains(librarianPhone))
                {
                    DgvViewAllLibrarians.Rows.Add(librarian.Username,
                                                  librarian.Password,
                                                  librarian.Email,
                                                  librarian.Phone);
                }
                else
                {
                    MessageBox.Show("Sistemdə belə biri tapılmadı");
                }
            }
        }
    }
}
