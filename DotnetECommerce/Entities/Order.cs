using System.ComponentModel.DataAnnotations.Schema;

namespace DotnetEcommerce.Entities;

[Table("Orders")]
public class Order
{
    public Order()
    {
        this.OrderDetails = new List<OrderDetail>();
    }

    public int ID { get; set; }

    public double Amount { get; set; }

    public DateTime CreatedAt { get; set; }

    public string? Status { get; set; }

    public List<OrderDetail>? OrderDetails { get; set; }
}
