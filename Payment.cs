﻿public class Payment
{
    public int PaymentId { get; set; }
    public int OrderId { get; set; }
    public Order Order { get; set; }
    public DateTime Date { get; set; }
    public double Amount { get; set; }
    public string Status { get; set; }
}
