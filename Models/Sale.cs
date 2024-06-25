using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace empresa_x.Models
{
    [Table("sale")]
    public class Sale
    {
        [Key]
        public int id { get; set; }

        public int customer_id { get; set; }
        public int product_id { get; set; }
        public decimal qty { get; set; }

        public Sale()
        {
        }

        public Sale(int customer_id, int product_id, decimal qty)
        {
            this.customer_id = customer_id;
            this.product_id = product_id;
            this.qty = qty;
        }
    }
}