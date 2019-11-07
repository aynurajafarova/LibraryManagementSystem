using LibraryManagementSystem.Services;
using System.Windows.Forms;

namespace LibraryManagementSystem.Forms
{
    public partial class ViewAllMembersForm : Form
    {
        private readonly MemberService _memberService;
        public ViewAllMembersForm()
        {
            InitializeComponent();

            _memberService = new MemberService();

            FillMembersTable();
        }

        // This method help us to fill the DgvViewAllMembers table
        private void FillMembersTable()
        {
            foreach (var member in _memberService.AllMembers())
            {
                DgvViewAllMembers.Rows.Add(member.Fullname,
                                           member.Email,
                                           member.Address,
                                           member.Phone);
            }
        }

        private void BtnBackArrow_Click(object sender, System.EventArgs e)
        {
            this.Hide();

            MainboardForm mainboardForm = new MainboardForm();
            mainboardForm.Show();
        }

        private void BtnSearchMember_Click(object sender, System.EventArgs e)
        {
            string memberFullname = TxtMemberFullname.Text;
            string memberEmail = TxtMemberEmail.Text;
            string memberPhone = TxtMemberPhone.Text;
            int findedMember = 0;

            DgvViewAllMembers.Rows.Clear();

            foreach (var member in _memberService.AllMembers())
            {
                if(member.Fullname.Contains(memberFullname) &&
                   member.Email.Contains(memberEmail) && 
                   member.Phone.Contains(memberPhone))
                {
                    DgvViewAllMembers.Rows.Add(member.Fullname,
                                           member.Email,
                                           member.Address,
                                           member.Phone);

                    findedMember += 1;
                }
            }
            if (findedMember == 0)
            {
                MessageBox.Show("Sistemdə belə bir istifadəçi tapılmadı");
            }
        }

        private void BtnEditMembers_Click(object sender, System.EventArgs e)
        {
            this.Hide();

            EditMembersForm editMembersForm = new EditMembersForm();
            editMembersForm.Show();
        }
    }
}
