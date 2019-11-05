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


    }
}
