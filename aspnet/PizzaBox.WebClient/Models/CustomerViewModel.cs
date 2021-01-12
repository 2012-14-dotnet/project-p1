using Microsoft.Extensions.Configuration;

namespace PizzaBox.WebClient.Models
{
  public class CustomerViewModel
  {
    public string Name { get; set; }
    public OrderViewModel Order { get; set; }

    public CustomerViewModel()
    {
      Name = "fred";
      Order = new OrderViewModel();
    }
  }
}
