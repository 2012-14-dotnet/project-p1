using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using Microsoft.Extensions.Configuration;
using PizzaBox.Storing;

namespace PizzaBox.WebClient.Models
{
  public class OrderViewModel
  {
    private readonly PizzaBoxContext _ctx;

    public List<string> Stores { get; set; }

    [Required]
    public string Store { get; set; }

    public OrderViewModel(IConfiguration configuration)
    {
      _ctx = new PizzaBoxContext(configuration);
      Stores = _ctx.Stores.Select(s => s.Name).ToList();
    }
  }
}
