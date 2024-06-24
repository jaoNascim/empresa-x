using empresa_x.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace empresa_x.Context
{
    public class ProductServices
    {
        private readonly Context _context = new Context();

        public List<Product> SelectAll()
        {
            return _context.Products.ToList();
        }

        public void Create(Product product)
        {
            _context.Products.Add(product);
            _context.SaveChanges();
        }

        public void Update(int id, string name, string description, int price, int qty)
        {
            var result = _context.Products.SingleOrDefault(c => c.id == id);

            if (result is not null)
            {
                result.name = name;
                result.description = description;
                result.price = price;
                result.qty = qty;

                _context.SaveChanges();
            }
        }

        public void Delete(int id)
        {
            var result = _context.Products.SingleOrDefault(c => c.id == id);

            if (result is not null)
            {
                _context.Products.Remove(result);
                _context.SaveChanges();
            }
        }
    }
}