using System.Collections.Generic;

namespace HairSalon.Models
{
  public class Stylist
  {
    public Stylist()
    {
      this.Clients = new HashSet<Restaurant>();
    }

    public int StylistId { get; set; }
    public string Name { get; set; }
    public virtual ICollection<Restaurant> Clients { get; set; }
  }
}