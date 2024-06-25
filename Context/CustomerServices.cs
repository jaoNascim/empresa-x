using empresa_x.Models;
using System.Collections.Generic;
using System.Linq;

namespace empresa_x.Context
{
    public class CustomerServices
    {
        private readonly Context _context = new Context();

        public List<Customer> SelectAll()
        {
            return _context.Customers.ToList();
        }

        public Customer SelectById(int id)
        {
            return _context.Customers.Where(x => x.id == id).FirstOrDefault();
        }

        public Customer Create(Customer customer)
        {
            _context.Customers.Add(customer);
            _context.SaveChanges();

            return customer;
        }

        public Customer Update(int id, string name, string address, string phone, string email)
        {
            var result = _context.Customers.SingleOrDefault(c => c.id == id);

            if (result is not null)
            {
                result.name = name;
                result.address = address;
                result.phone = phone;
                result.email = email;

                _context.SaveChanges();
            }

            return result;
        }

        public void Delete(int id)
        {
            var result = _context.Customers.SingleOrDefault(c => c.id == id);

            if (result is not null)
            {
                _context.Customers.Remove(result);
                _context.SaveChanges();
            }
        }
    }
}