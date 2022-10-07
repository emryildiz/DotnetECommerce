using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DotnetEcommerce.Entities;

[Table("Products")]
public class Product
{
    public Product()
    {
        this.OrderDetails = new List<OrderDetail>();
    }

    [Key]
    public int ID { get; set; }

    public string? Name { get; set; }

    public string? Description { get; set; }

    public double Weight { get; set; }

    public double Price { get; set; }

    public DateTime CreatedDate { get; set; }

    public int Stock { get; set; }

    [ForeignKey("OrderDetail")]
    public List<OrderDetail>? OrderDetails { get; set; }
}
