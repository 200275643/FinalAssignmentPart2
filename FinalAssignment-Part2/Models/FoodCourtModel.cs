namespace FinalAssignment_Part2.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class FoodCourtModel : DbContext
    {
        public FoodCourtModel()
            : base("name=FoodCourtModel")
        {
        }

        public virtual DbSet<Cart> Carts { get; set; }
        public virtual DbSet<OrderDetail> OrderDetails { get; set; }
        public virtual DbSet<Order> Orders { get; set; }
        public virtual DbSet<ProductModel> ProductModels { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ProductModel>()
                .HasMany(e => e.OrderDetails)
                .WithOptional(e => e.ProductModel)
                .HasForeignKey(e => e.ProductModels_ID);
        }
    }
}
