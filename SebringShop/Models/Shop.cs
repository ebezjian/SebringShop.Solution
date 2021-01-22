using System.ComponentModel.DataAnnotations;

namespace SebringShop.Models
{
  public class Shop
  {
    public int ShopId { get; set; }
    [Required]
    [StringLength(40)]
    public string ShopName { get; set; }
    [Required]
    public string ShopAddress { get; set; }
    [Required]
    public string ShopType { get; set; }
    
  }
}