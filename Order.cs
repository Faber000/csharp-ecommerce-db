public class Order
{
    public int OrderId { get; set; }
    public List<Product> Products { get; set; }
    public int CustomerId { get; set; }
    public Customer Customer { get; set; }
    public int EmployeeId { get; set; }
    public Employee Employee { get; set; }
    public DateTime Date { get; set; }
    public double Amount { get; set; }
    public string Status { get; set; }
}
