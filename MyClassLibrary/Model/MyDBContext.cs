using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyClassLibrary.Model
{
    public class MyDBContext : DbContext
    {
        public MyDBContext() : base("name=StrConect") { }
        public DbSet<Category> Categorys { get; set; }
        public DbSet<Config> Configs { get; set; }
        public DbSet<Product> Products { get; set; }
    }
}
