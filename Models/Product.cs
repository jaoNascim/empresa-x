﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace empresa_x.Models
{
    [Table("product")]
    public class Product
    {
        [Key]
        public int id { get; set; }

        public string name { get; set; }
        public string description { get; set; }
        public int price { get; set; }
        public int qty { get; set; }

        public Product()
        {
        }

        public Product(string name, string description, int price, int qty)
        {
            this.name = name;
            this.description = description;
            this.price = price;
            this.qty = qty;
        }
    }
}