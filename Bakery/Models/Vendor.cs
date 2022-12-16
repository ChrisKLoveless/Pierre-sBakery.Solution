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

    public Vendor(string name, string info)
    {
      Name = name;
      Info = info;
      _clients.Add(this);
      Id = _clients.Count;
      Orders = new List<Order> { };
    }
    
    public static void ClearAll()
    {
      _clients.Clear();
    }
  }
}