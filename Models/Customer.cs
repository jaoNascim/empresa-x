using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace empresa_x.Models
{
    [Table("customer")]
    public class Customer
    {
        [Key]
        public int id { get; set; }

        public string name { get; set; } = string.Empty;

        public string address { get; set; } = string.Empty;

        public string phone { get; set; } = string.Empty;

        public string email { get; set; } = string.Empty;

        public Customer()
        {
        }

        public Customer(string name, string address, string phone, string email)
        {
            this.name = name;
            this.address = address;
            this.phone = phone;
            this.email = email;
        }
    }
}