using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace API.Entities
{
  public class Product
  {

    [Key]
    public int id { get; set; }

    [Column(TypeName = "nvarchar(100)")]
    public string Name { get; set; }

    [Column(TypeName = "nvarchar(300)")]
    public string Description { get; set; }

    public long Price { get; set; }

    [Column(TypeName = "nvarchar(300)")]
    public string PictureUrl { get; set; }

    [Column(TypeName = "nvarchar(100)")]
    public string Type { get; set; }

    [Column(TypeName = "nvarchar(100)")]
    public string Brand { get; set; }

    public int QuantityInStock { get; set; }
  }
}