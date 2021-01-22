namespace SebringShop.Models
{
  public class Resturant
  {
    public int ResturantId { get; set; }
    public string ResturantName { get; set; }
    public string ResturantAddress { get; set; }
    public string ResturantFoodType { get; set; }
    
    public bool ResturantDelivery { get; set; }
  }
}