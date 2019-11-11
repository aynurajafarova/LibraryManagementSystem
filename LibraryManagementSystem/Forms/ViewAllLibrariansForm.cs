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


        // This event will close the current - ViewAllLibrariansForm form and open the MainboardForm
        private void BtnBackArrow_Click(object sender, System.EventArgs e)
        {
            this.Hide();
           
            MainboardForm mainboardForm = new MainboardForm();
            mainboardForm.Show();
        }


        // This event will close the current - ViewAllLibrariansForm form and open the EditLibrariansForm
        private void BtnEditLibrarians_Click(object sender, System.EventArgs e)
        {
            this.Hide();

            EditLibrariansForm editLibrariansForm = new EditLibrariansForm();
            editLibrariansForm.Show();
        }


        // This event will look for librarians in the database
        private void BtnSearchLibrarian_Click(object sender, System.EventArgs e)
        {
            string librarianUsername = TxtLibrarianName.Text;
            string librarianEmail = TxtLibrarianEmail.Text;
            string librarianPhone = TxtLibrarianPhone.Text;
            int findedLibrarian = 0;

            DgvViewAllLibrarians.Rows.Clear();

            foreach (var librarian in _librarianService.AllLibrarians())
            {
                if(librarian.Username.Contains(librarianUsername)&& librarian.Email.Contains(librarianEmail)&& librarian.Phone.Contains(librarianPhone))
                {
                    DgvViewAllLibrarians.Rows.Add(librarian.Username,
                                                  librarian.Password,
                                                  librarian.Email,
                                                  librarian.Phone);
                    findedLibrarian += 1;
                }
               
            }
            if (findedLibrarian == 0)
            {
                MessageBox.Show("Sistemdə belə biri tapılmadı");
            }
        }
    }
}
