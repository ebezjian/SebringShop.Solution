using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SebringClient.Models;

namespace SebringClient.Controllers
{
  public class ResturantsController : Controller
  {
    public IActionResult Index()
    {
      var allResturants = Resturant.GetResturants();
      return View(allResturants);
    }

    [HttpPost]
    public IActionResult Index(Resturant resturant)
    {
      Resturant.Post(resturant);
      return RedirectToAction("Index");
    }

    public IActionResult Details(int id)
    {
      var resturant = Resturant.GetDetails(id);
      return View(resturant);
    }

    public IActionResult Edit(int id)
    {
      var resturant = Resturant.GetDetails(id);
      return View(resturant);
    }

    [HttpPost]
    public IActionResult Details(int id, Resturant resturant)
    {
      resturant.ResturantId = id;
      Resturant.Put(resturant);
      return RedirectToAction("Details", id);
    }

    public IActionResult Delete(int id)
    {
      Resturant.Delete(id);
      return RedirectToAction("Index");
    }
  }
}