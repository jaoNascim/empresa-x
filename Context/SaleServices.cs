using empresa_x.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace empresa_x.Context
{
    public class SaleServices
    {
        private readonly Context _context = new Context();

        public List<Sale> SelectAll()
        {
            return _context.Sales.ToList();
        }

        public void Create(Sale sale)
        {
            _context.Sales.Add(sale);
            _context.SaveChanges();
        }

        public void Update(int id, int customer_id, int product_id, decimal qty)
        {
            var result = _context.Sales.SingleOrDefault(c => c.id == id);

            if (result is not null)
            {
                result.customer_id = customer_id;
                result.product_id = product_id;
                result.qty = qty;

                _context.SaveChanges();
            }
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