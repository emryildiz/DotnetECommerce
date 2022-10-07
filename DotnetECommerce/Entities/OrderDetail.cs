using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DotnetEcommerce.Entities;

[Table("OrderDetails")]
public class OrderDetail:BaseEntity
{
    public double Price { get; set; }

    public int Quantity { get; set; }

}
