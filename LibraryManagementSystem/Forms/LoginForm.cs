using LibraryManagementSystem.Models;
using LibraryManagementSystem.Services;
using System;
using System.Windows.Forms;

namespace LibraryManagementSystem.Forms
{
    public partial class LoginForm : Form
    {
        private readonly LibrarianService _librarianService;

        public LoginForm()
        {
            InitializeComponent();

            _librarianService = new LibrarianService();
        }


        #region TextBoxDetails
        private void SelectedInput()
        {
            if(TxtUsername.Text == string.Empty)
            {
                TxtUsername.Text = "Username";
            }

            if (TxtPassword.Text == string.Empty)
            {
                TxtPassword.Text = "Password";
            }
        }


        private void TxtUsername_Enter(object sender, EventArgs e)
        {
            SelectedInput();
        }


        private void TxtUsername_MouseDown(object sender, MouseEventArgs e)
        {
            TxtUsername.Text = string.Empty;
        }

        private void TxtPassword_MouseDown(object sender, MouseEventArgs e)
        {
            TxtPassword.Text = string.Empty;
        }

        #endregion


        private void BtnLogin_Click_1(object sender, EventArgs e)
        {
            Librarian librarian = new Librarian()
            {
                Username = TxtUsername.Text,
                Password = TxtPassword.Text
            };

            Librarian findedUser = _librarianService.Find(librarian.Username, librarian.Password);

            if (findedUser != null)
            {
                this.Hide();

                MainboardForm mainboardForm = new MainboardForm();
                mainboardForm.Show();
            }
            else
            {
                LblLoginErrors.Text = "Username or password is not valid.";
            }
        }
    }
}
