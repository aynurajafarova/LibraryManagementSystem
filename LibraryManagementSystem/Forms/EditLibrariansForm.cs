using LibraryManagementSystem.Models;
using LibraryManagementSystem.Services;
using System;
using System.Windows.Forms;

namespace LibraryManagementSystem.Forms
{
    public partial class EditLibrariansForm : Form
    {
        private readonly LibrarianService _librarianService;

        private Librarian _selectedLibrarian;

        private int _selectedRowIndex;
        public EditLibrariansForm()
        {
            InitializeComponent();

            _librarianService = new LibrarianService();

            BtnDelete.Hide();
            BtnUpdate.Hide();

            FillMembersDgv();
        }


        // This method will fill the DgvViewAllLibrarians 
        private void FillMembersDgv()
        {
            foreach (var librarian in _librarianService.AllLibrarians())
            {
                DgvViewAllLibrarians.Rows.Add(librarian.Id, 
                                              librarian.Username,
                                              librarian.Email, 
                                              librarian.Password, 
                                              librarian.Phone);
            }
        }


        private void DgvViewAllLibrarians_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            _selectedLibrarian = _librarianService.FindId(Convert.ToInt32(DgvViewAllLibrarians.Rows[e.RowIndex].Cells[0].Value));
            _selectedRowIndex = e.RowIndex;

            TxtLibrarianName.Text = _selectedLibrarian.Username;
            TxtLibrarianEmail.Text = _selectedLibrarian.Email;
            TxtLibrarianPassword.Text = _selectedLibrarian.Password;
            TxtLibrarianPhone.Text = _selectedLibrarian.Phone;

            BtnAdd.Hide();
            BtnDelete.Show();
            BtnUpdate.Show();
        }


        // This event will add new librarian 
        private void BtnAdd_Click(object sender, EventArgs e)
        {
            Librarian librarian = new Librarian
            {
                Username = TxtLibrarianName.Text,
                Email = TxtLibrarianEmail.Text,
                Password = TxtLibrarianPassword.Text,
                Phone = TxtLibrarianPhone.Text
            };

            _librarianService.Add(librarian);

            DgvViewAllLibrarians.Rows.Add(librarian.Id,
                                          librarian.Username,
                                          librarian.Email,
                                          librarian.Password,
                                          librarian.Phone);

            MessageBox.Show(TxtLibrarianName.Text + " adlı şəxs əlavə olundu", "Əlavə olundu");

            Reset();
        }


        // This event will delete the selected librarian
        private void BtnDelete_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bu əməliyyatı yerinə yetirmək istədiyinizə əminsiniz?", "Silmə", MessageBoxButtons.YesNo);

            if (dialogResult == DialogResult.Yes) 
            {
                _librarianService.Delete(_selectedLibrarian);

                DgvViewAllLibrarians.Rows.RemoveAt(_selectedRowIndex);

                MessageBox.Show(TxtLibrarianName.Text + " adlı istifadəçi bazadan silindi", "Silindi!");

                Reset();
            }
        }


        // The event will update the information about the selected librarian
        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            _selectedLibrarian.Username = TxtLibrarianName.Text;
            _selectedLibrarian.Email = TxtLibrarianEmail.Text;
            _selectedLibrarian.Password = TxtLibrarianPassword.Text;
            _selectedLibrarian.Phone = TxtLibrarianPhone.Text;

            _librarianService.Update(_selectedLibrarian);

            Reset();

            DgvViewAllLibrarians.Rows[_selectedRowIndex].Cells[1].Value = _selectedLibrarian.Username;
            DgvViewAllLibrarians.Rows[_selectedRowIndex].Cells[2].Value = _selectedLibrarian.Email;
            DgvViewAllLibrarians.Rows[_selectedRowIndex].Cells[3].Value = _selectedLibrarian.Password;
            DgvViewAllLibrarians.Rows[_selectedRowIndex].Cells[4].Value = _selectedLibrarian.Phone;

            MessageBox.Show("Məlumat uğurla yeniləndi", "Yeniləndi!");
        }

        private void Reset()
        {
            TxtLibrarianName.Clear();
            TxtLibrarianPassword.Clear();
            TxtLibrarianPhone.Clear();
            TxtLibrarianEmail.Clear();
        }


        // This event will close the current - EditLibrariansForm form and open the ViewAllLibrariansForm
        private void BtnBackArrow_Click(object sender, EventArgs e)
        {
            this.Hide();

            ViewAllLibrariansForm viewAllLibrariansForm = new ViewAllLibrariansForm();
            viewAllLibrariansForm.Show();
        }


        // This event will close the current - EditLibrariansForm form and open the MainboardForm
        private void BtnEditLibrarians_Click(object sender, EventArgs e)
        {
            this.Hide();

            MainboardForm mainboardForm = new MainboardForm();
            mainboardForm.Show();
        }
    }
}
