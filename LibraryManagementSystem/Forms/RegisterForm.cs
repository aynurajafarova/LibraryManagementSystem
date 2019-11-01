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
    public partial class RegisterForm : Form
    {
        private readonly LibrarianService _librarianService;

        public RegisterForm()
        {
            InitializeComponent();

            _librarianService = new LibrarianService();
        }

        private void BtnRegister_Click(object sender, EventArgs e)
        {
            Librarian librarian = new Librarian()
            {
                Username = TxtUsername.Text,
                Email=TxtEmail.Text,
                Password=TxtPassword.Text,
                Phone=TxtPhone.Text
            };

            if (string.IsNullOrEmpty(TxtEmail.Text) ||
                string.IsNullOrEmpty(TxtPassword.Text) || 
                string.IsNullOrEmpty(TxtPhone.Text) || 
                string.IsNullOrEmpty(TxtUsername.Text))
            {
                MessageBox.Show("please fill all fields");
            }
            else
            {
                _librarianService.Add(librarian);

                ShowLoginForm();
              
            }
            
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            ShowLoginForm();
        }

        private void ShowLoginForm()
        {
            this.Hide();

            LoginForm loginForm = new LoginForm();
            loginForm.ShowDialog();
        }

        #region TextBoxDetails
        private void SelectedInput()
        {
            if (TxtUsername.Text == string.Empty)
            {
                TxtUsername.Text = "Username";
            }
            if (TxtEmail.Text == string.Empty)
            {
                TxtEmail.Text = "Email";
            }
            if (TxtPassword.Text == string.Empty)
            {
                TxtPassword.Text = "Password";
            }
            if (TxtPhone.Text == string.Empty)
            {
                TxtPhone.Text = "Phone";
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

        private void TxtEmail_MouseDown(object sender, MouseEventArgs e)
        {
            TxtEmail.Text = string.Empty;
        }

        private void TxtPassword_MouseDown(object sender, MouseEventArgs e)
        {
            TxtPassword.Text = string.Empty;
        }

        private void TxtPhone_MouseDown(object sender, MouseEventArgs e)
        {
            TxtPhone.Text = string.Empty;
        }



        //private void TxtUsername_MouseDown(object sender, MouseEventArgs e)
        //{
        //    foreach (Control c in this.Controls)
        //    {
        //        TxtUsername.Text = string.Empty;
        //        TxtEmail.Text = string.Empty;
        //        TxtPassword.Text = string.Empty;
        //        TxtPhone.Text = string.Empty;
        //    }
        //}
        #endregion

    }
}
