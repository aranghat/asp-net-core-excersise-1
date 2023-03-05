using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Exercise5.Models
{
    public class DataContext : DbContext
    {
        public DataContext() : base("GadgetWorldDB") { }
        public DbSet<Product> Products { get; set; }
    }
}