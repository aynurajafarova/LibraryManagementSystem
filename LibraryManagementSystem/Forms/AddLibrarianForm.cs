using LibraryManagementSystem.Models;
using LibraryManagementSystem.Services;
using System;
using System.Windows.Forms;

namespace LibraryManagementSystem.Forms
{
    public partial class AddLibrarianForm : Form
    {
        private readonly LibrarianService _librarianService;

        public AddLibrarianForm()
        {
            InitializeComponent();

            _librarianService = new LibrarianService();
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            Librarian librarian = new Librarian
            {
                Username = TxtLibrarianUsername.Text,
                Email = TxtLibrarianEmail.Text,
                Password = TxtLibrarianPassword.Text,
                Phone = TxtLibrarianPhone.Text
            };

            if (string.IsNullOrEmpty(TxtLibrarianUsername.Text) ||
              string.IsNullOrEmpty(TxtLibrarianEmail.Text) ||
              string.IsNullOrEmpty(TxtLibrarianPassword.Text) ||
              string.IsNullOrEmpty(TxtLibrarianPhone.Text))
            {
                MessageBox.Show("Please complete all required fields");
            }
            else
            {
                _librarianService.Add(librarian);
                MessageBox.Show("Added: " + TxtLibrarianUsername.Text);

                TxtLibrarianUsername.Clear();
                TxtLibrarianEmail.Clear();
                TxtLibrarianPassword.Clear();
                TxtLibrarianPhone.Clear();
            }
        }
    }
}
