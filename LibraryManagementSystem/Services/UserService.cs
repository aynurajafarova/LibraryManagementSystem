using LibraryManagementSystem.DAL;
using LibraryManagementSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem.Services
{
    class UserService
    {
        private readonly LibraryContext _libraryContext;

        public UserService()
        {
            _libraryContext = new LibraryContext();
        }

        public int Add(User user)
        {
            _libraryContext.Users.Add(user);
            _libraryContext.SaveChanges();

            return user.Id;
        }

        public User Find(string username, string password)
        {
            User user = _libraryContext.Users.FirstOrDefault(u => u.Username== username && u.Password==password);

            return user;
        }
    }
}
