using Microsoft.AspNetCore.Mvc;
using PizzaBox.Client.Models;

namespace PizzaBox.Client.Controllers
{
  public class OrderController : Controller
  {
    [HttpGet]
    public IActionResult Get()
    {
      return View("Order");
    }

    [HttpGet("{id}")]
    public IActionResult Get(string id)
    {
      return View("Order", new OrderViewModel());
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public IActionResult Post(OrderViewModel order)
    {
      if (ModelState.IsValid)
      {
        return View("OrderPass");
      }

      return View("OrderFail");
    }
  }
}
