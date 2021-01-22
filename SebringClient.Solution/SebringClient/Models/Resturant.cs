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
    public static List<Resturant> GetResturants()
    {
      var apiCallTask = ApiHelper.GetAll();
      var result = apiCallTask.Result;

      JArray jsonResponse = JsonConvert.DeserializeObject<JArray>(result);
      List<Resturant> shopList = JsonConvert.DeserializeObject<List<Resturant>>(jsonResponse.ToString());
      return shopList;
    }

    public static Resturant GetDetails(int id)
    {
      var apiCallTask = ApiHelper.Get(id);
      var result = apiCallTask.Result;
      JObject jsonResponse = JsonConvert.DeserializeObject<JObject>(result);
      Resturant resturant = JsonConvert.DeserializeObject<Resturant>(jsonResponse.ToString());
      return resturant;
    }
    public static void Put (Resturant resturant)
    {
      string jsonResturant = JsonConvert.SerializeObject(resturant);
      var apiCallTask = ApiHelper.Put(resturant.ResturantId, jsonResturant);
    }
    public static void Post(Resturant resturant)
    {
      string jsonResturant = JsonConvert.SerializeObject(resturant);
      var apiCallTask = ApiHelper.Post(jsonResturant);
    }
  }
}