using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DotnetEcommerce.Entities;
[Table("Adresses")]
public class Adress:BaseEntity
{
    public string? City { get; set; }

    public string? Street { get; set; }

    public string? PostalCode { get; set; }

    public string? Detail { get; set; }
}
