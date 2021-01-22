using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using SebringShop.Models;
using Microsoft.EntityFrameworkCore;

namespace SebringShop.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class ShopsController : ControllerBase
  {
    private SebringShopContext _db;
    public ShopsController(SebringShopContext db)
    {
      _db = db;
    }
    [HttpGet]
    public ActionResult<IEnumerable<Shop>> Get()
    {
      return _db.Shops.ToList();
    }

    [HttpPost]
    public void Post ([FromBody] Shop shop)
    {
      _db.Shops.Add(shop);
      _db.SaveChanges();
    }
    [HttpGet("{id}")]
    public ActionResult<Shop> Get(int id)
    {
      return _db.Shops.FirstOrDefault(entry => entry.ShopId == id);
    }
    [HttpPut("{id}")]
    public void Put(int id, [FromBody] Shop shop)
    {
      shop.ShopId = id;
      _db.Entry(shop).State = EntityState.Modified;
      _db.SaveChanges();
    }
  }
}