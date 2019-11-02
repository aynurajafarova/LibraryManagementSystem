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

        public void Update(Member member)
        {
            if (!this.Contains(member.Id))
            {
                throw new NullReferenceException();
            }

            _libraryContext.Entry(member).State = System.Data.Entity.EntityState.Modified;
            _libraryContext.SaveChanges();
        }

        public void Delete(Member member)
        {
            if (!this.Contains(member.Id))
            {
                throw new NullReferenceException();
            }

            _libraryContext.Members.Remove(member);
            _libraryContext.SaveChanges();
        }

        public List<Member> AllMembers()
        {
            return _libraryContext.Members.ToList();
        }

        public Member Find(int Id)
        {
            Member member = _libraryContext.Members.FirstOrDefault(m => m.Id == Id);

            return member;
        }

        public bool Contains(int id)
        {
            return _libraryContext.Members.Any(m=>m.Id==id);
        }
    }
}
