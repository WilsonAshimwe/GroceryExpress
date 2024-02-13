using GroceryExpress.DAL.Seeders;
using GroceryExpress.Domain.Enums;
using GroceryExpress.DOMAIN.Entities;
using GroceryExpress.DOMAIN.Utils;
using Microsoft.EntityFrameworkCore;

namespace GroceryExpress.DAL
{
    public class GroceryExpressContext : DbContext
    {

        public DbSet<User> Users { get; set; }
        public DbSet<Address> Addresses { get; set; }

        public DbSet<Item> Items { get; set; }

        public DbSet<Deliverer> Deliverers { get; set; }



        public DbSet<Order> Orders { get; set; }


        public DbSet<ItemOrder> OrderItems { get; set; }

        public GroceryExpressContext(DbContextOptions options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            //modelBuilder.Entity<Order>(

            //  entity =>
            //  {
            //      entity.HasKey(e => e.Id);
            //      entity.HasIndex(e => e.OrderDate);
            //      entity.HasMany(e => e.ItemOrders)
            //       .WithOne(e => e.Order)
            //       .UsingEntity<ItemOrder>(
            //          itemOrder =>
            //          {
            //              itemOrder.HasOne(io => io.Item)
            //                                 .WithMany()
            //                                 .HasForeignKey(io => io.ItemId);
            //              itemOrder.HasOne(io => io.Order)
            //                       .WithMany()
            //                       .HasForeignKey(io => io.OrderId);
            //              itemOrder.HasKey(io => new { io.ItemId, io.OrderId });
            //              itemOrder.Property(o => o.ItemPrice).HasColumnType("decimal(18,2)");
            //          }
            //          );
            //      entity.HasOne(o => o.User)
            //            .WithMany(c => c.Orders)
            //            .HasForeignKey(o => o.UserId)
            //            .OnDelete(DeleteBehavior.NoAction);


            //  }

            //    );

            modelBuilder.Entity<ItemOrder>().HasKey(i => new { i.OrderId, i.ItemId });

            modelBuilder.Entity<User>().HasIndex(u => u.Username).IsUnique();



            modelBuilder.Entity<Address>()
                .HasData(UserSeed.addresses);
            modelBuilder.Entity<User>()
                .HasData(UserSeed.users);
            modelBuilder.Entity<Item>()
            .HasData(ItemSeed.Items);







        }

        protected override void ConfigureConventions(ModelConfigurationBuilder configurationBuilder)
        {
            configurationBuilder.Properties<GroceryCategory>().HaveConversion<CategoryConverter>();
            base.ConfigureConventions(configurationBuilder);
        }




    }
}
