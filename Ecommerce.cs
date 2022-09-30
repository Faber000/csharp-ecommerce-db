using csharp_ecommerce_db;
using Microsoft.EntityFrameworkCore;

Console.WriteLine("Benvenuto");

using (Ecommerce db = new Ecommerce())
{
    Product chitarra = new Product
    {
        Name = "Chitarra",
        Description = "ciao",
        Price = 199.99,
    };

    Product batteria = new Product
    {
        Name = "Batteria Pearl",
        Description = "batteria super figa stratosferica",
        Price = 1999.99,
    };

    Employee employee = new Employee
    {
        Name = "Mario",
        Surname = "Rossi",
        Level = "impiegato"
    };

    Customer customer = new Customer
    {
        Name = "Fabio",
        Surname = "Moro",
        Email = "fabio.moro@gmail.com",
    };
    db.Employees.Add(employee);
    db.Customers.Add(customer);
    db.Products.Add(chitarra);
    db.Products.Add(batteria);
    db.SaveChanges();

    // Read
    List<Product> products = db.Products.OrderBy(product => product.Name).ToList<Product>();

    // Search prodotto
    Product prodottoBatteria = db.Products.Where(product => product.Name == "Batteria Pearl").First();

    Console.WriteLine("Descrizione del prodotto cercato: "+prodottoBatteria.Description);
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