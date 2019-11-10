using LibraryManagementSystem.DAL;
using LibraryManagementSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem.Services
{
    class OrderService
    {
        private readonly LibraryContext _libraryContext;

        public OrderService()
        {
            _libraryContext = new LibraryContext();
        }

        public int Add(Order order)
        {
            _libraryContext.Orders.Add(order);
            _libraryContext.SaveChanges();

            return order.Id;
        }

        public void Delete(Order order)
        {
            _libraryContext.Orders.Remove(order);
            _libraryContext.SaveChanges();
        }

        public List<Order> Orders()
        {
            return _libraryContext.Orders.Include("Book").Include("Member").ToList();
        }

        public Order Find(int id)
        {
            Order order = _libraryContext.Orders.Include("Book").FirstOrDefault(b => b.Id == id);
            return order;
        }

        public void Update(Order order)
        {
            _libraryContext.Entry(order).State = System.Data.Entity.EntityState.Modified;
            _libraryContext.SaveChanges();
        }
    }
}
