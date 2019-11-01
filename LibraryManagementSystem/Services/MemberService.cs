using LibraryManagementSystem.DAL;
using LibraryManagementSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem.Services
{
    class MemberService
    {
        private readonly LibraryContext _libraryContext;

        public MemberService()
        {
            _libraryContext = new LibraryContext();
        }

        public int Add(Member member)
        {
            _libraryContext.Members.Add(member);
            _libraryContext.SaveChanges();

            return member.Id;
        }
    }
}
