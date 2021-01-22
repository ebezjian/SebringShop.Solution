using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using SebringShop.Models;
using Microsoft.EntityFrameworkCore;

namespace SebringShop.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class ResturantsController : ControllerBase
  {
    private SebringShopContext _db;
    public ResturantsController(SebringShopContext db)
    {
      _db = db;
    }
    [HttpGet]
    public ActionResult<IEnumerable<Resturant>> Get(string resturantname, string resturantaddress, string resturantfoodtype,bool resturantdelivery)
    {
      var query =_db.Resturants.AsQueryable();
      if (resturantname != null)
      {
        query = query.Where(entry => entry.ResturantName == resturantname);
      }
      if (resturantaddress != null)
      {
        query = query.Where(entry => entry.ResturantAddress == resturantaddress);
      }
      if (resturantfoodtype != null)
      {
        query = query.Where(entry => entry.ResturantFoodType == resturantfoodtype);
      }
      if (resturantdelivery != true)
      {
        query = query.Where(entry => entry.ResturantDelivery == resturantdelivery);
      }
      return _db.Resturants.ToList();
    }

    [HttpPost]
    public void Post ([FromBody] Resturant resturant)
    {
      _db.Resturants.Add(resturant);
      _db.SaveChanges();
    }
    [HttpGet("{id}")]
    public ActionResult<Resturant> Get(int id)
    {
      return _db.Resturants.FirstOrDefault(entry => entry.ResturantId == id);
    }
    [HttpPut("{id}")]
    public void Put(int id, [FromBody] Resturant resturant)
    {
      resturant.ResturantId = id;
      _db.Entry(resturant).State = EntityState.Modified;
      _db.SaveChanges();
    }
    [HttpDelete("{id}")]
    public void Delete(int id)
    {
      var resturantToDelete = _db.Resturants.FirstOrDefault(entry => entry.ResturantId == id);
      _db.Resturants.Remove(resturantToDelete);
      _db.SaveChanges();
    }
  }
}