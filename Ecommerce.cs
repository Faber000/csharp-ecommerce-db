using csharp_ecommerce_db;
using Microsoft.EntityFrameworkCore;

Console.WriteLine("Benvenuto");

using (Ecommerce db = new Ecommerce())
{
    Product product = new Product
    {
        Name = "Chitarra",
        Description = "ciao",
        Price = 199.99,
    };
    db.Products.Add(product);
    db.SaveChanges();
}

namespace csharp_ecommerce_db
{
    public class Ecommerce : DbContext
    {
        public DbSet<Order> Orders { get; set; }
        public DbSet<Payment> Payments { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Employee> Employees { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=localhost;Initial Catalog=db-ecommerce;Integrated Security=True");
        }
    }
}