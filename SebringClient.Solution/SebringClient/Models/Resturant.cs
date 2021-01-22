using System.Collections.Generic;
using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace SebringClient.Models
{
  public class Resturant
  {
    public int ShopId { get; set; }

    public string ResturantName { get; set; }

    public string ResturantAddress { get; set; }

    public string ResturantType { get; set; }
    public bool ResturantDelivery { get; set; }
    public static void Put (Resturant resturant)
    {
      string jsonResturant = JsonConvert.SerializeObject(resturant);
      var apiCallTask = ApiHelper.Put(resturant.ResturantId, jsonResturant);
    }
    public static List<Resturant> GetResturants()
    {
      var apiCallTask = ApiHelper.GetAll();
      var result = apiCallTask.Result;

      JArray jsonResponse = JsonConvert.DeserializeObject<JArray>(result);
      List<Resturant> shopList = JsonConvert.DeserializeObject<List<Resturant>>(jsonResponse.ToString());
      return shopList;
    }
  }
}