using System.ComponentModel.DataAnnotations;

namespace SebringShop.Models
{
  public class Resturant
  {
    public int ResturantId { get; set; }
    [Required]
    [StringLength(30)]
    public string ResturantName { get; set; }
    [Required]
    public string ResturantAddress { get; set; }
    [Required]
    public string ResturantFoodType { get; set; }
    [Required]
    
    public bool ResturantDelivery { get; set; }
  }
} 