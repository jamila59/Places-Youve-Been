using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;  
using PlacesBeen.Models;

namespace PlacesBeen.Controllers
{
  public class HomeController : Controller
  {
      [HttpGet("/places/new")]
      public ActionResult Template() { return View(); }

      [HttpPost("/places")]//
      public ActionResult Second(string cityName) 
      {
      Location myLocation = new Location(cityName);
      List<Location> allItems = Location.GetAll();
      System.Console.WriteLine(allItems.Count);
      foreach(Location location in allItems)
      {
        System.Console.WriteLine(location);
      }
      return View("Second",allItems);
    }
  }
}