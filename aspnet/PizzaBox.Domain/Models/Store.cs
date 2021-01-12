using System.Collections.Generic;
using PizzaBox.Domain.Abstracts;

namespace PizzaBox.Domain.Models
{
  public class Store : AModel
  {
    public string Name { get; set; }
    public List<Order> Orders { get; set; }
  }
}
