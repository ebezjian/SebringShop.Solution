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
  }
}