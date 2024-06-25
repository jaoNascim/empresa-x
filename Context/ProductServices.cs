using empresa_x.Models;
using System.Collections.Generic;
using System.Linq;

namespace empresa_x.Context
{
    public class ProductServices
    {
        private readonly Context _context = new Context();

        public List<Product> SelectAll()
        {
            return _context.Products.ToList();
        }

        public Product SelectById(int id)
        {
            var result = _context.Products.SingleOrDefault(x => x.id == id);
            return result;
        }

        public Product Create(Product product)
        {
            _context.Products.Add(product);
            _context.SaveChanges();

            return product;
        }

        public Product Update(int id, string name, string description, decimal price, decimal qty)
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

            return result;
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