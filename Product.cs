public class Product
{
    public int ProductId { get; set; }
    public List<Order> Orders { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public double Price{ get; set; }
}
