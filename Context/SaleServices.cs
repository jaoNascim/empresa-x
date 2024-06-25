using empresa_x.Models;
using System.Collections.Generic;
using System.Linq;

namespace empresa_x.Context
{
    public class SaleServices
    {
        private readonly Context _context = new Context();

        public List<Sale> SelectAll()
        {
            return _context.Sales.ToList();
        }

        public List<Sale> SelectById(int id)
        {
            return _context.Sales.Where(x => x.id == id).ToList();
        }

        public Sale Create(Sale sale)
        {
            _context.Sales.Add(sale);
            _context.SaveChanges();

            return sale;
        }

        public Sale Update(int id, int customer_id, int product_id, decimal qty)
        {
            var result = _context.Sales.SingleOrDefault(c => c.id == id);

            if (result is not null)
            {
                result.customer_id = customer_id;
                result.product_id = product_id;
                result.qty = qty;

                _context.SaveChanges();
            }

            return result;
        }

        public void Delete(int id)
        {
            var result = _context.Sales.SingleOrDefault(c => c.id == id);

            if (result is not null)
            {
                _context.Sales.Remove(result);
                _context.SaveChanges();
            }
        }
    }
}