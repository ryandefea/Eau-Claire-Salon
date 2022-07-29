using System.Collections.Generic;

namespace BestRestaurants.Models
{
  public class Category
  {
    public Category()
    {
      this.Restaurants = new HashSet<Restaurant>();
    }

    public int CategoryId { get; set; }
    public string Name { get; set; }
    public virtual ICollection<Restaurant> Restaurants { get; set; }
  }
}