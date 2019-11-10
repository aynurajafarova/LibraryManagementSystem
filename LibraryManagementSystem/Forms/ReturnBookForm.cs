using LibraryManagementSystem.Helpers;
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
    public partial class ReturnBookForm : Form
    {
        private readonly BookService _bookService;
        private readonly OrderService _orderService;
        private readonly MemberService _memberService;

        private Member _selectedMember;
        private Order _selectedOrder;

        private int _selectedIndex;

        public ReturnBookForm()
        {
            InitializeComponent();

            _bookService = new BookService();
            _orderService = new OrderService();
            _memberService = new MemberService();

            _selectedMember = new Member();
            _selectedOrder = new Order();

            FillBooks();
            FillMemberCombo();
        }

        private void FillBooks()
        {
            if (_selectedMember != null)
            {
                CmbMember.SelectedItem = new ComboItem(_selectedMember.Id, _selectedMember.Fullname);
                CmbMember.Text = _selectedMember.Fullname;

                foreach (var book in _bookService.AllBooks())
                {
                    foreach (Order order in _orderService.Orders())
                    {
                        if (order.MemberId == _selectedMember.Id && book.Id == order.BookId)
                        {
                            DgvOrders.Rows.Add(order.Id, order.Book.Name, order.OrderDate, order.MustBeReturned, order.Cost, order.Returned);
                        }
                    }
                }
            }
        }

        private void FillMemberCombo()
        {
            foreach (Member member in _memberService.AllMembers())
            {
                CmbMember.Items.Add(new ComboItem(member.Id, member.Fullname));
            }
        }

        private void DgvOrders_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int id = Convert.ToInt32(DgvOrders.Rows[e.RowIndex].Cells[0].Value);
            _selectedIndex = e.RowIndex;

            _selectedOrder = _orderService.Find(id);

            if (_selectedOrder.Returned == false)
            {
                TxtReturningBook.Text = _selectedOrder.Book.Name;
                if ((DateTime.Now - _selectedOrder.OrderDate).Days < 1)
                {
                    BtnReturn.Hide();
                    BtnCancel.Show();
                }
                else if ((DateTime.Now - _selectedOrder.MustBeReturned).Days > 0)
                {
                    decimal Payment = (_selectedOrder.Cost + ((DateTime.Now - _selectedOrder.MustBeReturned).Days) * (_selectedOrder.Cost * 5 / 1000));
                    TxtPayment.Text = Payment.ToString();
                    BtnReturn.Show();
                    BtnCancel.Hide();
                }
                else
                {
                    TxtPayment.Text = _selectedOrder.Cost.ToString();
                    BtnReturn.Show();
                    BtnCancel.Hide();
                }
                return;
            }
            MessageBox.Show("This Book Is already Returned");
            TxtPayment.Text = string.Empty;
            TxtReturningBook.Text = string.Empty;
        }

        private void BtnReturn_Click(object sender, EventArgs e)
        {
            _selectedOrder.Returned = true;
            _selectedOrder.ReturnDate = DateTime.Now;

            _orderService.Update(_selectedOrder);

            DgvOrders.Rows[_selectedIndex].Cells[5].Value = true;
            Reset();
        }

        private void Reset()
        {
            TxtPayment.Text = string.Empty;
            TxtReturningBook.Text = string.Empty;
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            _orderService.Delete(_selectedOrder);
            DgvOrders.Rows.RemoveAt(_selectedIndex);
        }

        private void CmbMember_SelectedIndexChanged(object sender, EventArgs e)
        {
            _selectedMember = _memberService.Find((CmbMember.SelectedItem as ComboItem).Id);
            CmbMember.Text = _selectedMember.Fullname;
            //_selectedMember = _memberService.Find((CmbMember.SelectedItem as ComboItem).Id);
            Reset();
            DgvOrders.Rows.Clear();
            FillBooks();
        }
    }
}
