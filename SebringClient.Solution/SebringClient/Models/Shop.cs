using System.Collections.Generic;
using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace SebringClient.Models
{
  public class Shop
  {
    public int ShopId { get; set; }

    public string ShopName { get; set; }

    public string ShopAddress { get; set; }

    public string ShopType { get; set; }
    public static List<Shop> GetShops()
    {
      var apiCallTask = ApiHelper.GetAll();
      var result = apiCallTask.Result;

      JArray jsonResponse = JsonConvert.DeserializeObject<JArray>(result);
      List<Shop> shopList = JsonConvert.DeserializeObject<List<Shop>>(jsonResponse.ToString());
      return shopList;
    }
    public static Shop GetDetails(int id)
    {
      var apiCallTask = ApiHelper.Get(id);
      var result = apiCallTask.Result;
      JObject jsonResponse = JsonConvert.DeserializeObject<JObject>(result);
      Shop shop = JsonConvert.DeserializeObject<Shop>(jsonResponse.ToString());
      return shop;
    }
  }
}