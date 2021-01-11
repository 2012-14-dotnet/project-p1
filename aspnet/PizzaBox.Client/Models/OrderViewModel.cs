using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace PizzaBox.Client.Models
{
  public class OrderViewModel
  {
    public List<string> Stores { get; set; }
    public List<string> Pizzas { get; set; }

    [Required]
    public string Store { get; set; }

    [Required]
    [Range(1, 5)]
    public List<string> PizzaSelection { get; set; }

    public OrderViewModel()
    {
      Pizzas = new List<string>
      {
        "pizza1",
        "pizza2",
        "pizza3"
      };

      Stores = new List<string>
      {
        "store1",
        "store2",
        "store3"
      };

      PizzaSelection = new List<string>();
    }
  }
}
