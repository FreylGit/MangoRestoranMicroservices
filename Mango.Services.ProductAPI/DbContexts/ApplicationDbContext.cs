using Mango.Services.ProductAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace Mango.Services.ProductAPI.DbContexts
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options):base(options)
        {

        }
        public DbSet<Product>Products { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Product>().HasData(new Product
            {
                ProductId = 1,
                Name = "Samosa",
                Price = 15,
                Description = "Боксит, скажем, за 100 тысяч лет, причленяет к себе тектонический термокарст. Комплекс покрывает флювиогляциальный блеск, делая этот типологический таксон районирования носителем важнейших инженерно-геологических характеристик природных условий. Батиаль разогрета. Океаническое ложе формирует",
                ImageUrl = "https://i.pinimg.com/originals/29/df/58/29df58cb2d677b950d073cf8cc21418b.jpg",
                CategoryName = "Appetizer"
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                ProductId = 2,
                Name = "Paneer Tikka",
                Price = 13.22M,
                Description = "Боксит, скажем, за 100 тысяч лет, причленяет к себе тектонический термокарст. Комплекс покрывает флювиогляциальный блеск, делая этот типологический таксон районирования носителем важнейших инженерно-геологических характеристик природных условий. Батиаль разогрета. Океаническое ложе формирует",
                ImageUrl = "https://eda.yandex/images/1380298/9057ba70a760213ab552e93eebc57969-450x300.jpg",
                CategoryName = "Appetizer"
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                ProductId = 3,
                Name = "Sweet Pie",
                Price = 19.52M,
                Description = "Боксит, скажем, за 100 тысяч лет, причленяет к себе тектонический термокарст. Комплекс покрывает флювиогляциальный блеск, делая этот типологический таксон районирования носителем важнейших инженерно-геологических характеристик природных условий. Батиаль разогрета. Океаническое ложе формирует",
                ImageUrl = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcS1gRnMvOqlvbRBmVC1DnajLW4gSvtvK0jTVg&usqp=CAU",
                CategoryName = "Dessert"
            });
        }
    }
}
