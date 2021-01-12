using Microsoft.Extensions.Configuration;

namespace PizzaBox.WebClient.Models
{
  public class CustomerViewModel
  {
    public string Name { get; set; }
    public OrderViewModel Order { get; set; }

    public CustomerViewModel(IConfiguration configuration)
    {
      Name = "fred";
      Order = new OrderViewModel(configuration);
    }
  }
}
