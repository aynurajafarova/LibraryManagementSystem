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
    public partial class AddMemberForm : Form
    {
        private readonly MemberService _memberService;

        public AddMemberForm()
        {
            InitializeComponent();

            _memberService = new MemberService();
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            Member member = new Member()
            {
                Fullname = TxtMemberName.Text,
                Email = TxtMemberEmail.Text,
                Address = TxtMemberAddress.Text,
                Phone = TxtMemberPhone.Text
            };

            if(string.IsNullOrEmpty(TxtMemberName.Text)||
                string.IsNullOrEmpty(TxtMemberAddress.Text)||
                string.IsNullOrEmpty(TxtMemberEmail.Text)||
                string.IsNullOrEmpty(TxtMemberPhone.Text))
            {
                MessageBox.Show("Please complete all required fields");
            }
            else
            {
                _memberService.Add(member);
                MessageBox.Show("A new member named "+ TxtMemberName.Text+" has been added.");

                TxtMemberName.Text = string.Empty;
                TxtMemberAddress.Text = string.Empty;
                TxtMemberEmail.Text = string.Empty;
                TxtMemberPhone.Text = string.Empty;
            }
        }
    }
}
