using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace FinalAssignment_Part2.Models
{
    public class StoreContext : DbContext
    {
        public StoreContext()
            : base("name=StoreConnection")
        {
        }
        public virtual DbSet<FoodCourtModel> ProductModels { get; set; }
        public virtual DbSet<Cart> Carts { get; set; }
        public virtual DbSet<Order> Orders { get; set; }
        public virtual DbSet<OrderDetail> OrderDetails { get; set; }
    }
}