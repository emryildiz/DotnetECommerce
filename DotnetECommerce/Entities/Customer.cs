using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DotnetEcommerce.Entities;

[Table("Customers")]
public class Customer
{
    public Customer()
    {
        this.Adresses = new List<Adress>();
        this.Orders = new List<Order>();
        this.CreatedDate = DateTime.Now;
    }

    [Key]
    public int ID { get; set; }

    public string? FirstName { get; set; }

    public string? SurName { get; set; }

    public string? Email { get; set; }

    public DateTime CreatedDate { get; set; }

    public DateTime UpdatedDate { get; set; }

    public List<Order>? Orders { get; set; }

    public List<Adress>? Adresses { get; set; }
}
