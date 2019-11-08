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
    public partial class EditMembersForm : Form
    {
        private readonly MemberService _memberService;

        private Member _selectedMember;

        private int _selectedRowIndex;

        public EditMembersForm()
        {
            InitializeComponent();

            _memberService = new MemberService();

            _selectedMember = new Member();

            FillMembers();

            BtnAdd.Show();
            BtnDelete.Hide();
            BtnUpdate.Hide();
        }

        private void FillMembers()
        {
            foreach (var member in _memberService.AllMembers())
            {
                DgvViewAllMembers.Rows.Add(member.Id,
                                           member.Fullname,
                                           member.Email,
                                           member.Password,
                                           member.Address,
                                           member.Phone,
                                           member.CreatedAt);
            }
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            Member member = new Member
            {
                Fullname = TxtMemberFullname.Text,
                Email = TxtMemberEmail.Text,
                Password = TxtMemberPassword.Text,
                Address = TxtMemberAddress.Text,
                Phone = TxtMemberPhone.Text,
                CreatedAt = DtpCreatedAt.Value
            };

            if (string.IsNullOrEmpty(TxtMemberFullname.Text) ||
               string.IsNullOrEmpty(TxtMemberEmail.Text) ||
               string.IsNullOrEmpty(TxtMemberPassword.Text) ||
               string.IsNullOrEmpty(TxtMemberAddress.Text) ||
               string.IsNullOrEmpty(TxtMemberPhone.Text) ||
               string.IsNullOrEmpty(Convert.ToString(DtpCreatedAt.Value)))
            {
                MessageBox.Show("Zəhmət olmasa, bütün məlumatları daxil edin", "Uğursuz əməliyyat!");
            }
            else
            {
                _memberService.Add(member);

                DgvViewAllMembers.Rows.Add(member.Id,
                                           member.Fullname,
                                           member.Email,
                                           member.Password,
                                           member.Address,
                                           member.Phone,
                                           member.CreatedAt);

                MessageBox.Show(TxtMemberFullname.Text + " adlı yeni istifadəçi əlavə edildi", "Uğurlu əməliyyat!");

                Reset();
            }
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            _selectedMember.Fullname = TxtMemberFullname.Text;
            _selectedMember.Address = TxtMemberAddress.Text;
            _selectedMember.CreatedAt = DtpCreatedAt.Value;
            _selectedMember.Email = TxtMemberEmail.Text;
            _selectedMember.Password = TxtMemberPassword.Text;
            _selectedMember.Phone = TxtMemberPhone.Text;

            _memberService.Update(_selectedMember);

            Reset();

            DgvViewAllMembers.Rows[_selectedRowIndex].Cells[1].Value = _selectedMember.Fullname;
            DgvViewAllMembers.Rows[_selectedRowIndex].Cells[2].Value = _selectedMember.Email;
            DgvViewAllMembers.Rows[_selectedRowIndex].Cells[3].Value = _selectedMember.Password;
            DgvViewAllMembers.Rows[_selectedRowIndex].Cells[4].Value = _selectedMember.Address;
            DgvViewAllMembers.Rows[_selectedRowIndex].Cells[5].Value = _selectedMember.Phone;
            DgvViewAllMembers.Rows[_selectedRowIndex].Cells[6].Value = _selectedMember.CreatedAt;

            MessageBox.Show(_selectedMember.Fullname + " adlı istifadəçi məlumatları yeniləndi", "Yeniləmə");
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bu istifadəçini silmək istədiyinizdən əminsiniz?", "Silmə", MessageBoxButtons.YesNo);

            if (dialogResult == DialogResult.Yes)
            {
                _memberService.Delete(_selectedMember);

                DgvViewAllMembers.Rows.RemoveAt(_selectedRowIndex);
                MessageBox.Show(_selectedMember.Fullname + " adlı istifadəçi silindi", "Uğurlu əməliyyat!");

                Reset();
            }

        }

        private void DgvViewAllMembers_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            _selectedMember = _memberService.Find(Convert.ToInt32(DgvViewAllMembers.Rows[e.RowIndex].Cells[0].Value));

            _selectedRowIndex = e.RowIndex;

            TxtMemberFullname.Text = _selectedMember.Fullname;
            TxtMemberAddress.Text = _selectedMember.Address;
            TxtMemberEmail.Text = _selectedMember.Email;
            TxtMemberPassword.Text = _selectedMember.Password;
            TxtMemberPhone.Text = _selectedMember.Phone;
            DtpCreatedAt.Value = _selectedMember.CreatedAt;

            BtnAdd.Hide();
            BtnDelete.Show();
            BtnUpdate.Show();
        }

        private void Reset()
        {
            TxtMemberAddress.Clear();
            TxtMemberEmail.Clear();
            TxtMemberFullname.Clear();
            TxtMemberPhone.Clear();
            DtpCreatedAt.ResetText();
        }

        private void BtnBackArrow_Click(object sender, EventArgs e)
        {
            this.Hide();

            ViewAllMembersForm viewAllMembersForm = new ViewAllMembersForm();
            viewAllMembersForm.Show();
        }

        private void BtnMainboard_Click(object sender, EventArgs e)
        {
            this.Hide();

            MainboardForm mainboardForm = new MainboardForm();
            mainboardForm.Show();
        }
    }
}
