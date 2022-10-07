using System.ComponentModel.DataAnnotations.Schema;

namespace DotnetEcommerce.Entities;

[Table("Orders")]
public class Order:BaseEntity
{
    public Order()
    {
        this.OrderDetails = new List<OrderDetail>();
    }

    public double Amount { get; set; }

    public DateTime CreatedAt { get; set; }

    public string? Status { get; set; }

    public List<OrderDetail>? OrderDetails { get; set; }
}
