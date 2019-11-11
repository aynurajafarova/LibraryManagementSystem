using System;
using System.Windows.Forms;

namespace LibraryManagementSystem.Forms
{
    public partial class MainboardForm : Form
    {
        public MainboardForm()
        {
            InitializeComponent();
        }

       
        // With this event we can exit the program
        private void BtnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

       
        // This event opens the ViewAllLibrariansForm form
        private void BtnLibrarians_Click(object sender, EventArgs e)
        {
            this.Hide();

            ViewAllLibrariansForm viewAllLibrariansForm = new ViewAllLibrariansForm();
            viewAllLibrariansForm.Show();
        }

       
        // This event opens the ViewAllMembersForm form.
        private void BtnMembers_Click(object sender, EventArgs e)
        {
            this.Hide();

            ViewAllMembersForm viewAllMembersForm = new ViewAllMembersForm();
            viewAllMembersForm.Show();
        }

        
        // This event opens the ViewAllBooksForm form.
        private void BtnBooks_Click(object sender, EventArgs e)
        {
            this.Hide();

            ViewAllBooksForm viewAllBooksForm = new ViewAllBooksForm();
            viewAllBooksForm.Show();
        }

        
        // This event opens the OrderForm form.
        private void BtnNewBookOrder_Click(object sender, EventArgs e)
        {
            this.Close();

            OrderForm orderForm = new OrderForm();
            orderForm.Show();
        }

        
        // This event opens the ReturnBookForm form.
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();

            ReturnBookForm returnBookForm = new ReturnBookForm();
            returnBookForm.Show();
        }

        
        // This event opens the ReportForm form.
        private void BtnReport_Click(object sender, EventArgs e)
        {
            this.Close();

            ReportForm reportForm = new ReportForm();
            reportForm.Show();
        }
    }
}
