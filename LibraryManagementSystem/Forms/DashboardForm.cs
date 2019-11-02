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
    public partial class DashboardForm : Form
    {
        private string _username;

        public DashboardForm( string Username)
        {
            InitializeComponent();
            this._username = Username;
            LblUsername.Text = Username + " , Welcome";
        }

        private void DashboardForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void addNewBookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddBookForm addBookForm = new AddBookForm();
            addBookForm.Show();
        }

        private void addNewMemberToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddMemberForm addMemberForm = new AddMemberForm();
            addMemberForm.Show();
        }

        private void viewAllBooksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ViewAllBooksForm viewAllBooksForm = new ViewAllBooksForm();
            viewAllBooksForm.Show();
        }

        private void viewAllMembersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ViewAllMembersForm viewAllMembersForm = new ViewAllMembersForm();
            viewAllMembersForm.Show();
        }

        private void viewAllLibrariansToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ViewAllLibrariansForm viewAllLibrariansForm = new ViewAllLibrariansForm();
            viewAllLibrariansForm.Show();
        }

        private void addNewLibrarianToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddLibrarianForm addLibrarianForm = new AddLibrarianForm();
            addLibrarianForm.Show();
        }
    }
}
