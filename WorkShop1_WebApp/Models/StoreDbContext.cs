using Microsoft.EntityFrameworkCore;

namespace WorkShop1_WebApp.Models
{

    public class StoreDbContext : DbContext
    {
        public DbSet<Product> Products { get; set; }

        public StoreDbContext(DbContextOptions options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 1,
                Category = "LapTop",
                Description = "Dell_V110 tetsttsttstst",
                Name = "Dell_V110",
                Price = 100

            },

            new Product
            {
                Id = 2,
                Category = "LapTop",
                Description = "Acer_V110 tetsttsttstst",
                Name = "Acer_V110",
                Price = 522

            },
                       new Product
                       {
                           Id = 3,
                           Category = "LapTop",
                           Description = "Toshiba_V110 tetsttsttstst",
                           Name = "Toshiba_V110",
                           Price = 500

                       },

               new Product
               {
                   Id = 4,
                   Category = "Computer",
                   Description = "tetsttsttstst",
                   Name = "AllInOne_V110",
                   Price = 800

               },

new Product
{
    Id = 5,
    Category = "Computer",
    Description = "tetsttsttstst",
    Name = "Dell_V110",
    Price = 600

},
new Product
{
    Id = 6,
    Category = "Mobile",
    Description = "tetsttsttstst",
    Name = "Iphone_V110",
    Price = 500

},
new Product
{
    Id = 7,
    Category = "Mobile",
    Description = "tetsttsttstst",
    Name = "Sumsung_V110",
    Price = 750

}
            );


            base.OnModelCreating(modelBuilder);
        }
    }
}
