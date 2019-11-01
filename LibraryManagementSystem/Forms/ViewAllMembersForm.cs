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
    }
}
