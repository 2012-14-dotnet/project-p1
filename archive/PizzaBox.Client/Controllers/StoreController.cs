using Microsoft.AspNetCore.Mvc;
using PizzaBox.Client.Models;

namespace PizzaBox.Client.Controllers
{
  [Route("[controller]")]
  public class StoreController : Controller
  {
    [HttpGet] //http://localhost:5000/store
    public IActionResult Get()
    {
      var stores = new StoreViewModel(); // static type inference
      StoreViewModel story = new StoreViewModel();



      dynamic stores2 = new StoreViewModel();
      stores2 = 10;

      // 1-way data binding
      ViewBag.Stores = stores.Stores; // dynamic object
      ViewData["Stores"] = stores.Stores; // dictionary object, Dictionary<string, object>

      // redirect data binding
      TempData["Stores"] = stores.Stores; //Dictionary<string, object>, serialization
      object s = new StoreViewModel();

      return View("StrongStore", new StoreViewModel());
    }

    [HttpGet("{store}")] //http://localhost:5000/store/<some value>
    public IActionResult Get(string store)
    {
      return View("Store", store);
    }

    // public void Post()
    // {

    // }

    // public void Put()
    // {

    // }

    // public void Delete()
    // {

    // }
  }
}
