using System.Collections.Generic;

namespace Bakery.Models
{
  public class Vendor
  {
    public string Name { get; set; }
    public string Info { get; set; }
    public int Id { get; }
    public static List<Vendor> _clients = new List<Vendor> { };
    public List<Order> Orders { get; set; }

    public Vendor()
    {

    }
    
    public static void ClearAll()
    {
      _instances.Clear();
    }
  }
}