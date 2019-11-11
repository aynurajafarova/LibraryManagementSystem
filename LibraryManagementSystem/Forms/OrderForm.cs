using LibraryManagementSystem.Helpers;
using LibraryManagementSystem.Models;
using LibraryManagementSystem.Services;
using System;
using System.Windows.Forms;

namespace LibraryManagementSystem.Forms
{
    public partial class OrderForm : Form
    {
        private readonly BookService _bookService;
        private readonly MemberService _memberService;
        private readonly OrderService _orderService;


        private Member _selectedMember;
        private Book _selectedBook;

        public OrderForm()
        {
            InitializeComponent();

            _bookService = new BookService();
            _memberService = new MemberService();
            _orderService = new OrderService();

            _selectedMember = new Member();
            _selectedBook = new Book();

            FillMembersCombo();
            FillBooks();
            FillOrderTable();
        }


        // This method help us to fill the CmbMember
        private void FillMembersCombo()
        {
            foreach (Member member in _memberService.AllMembers())
            {
                CmbMember.Items.Add(new ComboItem(member.Id, member.Fullname));
            }
        }


        // This method help us to fill the DgvAllBooks
        private void FillBooks()
        {
            foreach (var book in _bookService.AllBooks())
            {
                if (book.Quantity > 0)
                {
                    DgvAllBooks.Rows.Add(book.Id, book.Name, book.Price, book.Author);
                }
            }
        }

        private void DgvAllBooks_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (_selectedMember == null)
            {
                MessageBox.Show("Zehmet olmasa, kitab goturecek istifaddechi sechin");
                return;
            }
            int Id = Convert.ToInt32(DgvAllBooks.Rows[e.RowIndex].Cells[0].Value);
            _selectedBook = _bookService.Find(Id);

            TxtBookName.Text = _selectedBook.Name;
        }


        private void CmbMember_SelectedIndexChanged(object sender, EventArgs e)
        {
            _selectedMember = _memberService.Find((CmbMember.SelectedItem as ComboItem).Id);
           
            CmbMember.Text = _selectedMember.Fullname;

            //Reset();

            //DgvOrders.Rows.Clear();
            FillOrderTable();
        }


        // This method help us to fill the DgvOrders
        private void FillOrderTable()
        {
            if (_selectedMember != null)
            {
                foreach (Book book in _bookService.AllBooks())
                {
                    foreach (Order order in _orderService.Orders())
                    {
                        if (order.MemberId == _selectedMember.Id && book.Id == order.BookId)
                        {
                            DgvOrders.Rows.Clear();
                            DgvOrders.Rows.Add(order.Id, order.Book.Name, order.OrderDate, order.MustBeReturned, order.Cost, order.Returned);
                        }
                    }
                }
            }
        }


        // This method will add new orders
        public void AddNewOrder()
        {
            Order order = new Order()
            {
                MemberId = _selectedMember.Id,
                BookId = _selectedBook.Id,
                OrderDate = DateTime.Now,
                ReturnDate = DtpReturnDate.Value,
                Cost = _selectedBook.Price,
                Returned = false
            };

            _orderService.Add(order);

            _selectedBook.Quantity--;

            _bookService.Update(_selectedBook);

            DgvOrders.Rows.Add(_selectedMember.Fullname, _selectedBook.Name, DateTime.Now, DtpReturnDate.Value, _selectedBook.Price, false);

            Reset();
        }

        private void Reset()

        {
            TxtBookName.Text = string.Empty;
            DtpReturnDate.Value = DateTime.Now;
        }




        // Clicking this button will create a new order
        private void BtnAddOrder_Click(object sender, EventArgs e)
        {
            if (DtpReturnDate.Value < DateTime.Now)
            {
                MessageBox.Show("Qaytarilacaq tarix kitab goturulen tarixden kicik olmamalidi");
                //MessageBox.Show(_selectedMember.Id.ToString());

                return;
            }

            foreach (Order order in _orderService.Orders())
            {
                if (order.MemberId == _selectedMember.Id && order.BookId == _selectedBook.Id && order.Returned == false)
                {
                    DialogResult result = MessageBox.Show("Bu istifadəçinin artıq kitabı var, yenisi əlavə olunsun?", "Bildirish", MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes)
                    {
                        AddNewOrder();
                    }

                    Reset();

                    return;
                }
            }
            AddNewOrder();
        }


        // This event will close the current - OrderForm form and open the MainboardForm
        private void BtnBackArrow_Click(object sender, EventArgs e)
        {
            this.Hide();

            MainboardForm mainboardForm = new MainboardForm();
            mainboardForm.Show();
        }

        private void BtnBackArrow_Click_1(object sender, EventArgs e)
        {
            this.Hide();

            MainboardForm mainboardForm = new MainboardForm();
            mainboardForm.Show();
        }
    }
}
