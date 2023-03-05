using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Exercise5.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Brand { get; set; }
        public int Quantity { get; set; }
        public int Price { get; set; }
    }
}