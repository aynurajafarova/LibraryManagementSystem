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
    public partial class MainboardForm : Form
    {
        public MainboardForm()
        {
            InitializeComponent();
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnLibrarians_Click(object sender, EventArgs e)
        {
            this.Hide();

            ViewAllLibrariansForm viewAllLibrariansForm = new ViewAllLibrariansForm();
            viewAllLibrariansForm.Show();
        }

        private void BtnMembers_Click(object sender, EventArgs e)
        {
            this.Hide();

            ViewAllMembersForm viewAllMembersForm = new ViewAllMembersForm();
            viewAllMembersForm.Show();
        }

        private void BtnBooks_Click(object sender, EventArgs e)
        {
            this.Hide();

            ViewAllBooksForm viewAllBooksForm = new ViewAllBooksForm();
            viewAllBooksForm.Show();
        }
    }
}
