using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using SebringShop.Models;

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
    public ActionResult<IEnumerable<Resturant>> Get()
    {
      return _db.Resturants.ToList();
    }

    [HttpPost]
    public void Post ([FromBody] Resturant resturant)
    {
      _db.Resturants.Add(resturant);
      _db.SaveChanges();
    }
  }
}