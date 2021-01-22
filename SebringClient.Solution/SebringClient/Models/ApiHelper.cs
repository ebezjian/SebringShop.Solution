using System.Threading.Tasks;
using RestSharp;

namespace SebringClient.Models
{
  class ApiHelper
  {
    public static async Task<string> GetAll()
    {
      RestClient client = new RestClient("http://localhost:5000/api");
      RestRequest requestResturants = new RestRequest($"resturants", Method.GET);
      var responseResturants = await client.ExecuteTaskAsync(requestResturants);
      return responseResturants.Content;      
    }
    public static async Task<string> GetAll()
    {
      RestClient client = new RestClient("http://localhost:5000/api");
      RestRequest requestShops = new RestRequest($"shops", Method.GET);
      var responseShops = await client.ExecuteTaskAsync(requestShops);
      return responseShops.Content;      
    }

    public static async Task Post(string newResturant)
    {
      RestClient client = new RestClient ("http://localhost:5000/api");
      RestRequest requestResturants = new RestRequest($"resturants", Method.POST);
      requestResturants.AddHeader("Content-Type", "application/json");
      requestResturants.AddJsonBody(newResturant);
      var responseResturants = await client.ExecuteTaskAsync(requestResturants);
    }
    public static async Task Post(string newShop)
    {
      RestClient client = new RestClient ("http://localhost:5000/api");
      RestRequest requestShops = new RestRequest($"shops", Method.POST);
      requestShops.AddHeader("Content-Type", "application/json");
      requestShops.AddJsonBody(newShop);
      var responseShops = await client.ExecuteTaskAsync(requestShops);
    }
  }
}