using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entites
{
    public class Context : DbContext
    {
        public Context(DbContextOptions<Context> opt) : base(opt)
        {
        }
        //optional
        //protected override void OnConfiguring(DbContextOptionsBuilder DataContext)
        //{
        //    DataContext.UseSqlServer(@"Server=DESKTOP-HJB5TPB;Database=OrderDB;Trusted_Connection=True;Encrypt=false;user id=magdy;Password=5020786;");
        //}
        public DbSet<Order> Orders { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Item> Items { get; set; }
        public DbSet<Cart> Carts { get; set; }
        public DbSet<CartItem> CartItems { get; set; }

    }
}
