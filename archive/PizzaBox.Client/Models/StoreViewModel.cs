using System.Collections.Generic;

namespace PizzaBox.Client.Models
{
  public class StoreViewModel
  {
    public PizzaViewModel Pizzas { get; set; }
    public List<string> Stores { get; set; }

    public StoreViewModel()
    {
      Pizzas = new PizzaViewModel();
      Stores = new List<string>()
      {
        "Dallas",
        "Austin",
        "Houston",
        "San Antonio"
      };
    }
  }
}
