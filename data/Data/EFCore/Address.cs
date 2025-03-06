using System.ComponentModel.DataAnnotations.Schema;

namespace EFCore;

[Table("Address", Schema = "Person")]
public class Address
{
    public int AddressID { get; set; }
    public string AddressLine1 { get; set; }
    public string City { get; set; }
    public string PostalCode { get; set; }
}