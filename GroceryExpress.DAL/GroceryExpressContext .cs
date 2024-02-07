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
        public DbSet<Shop> Shops { get; set; }
        public DbSet<ShopItem> ShopItems { get; set; }



        public DbSet<Order> Orders { get; set; }


        public DbSet<ItemOrder> OrderItems { get; set; }

        public GroceryExpressContext(DbContextOptions options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Order>(

              entity =>
              {
                  entity.HasKey(e => e.Id);
                  entity.HasIndex(e => e.Name);
                  entity.HasMany(e => e.Items)
                   .WithMany(e => e.Orders)
                   .UsingEntity<ItemOrder>(
                      itemOrder =>
                      {
                          itemOrder.HasOne(io => io.Item)
                                             .WithMany()
                                             .HasForeignKey(io => io.ItemId);
                          itemOrder.HasOne(io => io.Order)
                                   .WithMany()
                                   .HasForeignKey(io => io.OrderId);
                          itemOrder.HasKey(io => new { io.ItemId, io.OrderId });
                          itemOrder.Property(io => io.OrderDate)
                                    .HasDefaultValue(DateTime.Now);
                          itemOrder.Property(o => o.ItemPrice).HasColumnType("decimal(18,2)");
                      }
                      );
                  entity.HasOne(o => o.User)
                        .WithMany(c => c.Orders)
                        .HasForeignKey(o => o.UserId)
                        .OnDelete(DeleteBehavior.NoAction);

                  entity.HasOne(o => o.Shop)
                         .WithMany()
                         .HasForeignKey(o => o.ShopId)
                         .OnDelete(DeleteBehavior.NoAction);

                  entity.HasOne(o => o.Deliverer)
                      .WithMany()
                      .HasForeignKey(o => o.DelivererId)
                      .OnDelete(DeleteBehavior.NoAction);
              }

                );


            modelBuilder.Entity<Shop>()
                .HasMany(s => s.Items)
                .WithMany(i => i.Shops)
                .UsingEntity<ShopItem>(

                shopItem =>
                {
                    shopItem.HasOne(s => s.Shop).WithMany().HasForeignKey(s => s.ShopId);
                    shopItem.HasOne(s => s.Item).WithMany().HasForeignKey(s => s.ItemId);
                    shopItem.HasKey(io => new { io.ItemId, io.ShopId });

                }

                );

            modelBuilder.Entity<User>().HasIndex(u => u.Username).IsUnique();


            modelBuilder.Entity<Address>()
                .HasData(UserSeed.addresses);
            modelBuilder.Entity<Address>()
               .HasData(ShopSeed.addresses);

            modelBuilder.Entity<Shop>()
                .HasData(ShopSeed.shops);
            modelBuilder.Entity<User>() 
                .HasData(UserSeed.users);







        }

        protected override void ConfigureConventions(ModelConfigurationBuilder configurationBuilder)
        {
            configurationBuilder.Properties<GroceryCategory>().HaveConversion<CategoryConverter>();
            base.ConfigureConventions(configurationBuilder);
        }




    }
}
